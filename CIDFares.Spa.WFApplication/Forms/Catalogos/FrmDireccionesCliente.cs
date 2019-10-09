using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Library.Controls.CIDWait.Code;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.DTOs.Requests;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmDireccionesCliente : Form
    {
        #region Propiedades publicas 
        public DireccionesClienteViewModel Model { get; set; }
        public List<DireccionesClienteRequest> ListaDirecciones { get; set; }
        #endregion
        public FrmDireccionesCliente(Guid IdCliente, string nombre, List<DireccionesClienteRequest> lista)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<DireccionesClienteViewModel>();
            Model.IdCliente = Guid.Empty;
            ListaDirecciones = new List<DireccionesClienteRequest>();
            Model.IdCliente = IdCliente;
            Model.CargarLista(lista);
        }

        #region Metodos 
        private void LimpiarPropiedades()
        {
            Model.IdDireccion = Guid.Empty;
            Model.IdEstado = 0;
            Model.IdMunicipio = 0;
            Model.Calle = string.Empty;
            Model.EntreCalles = string.Empty;
            Model.Colonia = string.Empty;
            Model.CodigoPostal = string.Empty;
            Model.Contacto = string.Empty;
            Model.TelefonoContacto = string.Empty;
            Model.NumeroExterior = 0;
            Model.NumeroExterior = 0;
        }
        private void IniciarCombos()
        {
            try
            {
                IdEstadoControl.DisplayMember = "Descripcion";
                IdEstadoControl.ValueMember = "IdEstado";

                IdMunicipioControl.DisplayMember = "Descripcion";
                IdMunicipioControl.ValueMember = "IdMunicipio";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void IniciarBinding()
        {
            try
            {
                CalleControl.DataBindings.Add("Text", Model, "Calle", true, DataSourceUpdateMode.OnPropertyChanged);
                ColoniaControl.DataBindings.Add("Text", Model, "Colonia", true, DataSourceUpdateMode.OnPropertyChanged);
                EntreCallesControl.DataBindings.Add("Text", Model, "EntreCalles", true, DataSourceUpdateMode.OnPropertyChanged);
                ReferenciasControl.DataBindings.Add("Text", Model, "Referencias", true, DataSourceUpdateMode.OnPropertyChanged);
                CodigoPostalControl.DataBindings.Add("Text", Model, "CodigoPostal", true, DataSourceUpdateMode.OnPropertyChanged);
                NumeroInteriorControl.DataBindings.Add("Text", Model, "NumeroInterior", true, DataSourceUpdateMode.OnPropertyChanged);
                NumeroExteriorControl.DataBindings.Add("Text", Model, "NumeroExterior", true, DataSourceUpdateMode.OnPropertyChanged);
                ContactoControl.DataBindings.Add("Text", Model, "Contacto", true, DataSourceUpdateMode.OnPropertyChanged);
                TelefonoContactoControl.DataBindings.Add("Text", Model, "TelefonoContacto", true, DataSourceUpdateMode.OnPropertyChanged);
                SNInteriorControl.DataBindings.Add("Checked", Model, "SNInterior", true, DataSourceUpdateMode.OnPropertyChanged);
                SNExteriorControl.DataBindings.Add("Checked", Model, "SNExterior", true, DataSourceUpdateMode.OnPropertyChanged);

                sdgDirecciones.AutoGenerateColumns = false;
                sdgDirecciones.DataBindings.Add("DataSource", Model, "ListaDirecciones", true, DataSourceUpdateMode.OnPropertyChanged);
                IniciarCombos();
                IdEstadoControl.DataBindings.Add("DataSource", Model, "ListaEstados", true, DataSourceUpdateMode.OnPropertyChanged);
                IdEstadoControl.DataBindings.Add("SelectedValue", Model, "IdEstado", true, DataSourceUpdateMode.OnPropertyChanged);
                IdMunicipioControl.DataBindings.Add("DataSource", Model, "ListaMunicipios", true, DataSourceUpdateMode.OnPropertyChanged);
                IdMunicipioControl.DataBindings.Add("SelectedValue", Model, "IdMunicipio", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DireccionesClienteRequest ObtenerSeleccionado()
        {
            try
            {
                if (sdgDirecciones.SelectedItems.Count == 1)
                {
                    return (DireccionesClienteRequest)sdgDirecciones.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Estado ObtenerEstadoSeleccionado()
        {
            try
            {
                int estado = (int)IdEstadoControl.SelectedValue;
                if(estado != 0)
                {
                    return (Estado)IdEstadoControl.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Municipio ObtenerMunicipioSeleccionado()
        {
            try
            {
                int estado = (int)IdMunicipioControl.SelectedValue;
                if (estado != 0)
                {
                    return (Municipio)IdMunicipioControl.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        private void FrmDireccionesCliente_Shown(object sender, EventArgs e)
        {
            try
            {
                LimpiarPropiedades();
                Model.IdEstado = 7;
                CIDWait.Show(async () =>
                {
                    var ListaEstado = await Model.GetListaEstados();
                    Model.LlenarListaEstado(ListaEstado);

                    var ListaMunicipio = await Model.GetListaMunicipios();
                    Model.LlenarListaMunicipios(ListaMunicipio);

                }, "Cargando datos");
                IniciarBinding();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmCancelInput) == DialogResult.OK)
            {
                Close();
            }
                
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Model.ListaDirecciones.Count > 0)
                {
                    ListaDirecciones = Model.ListaDirecciones.ToList();
                    this.DialogResult = DialogResult.OK;
                    LimpiarPropiedades();
                    Close();
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, "AGREGUE POR LO MENOS UNA DIRECCIÓN.", TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //flpBotonesGroup.Enabled = false;
                this.CleanErrors(errorProvider1, typeof(DireccionesClienteViewModel));
                var validaciones = Model.Validate();
                if (validaciones.IsValid)
                {
                    var itemEstado = ObtenerEstadoSeleccionado();
                    var itemMunicipio = ObtenerMunicipioSeleccionado();
                    Model.NombreEstado = itemEstado.Descripcion;
                    Model.NombreMunicipio = itemMunicipio.Descripcion;
                    Model.Agregar();
                    LimpiarPropiedades();
                }
                else
                    this.ShowErrors(errorProvider1, typeof(DireccionesClienteViewModel), validaciones);
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
            finally
            {
                //flpBotonesGroup.Enabled = true;
            }
        }

        private async void IdEstadoControl_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (IdEstadoControl.DataBindings["SelectedValue"] != null)
                {
                    IdEstadoControl.DataBindings["SelectedValue"].WriteValue();
                    var ListaMunicipios = await Model.GetListaMunicipios();
                    Model.LlenarListaMunicipios(ListaMunicipios);
                    IdMunicipioControl.SelectedValue = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SNInteriorControl_CheckedChanged(object sender, EventArgs e)
        {
            NumeroInteriorControl.Enabled = !SNInteriorControl.Checked;
        }

        private void SNExteriorControl_CheckedChanged(object sender, EventArgs e)
        {
            NumeroExteriorControl.Enabled = !SNExteriorControl.Checked;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmDeleteMessage) == DialogResult.OK)
                    {
                        Model.ListaDirecciones.Remove(item);
                    }
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.error);
            }
        }

        private void CodigoPostalControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            else if (Char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void ColoniaControl_TextChanged(object sender, EventArgs e)
        {
            ColoniaControl.Text = ColoniaControl.Text.Replace("  ", " ");
            ColoniaControl.Select(ColoniaControl.Text.Length, 0);
        }

        private void CalleControl_TextChanged(object sender, EventArgs e)
        {
            CalleControl.Text = CalleControl.Text.Replace("  ", " ");
            CalleControl.Select(ColoniaControl.Text.Length, 0);
        }

        private void EntreCallesControl_TextChanged(object sender, EventArgs e)
        {
            EntreCallesControl.Text = EntreCallesControl.Text.Replace("  ", " ");
            EntreCallesControl.Select(EntreCallesControl.Text.Length, 0);
        }

        private void ContactoControl_TextChanged(object sender, EventArgs e)
        {
            ContactoControl.Text = ContactoControl.Text.Replace("  ", " ");
            ContactoControl.Select(ContactoControl.Text.Length, 0);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
            try
            {
                Model.item = ObtenerSeleccionado();
                if(Model.item != null)
                {                     
                    Model.State = EntityState.Update;
                    Model.IdEstado = Model.item.DatosEstado.IdEstado;
                    Model.IdMunicipio = Model.item.DatosMunicipio.IdMunicipio;
                    Model.Calle = Model.item.Calle;
                    Model.EntreCalles = Model.item.EntreCalles;
                    Model.Referencias = Model.item.Referencias;
                    Model.CodigoPostal = Model.item.CodigoPostal;
                    Model.NumeroInterior = Model.item.NumeroInterior;
                    Model.NumeroExterior = Model.item.NumeroExterior;
                    Model.Contacto = Model.item.Contacto;
                    Model.TelefonoContacto = Model.item.TelefonoContacto;
                    Model.Colonia = Model.item.Colonia;
                    Model.SNInterior = (Model.NumeroInterior == 0) ? true : false;
                    Model.SNExterior = (Model.NumeroExterior == 0) ? true : false;
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarPropiedades();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void TelefonoContactoControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            else if (Char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
