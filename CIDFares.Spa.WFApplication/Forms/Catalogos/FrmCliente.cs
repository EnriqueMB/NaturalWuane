using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.Business.ValueObjects;
using System.IO;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmCliente: Form
    {
        #region Propiedades Públicas
        public ClienteViewModel Model { get; set; }
        #endregion
        #region Propiedades Privadas
        private class Sexo
        {
            public string Nombre { get; set; }
            public char Id { get; set; }
            public Sexo(string N, char I)
            {
                Nombre = N;
                Id = I;
            }
        }
        #endregion
        #region Constructor
        public FrmCliente()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ClienteViewModel>();
            groupBoxCliente.Enabled = false;
            ClaveControl.Visible = false;
        }
        #endregion

        #region Metodos generales
        private void IniciarBinding()
        {
            try
            {
                NombreCompletoControl.DataBindings.Add("Text", Model, "NombreCompleto", true, DataSourceUpdateMode.OnPropertyChanged);
                RfcControl.DataBindings.Add("Text", Model, "Rfc", true, DataSourceUpdateMode.OnPropertyChanged);
                TelefonoControl.DataBindings.Add("Text", Model, "Telefono", true, DataSourceUpdateMode.OnPropertyChanged);
                FechaNachimientoControl.DataBindings.Add("Text", Model, "FechaNacimiento", true, DataSourceUpdateMode.OnPropertyChanged);
                ClaveControl.DataBindings.Add("Text", Model, "Clave", true, DataSourceUpdateMode.OnPropertyChanged);
                FotoControl.DataBindings.Add("Image", Model, "Foto", true, DataSourceUpdateMode.OnPropertyChanged);
                SexoControl.DataBindings.Add("SelectedValue", Model, "Sexo", true, DataSourceUpdateMode.OnPropertyChanged);
                this.sfDataGridCliente.AutoGenerateColumns = false;
                sfDataGridCliente.DataBindings.Add("DataSource", Model, "ListaCliente", true, DataSourceUpdateMode.OnPropertyChanged);
                this.InicializarCombo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InicializarCombo()
        {
            try
            {
                List<Sexo> ListaSexo = new List<Sexo>();
                ListaSexo.Add(new Sexo("SELECCIONE", 'S'));
                ListaSexo.Add(new Sexo("MASCULINO", 'M'));
                ListaSexo.Add(new Sexo("FEMENINO", 'F'));

                SexoControl.DataSource = ListaSexo;

                SexoControl.DisplayMember = "Nombre";
                SexoControl.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void LimpiarPropiedades()
        {
            Model.NombreCompleto = string.Empty;
            Model.Direccion = string.Empty;
            Model.Clave = string.Empty;
            Model.Sexo = 'S';
            Model.FechaNacimiento = DateTime.Now;
            Model.Telefono = string.Empty;
            Model.Rfc = string.Empty;
        }

        private Cliente ObtenerSeleccionado()
        {
            try
            {
                if (sfDataGridCliente.SelectedItems.Count == 1)
                {
                    return (Cliente)sfDataGridCliente.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private async void FrmCliente_Load(object sender, EventArgs e)
        {
            try
            {
                await Model.GetAll();
                IniciarBinding();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCliente ~ FrmCliente_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxCliente.Enabled = true;
                ClaveControl.Visible = false;
                LimpiarPropiedades();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCliente ~ btnNuevo_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            var item = ObtenerSeleccionado();
            if (item != null)
            {
                groupBoxCliente.Enabled = true;
                ClaveControl.Visible = true;
                Model.State = EntityState.Update;
                Model.IdCliente = item.IdCliente;
                Model.NombreCompleto = item.NombreCompleto;
                Model.Rfc = item.Rfc;
                Model.Sexo = item.Sexo;
                Model.Telefono = item.Telefono;
                Model.Direccion = item.Direccion;
                Model.Clave = item.Clave;
                await Model.GetFoto(Model.IdCliente);
            }
            else
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.error);
                groupBoxCliente.Enabled = false;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var Resultado = await Model.GuardarCambios();
                if (Resultado.Resultado == 1)
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.error);
                    LimpiarPropiedades();
                    groupBoxCliente.Enabled = false;
                    await Model.GetAll();

                }
                else if (Resultado.Resultado == 5)
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorClaveExistente, TypeMessage.error);
                    LimpiarPropiedades();
                    groupBoxCliente.Enabled = false;
                }
                else
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                    LimpiarPropiedades();
                    groupBoxCliente.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCliente ~ btnGuardar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog BuscarImagen = new OpenFileDialog();
                BuscarImagen.Filter = "Image Files|*.png;*.jpg;*.bmp";
                BuscarImagen.FileName = "";
                BuscarImagen.Title = "Seleccione una imagen";
                BuscarImagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures).ToString();
                if (BuscarImagen.ShowDialog() == DialogResult.OK)
                {
                    //Model.PDatos.UpdateFoto = true;
                    //Model.PDatos.ImageLocation = BuscarImagen.FileName;
                    //Model.PDatos.Extencion = Path.GetExtension(BuscarImagen.FileName);
                    //if (Model.PDatos.Extencion == ".png")
                    //    Model.PDatos.Formato = ImageFormat.Png;
                    //else if (Model.PDatos.Extencion == ".jpg")
                    //    Model.PDatos.Formato = ImageFormat.Jpeg;
                    //else if (Model.PDatos.Extencion == ".bmp")
                    //    Model.PDatos.Formato = ImageFormat.Bmp;
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPersonal ~ BtnSeleccionar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
    }
}
