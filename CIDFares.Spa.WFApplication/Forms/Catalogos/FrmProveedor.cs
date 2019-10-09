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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmProveedor : Form
    {

        #region Propiedades Publicas

        private Proveedor Datos { get; set; }
        public ProveedorViewModel Model { get; set; }

        #endregion
        public FrmProveedor()
        { 
            try
            {
                InitializeComponent();
                lblSubtitle.Text = "NUEVO REGISTRO";
                Model = ServiceLocator.Instance.Resolve<ProveedorViewModel>();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        
        public  FrmProveedor(Guid IdProveedor)
        {
            InitializeComponent();
            lblSubtitle.Text = "MODIFICAR REGISTRO";
            Model = ServiceLocator.Instance.Resolve<ProveedorViewModel>();
            Model.IdProveedor = IdProveedor;
            Model.State = EntityState.Update;
            
        }

        #region Metodos
        private void IniciarBinding()
        {
            try
            {
                ClaveControl.DataBindings.Add("Text", Model, "Clave", true, DataSourceUpdateMode.OnPropertyChanged);
                NombreComercialControl.DataBindings.Add("Text", Model, "NombreComercial", true, DataSourceUpdateMode.OnPropertyChanged);
                RazonSocialControl.DataBindings.Add("Text", Model, "RazonSocial", true, DataSourceUpdateMode.OnPropertyChanged);
                RepresentanteControl.DataBindings.Add("Text", Model, "Representante", true, DataSourceUpdateMode.OnPropertyChanged);
                RFCControl.DataBindings.Add("Text", Model, "RFC", true, DataSourceUpdateMode.OnPropertyChanged);
                DireccionControl.DataBindings.Add("Text", Model, "Direccion", true, DataSourceUpdateMode.OnPropertyChanged);
                TelefonoControl.DataBindings.Add("Text", Model, "Telefono", true, DataSourceUpdateMode.OnPropertyChanged);
                CorreoElectronicoControl.DataBindings.Add("Text", Model, "CorreoElectronico", true, DataSourceUpdateMode.OnPropertyChanged);
                CodigoPostalControl.DataBindings.Add("Text", Model, "CodigoPostal", true, DataSourceUpdateMode.OnPropertyChanged);

                IniciarComboPais();
                IdPaisControl.DataBindings.Add("DataSource", Model, "ListaPais", true, DataSourceUpdateMode.OnPropertyChanged);
                IdPaisControl.DataBindings.Add("SelectedValue", Model, "IdPais", true, DataSourceUpdateMode.OnPropertyChanged);
                
                IniciarComboEstado();
                IdEstadoControl.DataBindings.Add("DataSource", Model, "ListaEstado", true, DataSourceUpdateMode.OnPropertyChanged);
                IdEstadoControl.DataBindings.Add("SelectedValue", Model, "IdEstado", true, DataSourceUpdateMode.OnPropertyChanged);
               

                IniciarComboMunicipio();
                IdMunicipioControl.DataBindings.Add("DataSource", Model, "ListaMunicipio", true, DataSourceUpdateMode.OnPropertyChanged);
                IdMunicipioControl.DataBindings.Add("SelectedValue", Model, "IdMunicipio", true, DataSourceUpdateMode.OnPropertyChanged);
               
               


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void IniciarComboPais()
        {
            try
            {
                IdPaisControl.DisplayMember = "Descripcion";
                IdPaisControl.ValueMember = "IdPais";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarComboEstado()
        {
            try
            {
                IdEstadoControl.DisplayMember = "Descripcion";
                IdEstadoControl.ValueMember = "IdEstado";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarComboMunicipio()
        {
            try
            {
                IdMunicipioControl.DisplayMember = "Descripcion";
                IdMunicipioControl.ValueMember = "IdMunicipio";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LimpiarPropiedades()
        {
          
            Model.Clave = string.Empty;
            Model.NombreComercial = string.Empty;
            Model.RazonSocial = string.Empty;
            Model.Representante = string.Empty;
            Model.RFC = string.Empty;
            Model.Direccion = string.Empty;
            Model.Telefono = string.Empty;
            Model.CorreoElectronico = string.Empty;
            Model.CodigoPostal = string.Empty;
            Model.IdPais = 0;
            Model.IdEstado = 0;
            Model.IdMunicipio = 0;

        }

        private string ObtenerMensajeError(int Error)
        {
            try
            {
                string ErrorMessage = Messages.ErrorMessage;
                switch (Error)
                {
                    case -1:
                        ErrorMessage = "EL PROVEEDOR YA SE ENCUENTRA REGISTRADO";
                        break;
                    case -2:
                        ErrorMessage = "DESCONOCIDO";
                        break;
                }
                return ErrorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void CargarDatos()
        {
            try
            {
                Model.IdProveedor= Datos.IdProveedor;
                Model.Clave = Datos.Clave;
                Model.NombreComercial = Datos.NombreComercial;
                Model.RazonSocial = Datos.RazonSocial;
                Model.Representante = Datos.Representante;
                Model.RFC = Datos.RFC;
                Model.Direccion = Datos.Direccion;
                Model.Telefono = Datos.Telefono;
                Model.CorreoElectronico = Datos.CorreoElectronico;
                Model.CodigoPostal = Datos.CodigoPostal;
                Model.IdPais = Datos.IdPais;
                Model.Pais = Datos.Pais;
                Model.IdEstado = Datos.IdEstado;
                Model.Estado = Datos.Estado;
                Model.IdMunicipio = Datos.IdMunicipio;
                Model.Municipio = Datos.Municipio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        #endregion
        private void FrmProveedor_Shown(object sender, EventArgs e)
        {
            try
            {
                LimpiarPropiedades();
                if (Model.State == EntityState.Update)
                {
                    CIDWait.Show(async () => {
                        await Model.CargarDatos();
                    }, "Espere");

                }
                else
                {
                    Model.IdPais = 143;
                    Model.IdEstado = 7;
                   
                }

                CIDWait.Show(async () =>
                {
                    var _ListaPais = await Model.GetListaPais();
                    Model.GetListaPais(_ListaPais);


                    
                    var _ListaEstado = await Model.GetListaEstado();
                    Model.GetListaEstado(_ListaEstado);
                   

                    var _ListaMunicipio = await Model.GetListaMunicipio();
                    Model.GetListaMunicipio(_ListaMunicipio);
                 
                    await Task.Delay(2000);
                }, "Espere");

                IniciarBinding();

            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmProveedor ~ FrmProveedor_Shown(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardar.Enabled = false;
                this.CleanErrors(errorProviderProveedor, typeof(ProveedorViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();
                if (validationResults.IsValid)
                {
                    Proveedor Resultado = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario);
                    if (Resultado.Resultado == 1)
                    {

                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);

                        LimpiarPropiedades();
                        await Model.GetAll();
                        this.Close();
                        btnGuardar.Enabled = false;
                        FrmProveedorGrid proveedor = new FrmProveedorGrid();

                    }
                    else
                        CIDMessageBox.ShowAlert(Messages.ErrorMessage, ObtenerMensajeError(Resultado.Resultado), TypeMessage.error);
                    }
                    else
                        this.ShowErrors(errorProviderProveedor, typeof(ProveedorViewModel), validationResults);
                }
            
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmProveedor ~ btnGuardar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmOutMessage) == DialogResult.OK)
                    this.Close();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmProveedor ~ btnCancelar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        
       

        private async void IdPaisControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IdPaisControl.DataBindings["SelectedValue"] != null)
            {
                IdPaisControl.DataBindings["SelectedValue"].WriteValue();
                var _ListaEstado = await Model.GetListaEstado();
                Model.GetListaEstado(_ListaEstado);
                IdEstadoControl.SelectedValue = 0;
            }
            
        }
       
        private async void IdEstadoControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (IdEstadoControl.DataBindings["SelectedValue"] != null)
                {
                    IdEstadoControl.DataBindings["SelectedValue"].WriteValue();
                    var _ListaMunicipio = await Model.GetListaMunicipio();
                    Model.GetListaMunicipio(_ListaMunicipio);
                    IdMunicipioControl.SelectedValue = 0;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void TelefonoControl_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ClaveControl_TextChanged(object sender, EventArgs e)
        {
            ClaveControl.Text = ClaveControl.Text.Replace("  ", " ");
            ClaveControl.Select(ClaveControl.Text.Length, 0);
        }

        private void NombreComercialControl_TextChanged(object sender, EventArgs e)
        {
            NombreComercialControl.Text = NombreComercialControl.Text.Replace("  ", " ");
            NombreComercialControl.Select(NombreComercialControl.Text.Length, 0);
        }

        private void RazonSocialControl_TextChanged(object sender, EventArgs e)
        {
            RazonSocialControl.Text = RazonSocialControl.Text.Replace("  ", " ");
            RazonSocialControl.Select(RazonSocialControl.Text.Length, 0);
        }

        private void RepresentanteControl_TextChanged(object sender, EventArgs e)
        {
            RepresentanteControl.Text = RepresentanteControl.Text.Replace("  ", " ");
            RepresentanteControl.Select(RepresentanteControl.Text.Length, 0);
        }

        private void RFCControl_TextChanged(object sender, EventArgs e)
        {
            RFCControl.Text = RFCControl.Text.Replace("  ", " ");
            RFCControl.Select(RFCControl.Text.Length, 0);
            RFCControl.Text = RFCControl.Text.ToUpper();
        }

        private void DireccionControl_TextChanged(object sender, EventArgs e)
        {
            DireccionControl.Text = DireccionControl.Text.Replace("  ", " ");
            DireccionControl.Select(DireccionControl.Text.Length, 0);
        }
    }
}
