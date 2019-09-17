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
    public partial class FrmAgregarRespuesta : Form
    {
        #region Propiedades
        private Preguntas item;
        public EncuestasViewModel Model { get; set; }
        //public List<Respuestas> ListaRespuesta = new List<Respuestas>();
        #endregion

        #region Constructor
        public FrmAgregarRespuesta(Preguntas _item)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<EncuestasViewModel>();
            item = _item;
        }
        #endregion      

        #region Eventos
        private void BtnGuardarRespuesta_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnGuardarRespuesta.Enabled = false;

                if (!string.IsNullOrEmpty(Model.Respuesta))
                {
                    //LLenarListaRespuestas(CargarDatosR());
                    CargarDatosR();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    errorProvider1.SetError(RespuestaControl, "EL CAMPO RESPUESTA NO DEBE ESTAR VACIO.");
                }
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, ex.Message.ToString(), TypeMessage.error);
            }
            finally
            {
                this.btnGuardarRespuesta.Enabled = true;
            }
        }
        private void FrmAgregarRespuesta_Load(object sender, EventArgs e)
        {
            IniciarBinding();
            lblPregunta.Visible = true;
            lblPregunta.Text = item.Pregunta;
        }
        private void RespuestaControl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var x = this.RespuestaControl.SelectionStart;
                this.RespuestaControl.Text = this.RespuestaControl.Text.ToUpper();
                //this.RespuestaControl.Text = this.RespuestaControl.Text.Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "U").Replace("´", "").Replace("  ", " ");
                this.RespuestaControl.SelectionStart = x;
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, ex.Message.ToString(), TypeMessage.error);
            }
        }
        private void RespuestaControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    this.BtnGuardarRespuesta_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Metodos
        public Respuestas CargarDatosR()
        {
            try
            {
                Respuestas dato = new Respuestas();
                dato.Respuesta = RespuestaControl.Text;
                dato.pregunta = item.Pregunta;
                dato.IdPregunta = item.IdPregunta;
                dato.IdRespuesta = Guid.NewGuid();         
                //item.Respuesta.Add(dato);
                return dato;
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
                RespuestaControl.DataBindings.Add("Text", Model, "Respuesta", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, ex.Message.ToString(), TypeMessage.error);
            }
        }
        #endregion  
    }
}
