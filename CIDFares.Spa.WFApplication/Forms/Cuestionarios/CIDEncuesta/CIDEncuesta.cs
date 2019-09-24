using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.Business.ViewModels.Catalogos;

namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios.CIDEncuesta
{
    public partial class CIDEncuesta : UserControl
    {
        #region Propiedades       
        private int opcion;
        public Preguntas _pregunta { get; set; }
        public CIDcontrolViewModel Model { get; set; }       
        #endregion

        #region Contructor
        public CIDEncuesta(Preguntas pregunta)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<CIDcontrolViewModel>();
            Model.TipoPregunta = pregunta.TipoPregunta;
            Model.ListaOpciones = pregunta.Respuesta;
            Model.respuestasMultiples = pregunta.respuestasMultiples;
            //CIDcontrolViewModel vm = new CIDcontrolViewModel
            //{
            //    TipoPregunta = pregunta.TipoPregunta,
            //    ListaOpciones = pregunta.Respuesta,
            //    respuestasMultiples = pregunta.respuestasMultiples
            //};

            txtPregunta.Text = pregunta.Pregunta;
            _pregunta = pregunta;
            Model.IDPre = pregunta.IdPregunta;
        }
        #endregion

        #region Eventos
        private void CIDEncuesta_Load(object sender, EventArgs e)
        {
            Iniciarbinding();
            if (_pregunta.TipoPregunta == "MULTIPLE" && _pregunta.respuestasMultiples)
            {
                pnlOpcMultiple.Visible = false;
                pnlOpcSiNo.Visible = false;
                pnlOpcAbierta.Visible = false;
                pnlOpcMultipleCheck.Visible = true;
                MostarRespuestas(opcion = 2);
            }
            else if (_pregunta.TipoPregunta == "MULTIPLE")
            {
                pnlOpcMultiple.Visible = true;
                pnlOpcSiNo.Visible = false;
                pnlOpcAbierta.Visible = false;
                pnlOpcMultipleCheck.Visible = false;
                MostarRespuestas(opcion = 1);
            }
            else if (_pregunta.TipoPregunta == "ABIERTA")
            {
                pnlOpcSiNo.Visible = false;
                pnlOpcMultiple.Visible = false;
                pnlOpcAbierta.Visible = true;
                pnlOpcMultipleCheck.Visible = false;
            }
            else if (_pregunta.TipoPregunta == "SI/NO")
            {
                pnlOpcMultiple.Visible = false;
                pnlOpcSiNo.Visible = true;
                pnlOpcAbierta.Visible = false;
                pnlOpcMultipleCheck.Visible = false;
            }
        }
        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var aux = (sender as CheckBox);
            if (aux.DataBindings["Checked"] != null)
            {
                aux.DataBindings["Checked"].WriteValue();
            }
            var x = Model.ListaOpciones;
        }
        #endregion

        #region Metodos
        private void Iniciarbinding()
        {
            try
            {
                txtRespuesta.DataBindings.Add("Text", Model, "respuestas", true, DataSourceUpdateMode.OnPropertyChanged);                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void MostarRespuestas(int opcion)
        {
            try
            {
                if (opcion == 1)
                {
                    if (_pregunta.Respuesta.Count > 0)
                    {
                        CidGroupRadioButton group = new CidGroupRadioButton();
                        group.AutoSize = true;
                        group.Location = new Point(0, 0);
                        group.DataBindings.Add("SelectedValue", Model, "ValueGroupRadioButton",true,DataSourceUpdateMode.OnPropertyChanged);

                        foreach (var item in _pregunta.Respuesta)
                        {
                            CIDRadioButton _respuestas = new CIDRadioButton();
                            _respuestas.Value = item.IdRespuesta;
                            _respuestas.Text = item.Respuesta;
                            group.Controls.Add(_respuestas);
                        }

                        this.flowLayoutPanel2.Controls.Add(group);
                    }
                }
                else if (opcion == 2)
                {
                    if (_pregunta.Respuesta.Count > 0)
                    {

                        //FlowLayoutPanel panelCheck = new FlowLayoutPanel();

                        var value = Model.ListaOpciones.OrderByDescending(x => x.IdRespuesta).ToList();
                        foreach (var item in value)
                        {
                            CheckBox _respuestas = new CheckBox();
                            _respuestas.Text = item.Respuesta;
                            //_respuestas.DataBindings.Add("Checked", item, "Seleccionado");
                            _respuestas.DataBindings.Add("Checked", item, "Seleccionado", true,DataSourceUpdateMode.OnPropertyChanged);                            
                            _respuestas.CheckedChanged += radioButton_CheckedChanged;
                            this.flowLayoutPanel3.Controls.Add(_respuestas);
                        }
                        //this.flowLayoutPanel3.Controls.Add(panelCheck);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}

