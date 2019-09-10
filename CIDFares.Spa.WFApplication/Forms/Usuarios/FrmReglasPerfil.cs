using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Usuarios;
using CIDFares.Spa.CrossCutting.Services;
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

namespace CIDFares.Spa.WFApplication.Forms.Usuarios
{
    public partial class FrmReglasPerfil : Form
    {

        #region Propiedades privadas

        #endregion

        #region Propiedades públicas
        public ReglaPerfilViewModel Model { get; set; }
        #endregion
        
        #region Constructor
        public FrmReglasPerfil()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ReglaPerfilViewModel>();
            this.IniciarBinding();
            this.ListaRegla.GroupCaptionTextFormat = "{Key} - Permisos ({ItemsCount})";

        }
        #endregion

        #region Metodos
        private void IniciarBinding()
        {
            try
            {
                IdRolControl.DataBindings.Add("SelectedValue", Model, "IdRol", true, DataSourceUpdateMode.OnPropertyChanged);
                IdRolControl.DataBindings.Add("DataSource", Model, "ListaRol", true, DataSourceUpdateMode.OnPropertyChanged);
                IniciarComboPerfil();

                this.ListaRegla.AutoGenerateColumns = false;
                ListaRegla.DataBindings.Add("DataSource", Model, "ListaReglas", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void IniciarComboPerfil()
        {
            try
            {
                IdRolControl.DisplayMember = "Nombre";
                IdRolControl.ValueMember = "IdRol";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DataTable ObtenerDatosTabla(BindingList<ReglasRol> Lista)
        {
            DataTable Tabla = new DataTable();
            Tabla.Columns.Add("IdRegla", typeof(int));
            foreach (var item in Lista)
            {
                if (item.ReglaAsignada)
                {
                    Tabla.Rows.Add(new object[] { item.IdRegla });
                }
            }
            return Tabla;
        }
        #endregion

        #region Eventos
        private async void FrmReglasPerfil_Load(object sender, EventArgs e)
        {
            try
            {
                var x = await Model.ObtenerListaRol();
                Model.LlenarListaRol(x);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmReglaPerfil ~ FrmReglasPerfil_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private void IdPerfilControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.CleanErrors(errorProvider1, typeof(ReglaPerfilViewModel));
                int.TryParse(IdRolControl.SelectedValue.ToString(), out int Id);
                if (Id > 0)
                {
                    Model.LlenarListaRegla(Id);
                }
                else
                    Model.ListaReglas.Clear();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmReglaPerfil ~ IdPerfilControl_SelectedIndexChanged(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BindingList<ReglasRol> ListaReglas = (BindingList<ReglasRol>)ListaRegla.DataSource;
                Model.TablaGRegla = ObtenerDatosTabla(ListaReglas);
                this.CleanErrors(errorProvider1, typeof(ReglaPerfilViewModel));
                var validationResults = Model.Validate();
                string Validacion = validationResults.ToString();
                if (validationResults.IsValid)
                {
                    var reglasRol = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario);
                    if (reglasRol.Resultado != 0)
                    {
                        CurrentSession.ReglasUsuario = reglasRol.ReglasLogin.ReglaUsuario;
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                        this.ListaRegla.Refresh();
                        Model.LlenarListaRegla(Model.IdRol);
                    }
                    else
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                }
                else
                {

                    if (Validacion == "1")
                        errorProvider1.SetError(ErrorControl, "La lista tiene que tener al menos un registro seleccionado.");
                    else
                        this.ShowErrors(errorProvider1, typeof(ReglaPerfilViewModel), validationResults);
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmReglaRol ~ BtnGuardar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmReglaRol ~ btnCancelar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        #endregion
    }
}
