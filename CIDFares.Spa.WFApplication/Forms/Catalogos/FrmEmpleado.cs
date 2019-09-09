using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
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
    public partial class FrmEmpleado : Form
    {
        #region Propiedades Publicas


        public EmpleadoViewModel Model { get; set; }

        #endregion
        #region Sexo Combo

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

        public FrmEmpleado()
        {
            InitializeComponent();
           // lblSubtitle.Text = "NUEVO REGISTRO";
            Model = ServiceLocator.Instance.Resolve<EmpleadoViewModel>();
          //  Model.GetListaCataegoriaProduto();



        }

        public FrmEmpleado(Guid IdEmpleado)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<EmpleadoViewModel>();
            //LimpiarPropiedades();
         //   Model.IdProducto = IdProducto;
            Model.State = EntityState.Update;
        }
        #endregion
        #region BOTONES
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.CleanErrors(errorProvider1, typeof(EmpleadoViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();
                if (validationResults.IsValid)
                {
                    var Resultado = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario);
                    if (Resultado.Resultado == 1)
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                        LimpiarPropiedades();
                       
                       

                    }
                    else
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                        LimpiarPropiedades();
                       
                    }
                }
                else
                    this.ShowErrors(errorProvider1, typeof(EmpleadoViewModel), validationResults);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmEmpleado ~ btnGuardar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
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
                    Model.UpdateFoto = true;
                    Model.ImageLocation = BuscarImagen.FileName;
                    var x = Model.Foto.VaryQualityLevel(35L);
                    // Bitmap bit = new Bitmap((Image)x.Clone());
                    Model.Foto = x;
                    Model.FotoBase64 = ((Image)x.Clone()).ToBase64String(x.RawFormat);
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmEmpleado ~ BtnSeleccionar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        #endregion

        #region Metodos
        public void IniciarBinding()
        {
            try
            {
                NombreControl.DataBindings.Add("Text", Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
                ApellidoPatControl.DataBindings.Add("Text", Model, "ApellidoPat", true, DataSourceUpdateMode.OnPropertyChanged);
                ApellidoMatControl.DataBindings.Add("Text", Model, "ApellidoMat", true, DataSourceUpdateMode.OnPropertyChanged);
                FechaNacimientoControl.DataBindings.Add("Text", Model, "FechaNacimiento", true, DataSourceUpdateMode.OnPropertyChanged);
                SexoControl.DataBindings.Add("SelectedValue", Model, "Sexo", true, DataSourceUpdateMode.OnPropertyChanged);
                TelefonoControl.DataBindings.Add("Text", Model, "Telefono", true, DataSourceUpdateMode.OnPropertyChanged);
                CorreoControl.DataBindings.Add("Text", Model, "Correo", true, DataSourceUpdateMode.OnPropertyChanged);
                ContraseñaControl.DataBindings.Add("Text", Model, "Contraseña", true, DataSourceUpdateMode.OnPropertyChanged);
                DireccionControl.DataBindings.Add("Text", Model, "Direccion", true, DataSourceUpdateMode.OnPropertyChanged);
                ClaveControl.DataBindings.Add("Text", Model, "Clave", true, DataSourceUpdateMode.OnPropertyChanged);
                FotoControl.DataBindings.Add("Image", Model, "Foto", true, DataSourceUpdateMode.OnPropertyChanged);
                RutaControl.DataBindings.Add("Text", Model, "ImageLocation", true, DataSourceUpdateMode.OnPropertyChanged);

                IniciarCombos(1);
                IdTurnoControl.DataBindings.Add("SelectedValue", Model, "IdTurno", true, DataSourceUpdateMode.OnPropertyChanged);
                IdTurnoControl.DataBindings.Add("DataSource", Model, "ListaTurno", true, DataSourceUpdateMode.OnPropertyChanged);

                IniciarCombos(2);
                IdPuestoControl.DataBindings.Add("SelectedValue", Model, "IdPuesto", true, DataSourceUpdateMode.OnPropertyChanged);
                IdPuestoControl.DataBindings.Add("DataSource", Model, "ListaPuesto", true, DataSourceUpdateMode.OnPropertyChanged);




            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarCombos(int tipo)
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

                if (tipo == 1)
                {
                    IdTurnoControl.DisplayMember = "NombreTurno";
                    IdTurnoControl.ValueMember = "IdTurno";
                }

                else if (tipo == 2)
                {
                    IdPuestoControl.DisplayMember = "NombrePuesto";
                    IdPuestoControl.ValueMember = "IdPuesto";
                }
               

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void LimpiarPropiedades()
        {
            Model.Nombre = string.Empty;
            Model.ApellidoPat = string.Empty;
            Model.ApellidoMat = string.Empty;
            Model.FechaNacimiento = DateTime.Now;
            Model.Sexo = 'S';
            Model.Telefono = string.Empty;
            Model.Correo = string.Empty;
            Model.IdTurno = 0;
            Model.IdPuesto = 0;
            Model.Contraseña = string.Empty;
            Model.Direccion = string.Empty;
            Model.Clave = string.Empty;
          
            Model.FotoBase64 = string.Empty;
        }

        #endregion

        private async void FrmEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                var x = await Model.GetListaTurno();
                Model.LlenaTurno(x);

                var y = await Model.GetListaPuesto();
                Model.LlenaPuesta(y);

                IniciarBinding();
                Model.Foto = Properties.Resources.imagen_subir;
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmEmpleado ~ FrmEmpleado_Load(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
    }
}