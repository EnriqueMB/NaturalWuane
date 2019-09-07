using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using FluentValidation.Results;
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
    public partial class FrmAgregarPregunta : Form
    {
        int opcion;
        string Pregunta;
        public EncuestasViewModel Model { get; set; }
        public List<Preguntas> ListaPreguntas;
        public List<Respuestas> ListaRespuesta;

        public FrmAgregarPregunta(int _opcion,string _pregunta)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<EncuestasViewModel>();
            opcion = _opcion;
            Pregunta = _pregunta;
            ListaPreguntas = new List<Preguntas>();
            ListaRespuesta = new List<Respuestas>();
        }

        #region Eventos
        private void TxtPreguntas_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var x = this.PreguntaControl.SelectionStart;
                this.PreguntaControl.Text = this.PreguntaControl.Text.ToUpper();
                this.PreguntaControl.Text = this.PreguntaControl.Text.Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "U").Replace("´", "").Replace("  ", " ");
                this.PreguntaControl.SelectionStart = x;
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
                PreguntaControl.DataBindings.Add("Text", Model, "Pregunta", true, DataSourceUpdateMode.OnPropertyChanged);             
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, ex.Message.ToString(), TypeMessage.error);
            }
        }
        #endregion

        private void BtnGuardarPregunta_Click(object sender, EventArgs e)
        {
            try
            {
                if(opcion == 1)
                {
                    if (!string.IsNullOrEmpty(Model.Pregunta))
                    {
                        LLenarListaPreguntas(CargarDatos());
                        this.Close();
                    }
                    else
                    {
                        errorProvider1.SetError(PreguntaControl, "EL CAMPO PREGUNTA NO DEBE ESTAR VACIO.");
                    }
                }
                else if(opcion == 2)
                {
                    if (!string.IsNullOrEmpty(Model.Pregunta))
                    {
                        LLenarListaRespuestas(CargarDatosR());
                        this.Close();
                    }
                    else
                    {
                        errorProvider1.SetError(PreguntaControl, "EL CAMPO RESPUESTA NO DEBE ESTAR VACIO.");
                    }
                }
                
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmAgregarPregunta ~ BtnGuardarPregunta_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private Preguntas CargarDatos()
        {
            try
            {
                Preguntas dato = new Preguntas();
                dato.Pregunta = PreguntaControl.Text;
                //dato.Checked = check.Checked;
                return dato;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Respuestas CargarDatosR()
        {
            try
            {
                Respuestas dato = new Respuestas();
                dato.Respuesta = PreguntaControl.Text;
                dato.pregunta = Pregunta;
                return dato;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LLenarListaPreguntas(Preguntas value)
        {
            try
            {
                ListaPreguntas.Add(value);
          
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LLenarListaRespuestas(Respuestas value)
        {
            try
            {
                ListaRespuesta.Add(value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FrmAgregarPregunta_Load(object sender, EventArgs e)
        {
            IniciarBinding();
            if (opcion == 2)
            {
                lblTitulo.Text = "RESPUESTAS:";
                lblPregunta.Text = Pregunta;
            }
        }

        private void PreguntaControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    this.BtnGuardarPregunta_Click(sender, e);
                }
            }
            catch (Exception ex)
            {              
                CIDMessageBox.ShowAlert(Messages.SystemName, ex.Message.ToString(), TypeMessage.error);
            }
        }
    }
}
