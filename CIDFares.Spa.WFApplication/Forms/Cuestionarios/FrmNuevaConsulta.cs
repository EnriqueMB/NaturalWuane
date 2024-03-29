﻿using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Forms.Catalogos;
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
    public partial class FrmNuevaConsultaControl : Form
    {
        #region propiedades
        public ConsultaViewModel Model { get; set; }
        public int IndexPregunta { get; set; }
        int IndexPreguntaDependiente = -1;
        public DataTable tablaRespuestasMultiples { get; set; }
        public DataTable tablaRespuestas { get; set; }
        #endregion

        #region constructor
        public FrmNuevaConsultaControl(List<Cuestionario> listaEncuesta)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ConsultaViewModel>();
            Model.AplicarEncuestaLista = listaEncuesta;     
            this.Tabla();
        }

        public FrmNuevaConsultaControl(List<Cuestionario> lstEncuesta, List<Respuestas> lstR, List<Respuestas> lstRM)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ConsultaViewModel>();
            Model.AplicarEncuestaLista = lstEncuesta;
            Model._ListaRespuestasEncuesta = lstR;
            Model._listRespuestasMultiples = lstRM;
            this.Tabla();

        }
        #endregion

        #region Eventos
        private void FrmNuevaConsultaControl_Load(object sender, EventArgs e)
        {
            Iniciarbinding();   
        }
        private void BtnCancelarConsulta_Click(object sender, EventArgs e)
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
        #endregion

        #region Metodos
        private void Iniciarbinding()
        {
            try
            {                  
                cmbEncuestas.DataBindings.Add("SelectedItem", Model, "cuestionario", true, DataSourceUpdateMode.OnPropertyChanged);
                cmbEncuestas.DataBindings.Add("DataSource", Model, "AplicarEncuestaLista", true, DataSourceUpdateMode.OnPropertyChanged);
                IniciarComboEncuestas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }              
        private void IniciarComboEncuestas()
        {
            try
            {   
                this.cmbEncuestas.DataSource = Model.AplicarEncuestaLista;
                cmbEncuestas.DisplayMember = "NombreEncuesta";
                cmbEncuestas.ValueMember = "IdEncuesta";
                cmbEncuestas.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, ex.Message.ToString(), TypeMessage.error);
            }
        }
        #endregion
 
        private async void CmbEncuestas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var x = cmbEncuestas.SelectedValue;
            
            if(cmbEncuestas.DataBindings["SelectedItem"] != null)
            {
                cmbEncuestas.DataBindings["SelectedItem"].WriteValue();
            }
            if (!x.Equals(Guid.Empty))
            {
                this.button1.Visible = true;
                await Model.cargarPreguntasEncuesta();   
                IndexPregunta = 0;
                AgregarPreguntaAPanel();
                if (x.ToString() != "ad514d42-55c8-462d-b38d-a49c05e76610")
                {
                    btnNuevaConsulta.Enabled = false;
                }
            }            
        }


        List<Preguntas> PreguntasDependientes = null;

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.lblError.Visible = false;
                if (PanelPreguntas.Controls.Count > 0)
                {
                    var controlPreguntaActual = (PanelPreguntas.Controls[0] as CIDEncuesta.CIDEncuesta);
                    var dato = controlPreguntaActual.Model;
                                     
                    var validationResults = controlPreguntaActual.Model.Validate();
                    if (validationResults.IsValid)
                    {
                        

                        var value = CargarPreguntas(dato);

                        Model._listRespuestasMultiples.RemoveAll(x => x.IdPregunta.Equals(dato.IDPre));
                        Model._ListaRespuestasEncuesta.RemoveAll(x => x.IdPregunta.Equals(dato.IDPre));
                        Model._listRespuestasMultiples.AddRange(value.pregunta.Respuesta.ToList());
                        Model._ListaRespuestasEncuesta.Add(value.respuesta);                  

                        ObtenerTablaPreguntas();

                        //---------------------------               
                        ////verificar si lapregunta es de tipo SI/No
                        if (dato.TipoPregunta == "SI/NO")
                        {
                            //ver si el id de la pregunta actual sean iguales a algun iddependede de la lista
                            //si existe resultados que sean iguales preguntar cuando activarla(si o no)
                            var result = Model.cuestionario.ListaPreguntas.Where(x => x.IdPreguntaDepende == dato.IDPre && x.ActivarCuando.Equals((dato.RdioBtonValue ?? false) ? "SI" : "NO")).OrderBy(x => x.Orden).ToList();

                            if(result != null)
                            {
                                if (result.Count == 0)
                                    PreguntasDependientes = null;
                                else
                                {
                                    PreguntasDependientes = new List<Preguntas>(result);
                                    //PreguntasDependientes.AddRange(result);
                                }
                            }

                            
                            //if (PreguntasDependientes.Count > 0)
                            //{
                            //    //string value = "";
                            //    //foreach (var item in result)
                            //    //{
                            //    //    value = item.ActivarCuando;
                            //    //}

                            //    //var dat = result.Where(x=>x.ActivarCuando == "SI");                            

                            //    //if (dato.RdioBtonValue && value == "SI")
                            //    //{

                            //    //}
                            //    PanelPreguntas.Controls.RemoveAt(0);
                            //    IndexPreguntaDependiente ++;
                            //    PanelRespuestasDependientes(PreguntasDependientes);
                            //}                                                 
                        }


                        PanelPreguntas.Controls.RemoveAt(0);
                        if (PreguntasDependientes is null)
                            IndexPregunta++;
                        else
                            IndexPreguntaDependiente++;
                        AgregarPreguntaAPanel();
                        //---------------

                        // si es si, ver si el radiobutton sea igual a si y mostrar las coincidencias encontradas
                        // si es no y hay resultados y el radiobutton es igual a si no mostrar nada o viceversa.                
                    }
                    else
                    {
                        //controlPreguntaActual.ShowErrors(errorProvider1,typeof(CIDcontrolViewModel),validationResults);

                        this.lblError.Visible = true;
                        lblError.Text = validationResults.ToString();
                    }
                }               
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public void Tabla()
        {
            this.tablaRespuestasMultiples= new DataTable();
            //tablaRespuestasMultiples.Columns.Add("IdEncuesta", typeof(Guid));
            tablaRespuestasMultiples.Columns.Add("IdPregunta", typeof(Guid));
            tablaRespuestasMultiples.Columns.Add("IdRespuestas", typeof(Guid));


            tablaRespuestas = new DataTable();
            tablaRespuestas.Columns.Add("IdEncuesta", typeof(Guid));
            tablaRespuestas.Columns.Add("IdPregunta", typeof(Guid));
            tablaRespuestas.Columns.Add("IdRespuesta", typeof(Guid));
            tablaRespuestas.Columns.Add("RespuestaAbierta", typeof(string));
            tablaRespuestas.Columns.Add("RespuestaSINO", typeof(bool));
        }
        private (Preguntas pregunta,Respuestas respuesta) CargarPreguntas(CIDcontrolViewModel _dato)
        {
            try
            {
                Preguntas dato = new Preguntas();
                dato.IdPregunta = _dato.IDPre;
                dato.Pregunta = _dato.Pregunta;
                dato.TipoPregunta = _dato.TipoPregunta;

                Respuestas Resp = new Respuestas();
                Resp.IdPregunta = _dato.IDPre;
                Resp.Respuesta = _dato.Respuesta;

                if (_dato.TipoPregunta == "SI/NO")
                {
                    Resp.RespuestaSINO = _dato.RdioBtonValue;
                }else if (_dato.TipoPregunta == "ABIERTA")
                {
                    Resp.Respuesta = _dato.Respuesta;
                }else if (_dato.TipoPregunta == "MULTIPLE" && !_dato.respuestasMultiples)
                {
                    Resp.IdRespuesta = (Guid)_dato.ValueGroupRadioButton;
                }else if (_dato.TipoPregunta == "MULTIPLE" && _dato.respuestasMultiples)
                {
                    dato.Respuesta.AddRange(_dato.ListaOpciones.Where(x => x.Seleccionado));
                }               
                     
                return (dato,Resp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private (DataTable tablaPregunta,DataTable tablaRespuesta) ObtenerTablaPreguntas()
        {
            tablaRespuestasMultiples.Rows.Clear();
            tablaRespuestas.Rows.Clear();
            foreach (var item in Model._listRespuestasMultiples)
            {
                
                tablaRespuestasMultiples.Rows.Add(new object[] { item.IdPregunta ,item.IdRespuesta});                
            }

            foreach (var resp in Model._ListaRespuestasEncuesta)
            {
                tablaRespuestas.Rows.Add(new object[] {Model.cuestionario.IdEncuesta,  resp.IdPregunta,resp.IdRespuesta,resp.Respuesta,resp.RespuestaSINO });                
            }
            //Model._listRespuestasMultiples.Clear();
            //Model._ListaRespuestasEncuesta.Clear();
           
            return (tablaRespuestasMultiples, tablaRespuestas);
        }
        private void AgregarPreguntaAPanel()
        {
            try
            {
                if (PreguntasDependientes is null)
                {
                    //var dato = Model.cuestionario.ListaPreguntasPadre[IndexPregunta];
                    //var result = Model.cuestionario.ListaPreguntas.Where(x => x.IdPreguntaDepende == dato.IdPregunta);
                    //if (result is null)
                    //    result = new List<Preguntas>();
                    if (Model.cuestionario.ListaPreguntasPadre.Count == (IndexPregunta + 1))//  && result.Count() == 0 )
                    {
                        //button1.Text = "FINALIZAR ENCUESTA";
                        button1.Text = ">";
                        button1.AutoSize = true;
                        btnNuevaConsulta.Enabled = true;
                    }
                    else
                    {
                        button1.Text = ">";
                        button1.Size = new Size(41, 28);
                        button1.Location = new Point(762, 6);
                    }

                    button1.Text = ">";
                    button1.Size = new Size(41, 28);
                    button1.Location = new Point(762, 6);

                    if (Model.cuestionario.ListaPreguntasPadre.Count > 0 && IndexPregunta >= 0 && IndexPregunta < Model.cuestionario.ListaPreguntasPadre.Count)
                    {
                        var itemPregunta = Model.cuestionario.ListaPreguntasPadre[IndexPregunta];
                        var itemRespuesta = Model._ListaRespuestasEncuesta.FirstOrDefault(x => x.IdPregunta.Equals(itemPregunta.IdPregunta));
                        var itemsRespuestas = Model._listRespuestasMultiples.FindAll(x => x.IdPregunta.Equals(itemPregunta.IdPregunta));

                        CIDEncuesta.CIDEncuesta frmEncuesta =
                            new CIDEncuesta.CIDEncuesta(itemPregunta, itemRespuesta, itemsRespuestas);
                        frmEncuesta.Dock = DockStyle.Fill;
                        PanelPreguntas.Controls.Add(frmEncuesta);
                    }
                }
                else
                {
                    
                    //else
                    //{
                    //    button1.Text = ">";
                    //    button1.Size = new Size(41, 28);
                    //    button1.Location = new Point(762, 6);
                    //}

                    if (PreguntasDependientes.Count > 0 && IndexPreguntaDependiente >= 0 && IndexPreguntaDependiente < PreguntasDependientes.Count)
                    {
                        var itemPregunta = PreguntasDependientes[IndexPreguntaDependiente];
                        var itemRespuesta = Model._ListaRespuestasEncuesta.FirstOrDefault(x => x.IdPregunta.Equals(itemPregunta.IdPregunta));
                        var itemsRespuestas = Model._listRespuestasMultiples.FindAll(x => x.IdPregunta.Equals(itemPregunta.IdPregunta));

                        CIDEncuesta.CIDEncuesta frmEncuesta =
                            new CIDEncuesta.CIDEncuesta(itemPregunta, itemRespuesta, itemsRespuestas);
                        frmEncuesta.Dock = DockStyle.Fill;
                        PanelPreguntas.Controls.Add(frmEncuesta);

                        
                    }

                    if (PreguntasDependientes.Count == (IndexPreguntaDependiente + 1))
                    {
                        if (Model.cuestionario.ListaPreguntasPadre.Count == (IndexPregunta))
                        {
                            //button1.Text = "FINALIZAR ENCUESTA";
                            button1.Text = ">";
                            button1.AutoSize = true;
                            btnNuevaConsulta.Enabled = true;
                        }

                    }

                    if (PreguntasDependientes.Count == IndexPreguntaDependiente + 1)
                    {
                        PreguntasDependientes = null;
                        IndexPreguntaDependiente = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmNuevaConsulta ~ AgregarPreguntaAPanel()");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }            
        }
        private void PanelRespuestasDependientes(List<Preguntas> lst)
        {
            try
            {              
                if (lst.Count > 0 && IndexPreguntaDependiente >= 0 && IndexPreguntaDependiente < lst.Count)
                {
                    var itemPregunta =lst[IndexPreguntaDependiente];
                    var itemRespuesta = Model._ListaRespuestasEncuesta.FirstOrDefault(x => x.IdPregunta.Equals(itemPregunta.IdPregunta));
                    var itemsRespuestas = Model._listRespuestasMultiples.FindAll(x => x.IdPregunta.Equals(itemPregunta.IdPregunta));

                    CIDEncuesta.CIDEncuesta frmEncuesta =
                        new CIDEncuesta.CIDEncuesta(itemPregunta, itemRespuesta, itemsRespuestas);
                    frmEncuesta.Dock = DockStyle.Fill;
                    PanelPreguntas.Controls.Add(frmEncuesta);
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmNuevaConsulta ~ AgregarPreguntaAPanel()");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        private void BtnNuevaConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                btnNuevaConsulta.Enabled = false;

                DialogResult = DialogResult.OK;
                this.Close();                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                btnNuevaConsulta.Enabled = true;
            }
        }
    }
}

