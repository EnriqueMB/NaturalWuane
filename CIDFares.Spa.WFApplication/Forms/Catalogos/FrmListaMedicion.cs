using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Library.Controls.CIDWait.Code;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Session;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmListaMedicion : Form
    {
        #region Propiedades
        public ListaMedicionViewModel Model { get; set; }
        #endregion

        #region Constructor
        public FrmListaMedicion(int id)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ListaMedicionViewModel>();
            Model.IdListaMedicion = id;
            if (id > 0)
                Model.State = EntityState.Update;
            this.BtnAgregar.FlatAppearance.BorderSize = 1;
            this.btnQuitar.FlatAppearance.BorderSize = 1;
        }
        #endregion

        #region Metodos

        private void IniciarBinding()
        {
            try
            {
                NombreControl.DataBindings.Add("Text", Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
                DescripcionControl.DataBindings.Add("Text", Model, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);

                sfDataGridListaMedicion.AutoGenerateColumns = false;
                sfDataGridListaMedicion.DataBindings.Add("DataSource", Model, "ListaValores", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void LimpiarPropiedades()
        {
            try
            {
                Model.Nombre = string.Empty;
                Model.Descripcion = string.Empty;
                Model.ListaValores.Clear();
                ValorControl.Text = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ValorLista ObtenerSeleccionado()
        {
            try
            {
                if (sfDataGridListaMedicion.SelectedItems.Count == 1)
                {
                    return (ValorLista)sfDataGridListaMedicion.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ObtenerTabla(List<ValorLista> lista)
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla.Columns.Add("Valor", typeof(string));
                foreach (var item in lista)
                {
                    tabla.Rows.Add(new object[] { item.Valor });
                }
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Eventos
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(ValorControl, string.Empty);
                if (!string.IsNullOrWhiteSpace(ValorControl.Text))
                {
                    var item = Model.ListaValores.Where(l => l.Valor == ValorControl.Text.Trim()).Select(x => x.Valor).ToList();
                    if (item.Count == 0)
                    {
                        ValorLista valorLista = new ValorLista
                        {
                            Valor = ValorControl.Text.Trim()
                        };
                        Model.ListaValores.Add(valorLista);
                    }
                    else
                        errorProvider1.SetError(ValorControl, "Ya existe un valor con el mismo nombre");
                }
                else
                    errorProvider1.SetError(ValorControl, "Ingrese el nombre del nuevo valor de la lista");
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmDireccionesCliente ~ BtnAgregar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorLoadMessage, TypeMessage.error);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(btnQuitar, string.Empty);
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    Model.ListaValores.Remove(item);
                }
                else
                    errorProvider1.SetError(btnQuitar, "Seleccione una fila de la lista");
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmDireccionesCliente ~ btnQuitar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.error);
            }
        }

        private async void btnGuarda_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(BtnAgregar, string.Empty);
                btnGuarda.Enabled = false;
                this.CleanErrors(errorProvider1, typeof(ListaMedicionViewModel));
                var ValidationsResult = Model.Validate();
                if (ValidationsResult.IsValid)
                {
                    if (Model.ListaValores.Count > 0)
                    {
                        DataTable tabla = ObtenerTabla(Model.ListaValores.ToList());
                        var result = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario, tabla);
                        if (result.IdListaMedicion > 0)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                            LimpiarPropiedades();
                            Close();
                        }
                        else
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                        }
                    }
                    else
                        errorProvider1.SetError(BtnAgregar, "Debe agregar por lo menos un valor a la lista");
                }
                else
                    this.ShowErrors(errorProvider1, typeof(ListaMedicionViewModel), ValidationsResult);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmDireccionesCliente ~ btnGuarda_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
            finally {
                btnGuarda.Enabled = true;
            }
        }

        private  void FrmListaMedicion_Load(object sender, EventArgs e)
        {
            
        }

        private async void NombreControl_Leave(object sender, EventArgs e)
        {
            try
            {
                btnGuarda.Enabled = true;
                errorProvider1.SetError(NombreControl, string.Empty);
                var result = await Model.ValidarNombre();
                if(result > 0)
                {
                    if (Model.IdListaMedicion > 0)
                    {
                        if (result != Model.IdListaMedicion)
                        {
                            btnGuarda.Enabled = false;
                            errorProvider1.SetError(NombreControl, "El nombre ya existe en los registros");
                        }
                    }
                    else
                    {
                        btnGuarda.Enabled = false;
                        errorProvider1.SetError(NombreControl, "El nombre ya existe en los registros");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CIDMessageBox.ShowAlertRequest(Constants.Messages.SystemName, Constants.Messages.ConfirmCancelInput) == DialogResult.OK)
                {
                    LimpiarPropiedades();
                    Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void NombreControl_TextChanged(object sender, EventArgs e)
        {
            NombreControl.Text = NombreControl.Text.Replace("  ", " ");
            NombreControl.Select(NombreControl.Text.Length, 0);
        }

        private void ValorControl_TextChanged(object sender, EventArgs e)
        {
            ValorControl.Text = ValorControl.Text.Replace("  ", " ");
            ValorControl.Select(ValorControl.Text.Length, 0);
        }

        private void ValorControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAgregar.Focus();
                BtnAgregar_Click(sender, e);
            }
        }
        #endregion

        private void FrmListaMedicion_Shown(object sender, EventArgs e)
        {
            try
            {
                LimpiarPropiedades();
                if (Model.State == EntityState.Update)
                {
                    CIDWait.Show(async () =>
                    {
                        await Model.GetListaMedicion();
                    }, "Espere");
                }
                IniciarBinding();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmDireccionesCliente ~ FrmListaMedicion_Shown(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
    }
}
