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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    public partial class FrmAgregarPregunta : Form
    {
        #region Propiedades
        public EncuestasViewModel Model { get; set; }
        public BindingList<Preguntas> ListaPreguntas;
        //public List<Respuestas> ListaRespuesta;
        private List<Preguntas> list;
        private List<Preguntas> PreguntasEncuesta = new List<Preguntas>();
        #endregion

        #region Constructor   
        public FrmAgregarPregunta(List<Preguntas> _Preguntax)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<EncuestasViewModel>();
            ListaPreguntas = new BindingList<Preguntas>();
            //ListaRespuesta = new List<Respuestas>();
            list = _Preguntax;
        }
        #endregion

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
        private void FrmAgregarPregunta_Load(object sender, EventArgs e)
        {
            IniciarBinding();
            Height = 366;           
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

        private void CheckDepende_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDepende.Checked)
            {       
                Height = 497;                
                IniciarComboTE();
                lblTitulo.Visible = true;
                cmbPreguntas.Visible = true;               
            }
            else
            {               
                Height = 385;
                lblTitulo.Visible = false;
                cmbPreguntas.Visible = false;
            }
        }
        private void BtnGuardarPregunta_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmAgregarPregunta ~ BtnGuardarPregunta_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
        #endregion

        #region Metodos
        private void IniciarBinding()
        {
            try
            {
                PreguntaControl.DataBindings.Add("Text", Model, "Pregunta", true, DataSourceUpdateMode.OnPropertyChanged);

                //cmbPreguntas.DataBindings.Add("SelectedValue", Model, "IdPregunta", true, DataSourceUpdateMode.OnPropertyChanged);
                //cmbPreguntas.DataBindings.Add("DataSource", Model, "", true, DataSourceUpdateMode.OnPropertyChanged);
                //IniciarComboTE();
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, ex.Message.ToString(), TypeMessage.error);
            }
        }
        private void IniciarComboTE()
        {
            try
            {
                this.cmbPreguntas.DataSource = list;                
                cmbPreguntas.DisplayMember = "Pregunta";
                cmbPreguntas.ValueMember = "IdPregunta";
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, ex.Message.ToString(), TypeMessage.error);
            }
        }

        private Preguntas CargarDatos()
        {
            try
            {
                Preguntas Paux = ObtenerItemSeleccionado();

                Preguntas dato = new Preguntas();
                dato.IdPregunta = Guid.NewGuid();
                dato.Pregunta = PreguntaControl.Text;
                if (rbAbierta.Checked)
                {
                    dato.TipoPregunta = "ABIERTA";
                }
                else if (rbSiNo.Checked)
                {
                    dato.TipoPregunta = "SI/NO";
                }
                else if (rbMultiple.Checked)
                {
                    dato.TipoPregunta = "MULTIPLE";
                }
                if (checkDepende.Checked)
                {
                    dato.IdPreguntaDepende = Paux.IdPregunta.ToString();
                    dato.DependePregunta = Paux.Pregunta;
                }
                
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

        private Preguntas ObtenerItemSeleccionado()
        {
            try
            {
                Preguntas DatosAux = new Preguntas();
                if (this.cmbPreguntas.SelectedIndex != -1)
                {
                    DatosAux = (Preguntas)this.cmbPreguntas.SelectedItem;
                }
                return DatosAux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
