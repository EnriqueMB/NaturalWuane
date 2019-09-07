using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    public partial class FrmNuevaEncuesta : Form
    {
        #region Propiedades
        public EncuestasViewModel Model { get; set; }
        private List<Preguntas> PreguntasEncuesta = new List<Preguntas>();
        private List<Respuestas> RespuestasEncuesta = new List<Respuestas>();
        #endregion
        public FrmNuevaEncuesta()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<EncuestasViewModel>();            
        }

        #region Eventos
        private async void FrmNuevaEncuesta_Load(object sender, EventArgs e)
        {
            try
            {           
                await Model.InitComboTipoEncuesta();
                IniciarBinding();
                this.dtgPreguntas.Columns["Checked"].AllowEditing = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void NombreControl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var x = this.NombreEncuestaControl.SelectionStart;
                this.NombreEncuestaControl.Text = this.NombreEncuestaControl.Text.ToUpper();
                this.NombreEncuestaControl.Text = this.NombreEncuestaControl.Text.Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "U").Replace("´", "").Replace("  ", " ");
                this.NombreEncuestaControl.SelectionStart = x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Metodos
        private void IniciarBinding()
        {
            try
            {
                NombreEncuestaControl.DataBindings.Add("Text",Model, "NombreEncuesta",true,DataSourceUpdateMode.OnPropertyChanged);

                IdTipoEncuestaControl.DataBindings.Add("SelectedValue", Model, "IdTipoEncuesta", true, DataSourceUpdateMode.OnPropertyChanged);
                IdTipoEncuestaControl.DataBindings.Add("DataSource", Model, "_ListaTipoEncuesta", true, DataSourceUpdateMode.OnPropertyChanged);
                IniciarComboTE();

            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName,ex.Message.ToString(), TypeMessage.error);
            }
        }

        private void IniciarComboTE()
        {
            try
            {
                IdTipoEncuestaControl.DisplayMember = "Descripcion";
                IdTipoEncuestaControl.ValueMember = "IdTipoEncuesta";
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, ex.Message.ToString(), TypeMessage.error);
            }
        }
        #endregion

        private void BtnCancelarEncuesta_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarGridPreguntas()
        {
            try
            {                
                BindingSource Source = new BindingSource();
                Source.DataSource = this.PreguntasEncuesta;
                this.dtgPreguntas.AutoGenerateColumns = false;
                this.dtgPreguntas.DataSource = Source;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        private void CargarGridRespuesta()
        {
            try
            {
                BindingSource SourceR = new BindingSource();
                SourceR.DataSource = this.RespuestasEncuesta;
                this.dtgRespuestas.AutoGenerateColumns = false;
                this.dtgRespuestas.DataSource = SourceR;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnAgregarPregunta_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAgregarPregunta _Pregunta = new FrmAgregarPregunta(1,"");
                _Pregunta.ShowDialog();
                _Pregunta.Dispose();
       
                var x = _Pregunta.ListaPreguntas;
                foreach (var item in x)
                {
                    this.PreguntasEncuesta.Add(item);


                }
                CargarGridPreguntas();

            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, ex.Message.ToString(), TypeMessage.error);
            }
        }

        private void BtnNuevaEncuesta_Click(object sender, EventArgs e)
        {
            try
            {            
                this.CleanErrors(errorProvider1, typeof(EncuestasViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();

                if (validationResults.IsValid)
                {
                  
                }
                else
                {
                    this.ShowErrors(errorProvider1, typeof(EncuestasViewModel), validationResults);
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmNuevaEncuesta ~ BtnNuevaEncuesta_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);

            }
        }

        private void BtnEliminarPregunta_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {                    
                    this.PreguntasEncuesta.Remove(item);
                    this.CargarGridPreguntas();
                }
                else
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);                   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Preguntas ObtenerSeleccionado()
        {
            try
            {
                if (dtgPreguntas.SelectedItems.Count == 1)
                {
                    return (Preguntas)dtgPreguntas.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Respuestas Seleccionado()
        {
            try
            {
                if (dtgRespuestas.SelectedItems.Count == 1)
                {
                    return (Respuestas)dtgRespuestas.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnEliminarRespuesta_Click(object sender, EventArgs e)
        {
            try
            {
                var item = Seleccionado();
                if (item != null)
                {
                    this.RespuestasEncuesta.Remove(item);
                    this.CargarGridPreguntas();
                }
                else
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnAgregarRespuesta_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    if (item.Checked)
                    {
                        FrmAgregarPregunta _Resp = new FrmAgregarPregunta(2,item.Pregunta);
                        _Resp.ShowDialog();
                        _Resp.Dispose();
                     
                        var x = _Resp.ListaRespuesta;
                        foreach (var value in x)
                        {
                            this.RespuestasEncuesta.Add(value);                                                                          
                        }
                        CargarGridRespuesta();
                    }
                    else
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName,"LA PREGUNTA SELECCIONADA ES DE RESPUESTA ABIERTA", TypeMessage.informacion);
                    }
                }
                else
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName,"DEBE SELECCIONAR UNA FILA DEL GRID DE PREGUNTAS", TypeMessage.informacion);
                }
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName,ex.Message.ToString(), TypeMessage.error);
            }
        }
    }
}
