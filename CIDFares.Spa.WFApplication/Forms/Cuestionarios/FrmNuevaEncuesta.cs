using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Session;
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
        public BindingList<Preguntas> PreguntasEncuesta = new BindingList<Preguntas>();
        private BindingList<Respuestas> RespuestasEncuesta = new BindingList<Respuestas>();
        #endregion

        #region Constructor
        public FrmNuevaEncuesta()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<EncuestasViewModel>();
            this.dtgPreguntas.AllowDrop = true;
        }

        #endregion

        #region Eventos
        private async void FrmNuevaEncuesta_Load(object sender, EventArgs e)
        {
            try
            {
                InitProperty();
                await Model.InitComboTipoEncuesta();
                IniciarBinding();  
                
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
                this.NombreEncuestaControl.Text = this.NombreEncuestaControl.Text.Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "U").Replace("´", "").Replace("  ", " ");
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
                var listauax = PreguntasEncuesta.Where(dto => dto.TipoPregunta.Equals("SI/NO"));
                FrmAgregarPregunta _Pregunta = new FrmAgregarPregunta(listauax.ToList());
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
        private async void BtnNuevaEncuesta_Click(object sender, EventArgs e)
        {
            try
            {
                PreguntasEncuesta.ToList().ForEach(x => x.Orden = PreguntasEncuesta.IndexOf(x));              
                this.CleanErrors(errorProvider1, typeof(EncuestasViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();

                if (validationResults.IsValid)
                {                   
                    Model.TblPregunta = ObtenerTablaPreguntas(PreguntasEncuesta.ToList());
                    Model.TblRespuesta =  ObtenerTablaRepuestas(RespuestasEncuesta.ToList());

                    if (this.PreguntasEncuesta.Count > 0)
                    {
                        int x =  await Model.GuardarEncuesta(CurrentSession.IdCuentaUsuario);

                        if (x == 1)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName,Messages.SuccessMessage, TypeMessage.informacion);
                        }
                        else
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName,Messages.ErrorMessage, TypeMessage.error);
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
                    if (item.TipoPregunta == "MULTIPLE")
                    {
                        //FrmAgregarPregunta _Resp = new FrmAgregarPregunta(2,item.Pregunta,item.IdPregunta, PreguntasEncuesta.ToList());
                        FrmAgregarRespuesta _Resp = new FrmAgregarRespuesta(item);
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
                        this.PreguntasEncuesta.Remove(item);
                        this.PreguntasEncuesta.Insert(RowToMove - 2, item);
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

                    if (RowToMove < PreguntasEncuesta.Count)
                    {
                        //Preguntas pregunta = new Preguntas { IdPregunta = item.IdPregunta, Pregunta = item.Pregunta, Respuesta = item.Respuesta, TipoPregunta = item.TipoPregunta };
                        //this.PreguntasEncuesta.Remove(PreguntasEncuesta.Find(x=> x.IdPregunta.Equals(item.IdPregunta)));
                        this.PreguntasEncuesta.Remove(item);
                        this.PreguntasEncuesta.Insert(RowToMove, item);
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
        private void CargarGridPreguntas()
        {
            try
            {
                //dtgPreguntas.DataSource = null;
                BindingSource Source = new BindingSource();
                Source.DataSource = PreguntasEncuesta;//.Clone();
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
                TablaP.Columns.Add("Pregunta",typeof(string));
                TablaP.Columns.Add("TipoPregunta", typeof(string));
                TablaP.Columns.Add("DependeDe",typeof(Guid));
                TablaP.Columns.Add("Orden", typeof(int));
                foreach (var item in Lista)
                {
                    TablaP.Rows.Add(new object[] { item.IdPregunta,item.Pregunta,item.TipoPregunta, item.IdPreguntaDepende,item.Orden });
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
                TablaR.Columns.Add("Respuesta",typeof(string));               
                TablaR.Columns.Add("IdPregunta",typeof(Guid));
                foreach (var item in ListaR)
                {
                    TablaR.Rows.Add(new object[] { item.IdRespuesta,item.Respuesta,item.IdPregunta});
                }
                return TablaR;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion
    }
}
