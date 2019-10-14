using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.DTOs.Requests;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Session;
using Syncfusion.Data.Extensions;
using Syncfusion.WinForms.DataGrid;
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
        public EncuestaRequest request { get; set; }
        #endregion

        #region Constructor
        public FrmNuevaEncuesta()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<EncuestasViewModel>();
            this.dtgPreguntas.AllowDrop = true;
            label3.Text = "NUEVA ENCUESTA";
        }

        public FrmNuevaEncuesta(EncuestaRequest _value)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<EncuestasViewModel>();
            request = _value;
            Model.ListaPregunta = _value.dtoPreguntas;
            Model.ListaRespuesta = _value.dtoRespuestas;
            Model.IdEncuesta = _value.dtoEncuesta.IdEncuesta;
            Model.State = EntityState.Update;
            Model.NombreEncuesta = request.dtoEncuesta.NombreEncuesta;
            label3.Text = "MODIFICAR ENCUESTA";
        }
        #endregion

        #region Eventos
        private async void FrmNuevaEncuesta_Load(object sender, EventArgs e)
        {
            try
            {
                IniciarBinding();
                InitProperty();
                await Model.InitComboTipoEncuesta();

                if (Model.State == EntityState.Update)
                {
                    LLenarGriPregunta();
                    LLenarGridRespuesta();
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InitProperty()
        {
            //Agrupa por Area
            GroupColumnDescription groupColumnDescription1 = new GroupColumnDescription();
            groupColumnDescription1.ColumnName = "pregunta";
            this.dtgRespuestas.GroupColumnDescriptions.Add(groupColumnDescription1);
        }

        private void NombreControl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var x = this.NombreEncuestaControl.SelectionStart;
                this.NombreEncuestaControl.Text = this.NombreEncuestaControl.Text.ToUpper();
                //this.NombreEncuestaControl.Text = this.NombreEncuestaControl.Text.Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "U").Replace("´", "").Replace("  ", " ");
                this.NombreEncuestaControl.SelectionStart = x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
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
        private void BtnAgregarPregunta_Click(object sender, EventArgs e)
        {
            try
            {
                //var listauax = PreguntasEncuesta.Where(dto => dto.TipoPregunta.Equals("SI/NO"));
                var listauax = Model.ListaPregunta.Where(dto => dto.TipoPregunta.Equals("SI/NO"));
                FrmAgregarPregunta _Pregunta = new FrmAgregarPregunta(listauax.ToList());
                _Pregunta.ShowDialog();
                _Pregunta.Dispose();

                if (_Pregunta.DialogResult == DialogResult.OK)
                {                   
                    var x = _Pregunta.CargarDatos();
                    Model.ListaPregunta.Add(x);
                    //this.PreguntasEncuesta.Add(x);
                }                

                //CargarGridPreguntas();

            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, ex.Message.ToString(), TypeMessage.error);
            }
        }
        private async void BtnNuevaEncuesta_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnNuevaEncuesta.Enabled = false;

                Model.ListaPregunta.ToList().ForEach(x => x.Orden = Model.ListaPregunta.IndexOf(x));
                this.CleanErrors(errorProvider1, typeof(EncuestasViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();

                if (validationResults.IsValid)
                {                   
                    Model.TblPregunta = ObtenerTablaPreguntas(Model.ListaPregunta.ToList());                    
                    Model.TblRespuesta = ObtenerTablaRepuestas(Model.ListaRespuesta.ToList());              

                    if (this.Model.ListaPregunta.Count > 0)
                    {
                        int x = await Model.GuardarEncuesta(CurrentSession.IdCuentaUsuario);

                        if (x == 1)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.informacion);
                            this.Close();
                        }
                        else
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                        }
                    }
                    else
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, "LA ENCUESTA DEBE CONTENER AL MENOS UNA PREGUNTA", TypeMessage.informacion);
                    }
                }
                else
                {
                    this.ShowErrors(errorProvider1, typeof(EncuestasViewModel), validationResults);
                    if(validationResults.ToString() == "MULTIPLE")
                        CIDMessageBox.ShowAlert(Messages.SystemName, "DEBE CAPTURAR RESPUESTAS DE LAS PREGUNTAS MULTIPLES", TypeMessage.informacion);
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmNuevaEncuesta ~ BtnNuevaEncuesta_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);

            }
            finally
            {
                this.btnNuevaEncuesta.Enabled = true;
            }
        }
        private void BtnEliminarPregunta_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {              
                    this.Model.ListaPregunta.Remove(item);              
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
        private void BtnEliminarRespuesta_Click(object sender, EventArgs e)
        {
            try
            {
                var item = Seleccionado();
                if (item != null)
                {              
                    this.Model.ListaRespuesta.Remove(item);               
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
                    if (item.TipoPregunta == "MULTIPLE")
                    {
                        FrmAgregarRespuesta _Resp = new FrmAgregarRespuesta(item);
                        _Resp.ShowDialog();
                        _Resp.Dispose();
                        if (_Resp.DialogResult == DialogResult.OK)
                        {
                            var x = _Resp.CargarDatosR();                 
                            this.Model.ListaRespuesta.Add(x);
                        }               
                    }
                    else
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, "LA PREGUNTA SELECCIONADA ES DE RESPUESTA ABIERTA", TypeMessage.informacion);
                    }
                }
                else
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, "DEBE SELECCIONAR UNA FILA DEL GRID DE PREGUNTAS", TypeMessage.informacion);
                }
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, ex.Message.ToString(), TypeMessage.error);
            }
        }

        private void BtnSubir_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    int RowToMove = this.dtgPreguntas.CurrentCell.RowIndex;
                    if (RowToMove > 1)
                    {
                        //Preguntas pregunta = new Preguntas { IdPregunta = item.IdPregunta, Pregunta = item.Pregunta, Respuesta = item.Respuesta, TipoPregunta = item.TipoPregunta };
                        //this.PreguntasEncuesta.Remove(PreguntasEncuesta.Find(x=> x.IdPregunta.Equals(item.IdPregunta)));     
                        this.Model.ListaPregunta.Remove(item);      
                        this.Model.ListaPregunta.Insert(RowToMove - 2, item);

                    }
                    else
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, "LA PREGUNTA YA SE ENCUENTRA EN LA PRIMERA POSICION", TypeMessage.informacion);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnBajar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    int RowToMove = this.dtgPreguntas.CurrentCell.RowIndex;
         
                    if (RowToMove < Model.ListaPregunta.Count)
                    {
                        //Preguntas pregunta = new Preguntas { IdPregunta = item.IdPregunta, Pregunta = item.Pregunta, Respuesta = item.Respuesta, TipoPregunta = item.TipoPregunta };
                        //this.PreguntasEncuesta.Remove(PreguntasEncuesta.Find(x=> x.IdPregunta.Equals(item.IdPregunta)));                    
                        this.Model.ListaPregunta.Remove(item);                    
                        this.Model.ListaPregunta.Insert(RowToMove, item);
                    }
                    else
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, "LA PREGUNTA YA SE ENCUENTRA EN LA ULTIMA POSICION", TypeMessage.informacion);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Metodos
        public void LLenarGriPregunta()
        {
            try
            {
                this.dtgPreguntas.DataSource = Model.ListaPregunta;
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, ex.Message.ToString(), TypeMessage.error);
            }
        }

        public void LLenarGridRespuesta()
        {
            try
            {
                this.dtgRespuestas.DataSource = Model.ListaRespuesta;
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, ex.Message.ToString(), TypeMessage.error);
            }
        }
        private void IniciarBinding()
        {
            try
            {
                NombreEncuestaControl.DataBindings.Add("Text", Model, "NombreEncuesta", true, DataSourceUpdateMode.OnPropertyChanged);

                IdTipoEncuestaControl.DataBindings.Add("SelectedValue", Model, "IdTipoEncuesta", true, DataSourceUpdateMode.OnPropertyChanged);
                IdTipoEncuestaControl.DataBindings.Add("DataSource", Model, "_ListaTipoEncuesta", true, DataSourceUpdateMode.OnPropertyChanged);
                IniciarComboTE();

                this.dtgPreguntas.AutoGenerateColumns = false;
                dtgPreguntas.DataBindings.Add("DataSource", Model, "ListaPregunta", true, DataSourceUpdateMode.OnPropertyChanged);

                this.dtgRespuestas.AutoGenerateColumns = false;
                dtgRespuestas.DataBindings.Add("DataSource", Model, "ListaRespuesta", true, DataSourceUpdateMode.OnPropertyChanged);
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
                IdTipoEncuestaControl.DisplayMember = "Descripcion";
                IdTipoEncuestaControl.ValueMember = "IdTipoEncuesta";
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, ex.Message.ToString(), TypeMessage.error);
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

        #region Crear Nuevatabla
        private DataTable ObtenerTablaPreguntas(List<Preguntas> Lista)
        {
            try
            {
                DataTable TablaP = new DataTable();
                TablaP.Columns.Add("IdPregunta", typeof(Guid));
                TablaP.Columns.Add("Pregunta", typeof(string));
                TablaP.Columns.Add("TipoPregunta", typeof(string));
                TablaP.Columns.Add("DependeDe", typeof(Guid));
                TablaP.Columns.Add("ActivarCuando", typeof(string));
                TablaP.Columns.Add("Orden", typeof(int));
                TablaP.Columns.Add("respuestasMultiples", typeof(bool));
                foreach (var item in Lista)
                {
                    TablaP.Rows.Add(new object[] { item.IdPregunta, item.Pregunta, item.TipoPregunta, item.IdPreguntaDepende,item.ActivarCuando,item.Orden,item.respuestasMultiples });
                }
                return TablaP;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private DataTable ObtenerTablaRepuestas(List<Respuestas> ListaR)
        {
            try
            {
                DataTable TablaR = new DataTable();
                TablaR.Columns.Add("IdRespuesta", typeof(Guid));
                TablaR.Columns.Add("Respuesta", typeof(string));
                TablaR.Columns.Add("IdPregunta", typeof(Guid));
                foreach (var item in ListaR)
                {
                    TablaR.Rows.Add(new object[] { item.IdRespuesta, item.Respuesta, item.IdPregunta });
                }
                return TablaR;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion       

        private void CargarDatos()
        {
            try
            {
                Model.NombreEncuesta = request.dtoEncuesta.NombreEncuesta;
                Model.IdTipoEncuesta = request.dtoEncuesta.IdTipoEncuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
