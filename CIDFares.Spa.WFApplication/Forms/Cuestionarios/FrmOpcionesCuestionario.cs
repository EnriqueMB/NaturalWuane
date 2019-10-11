using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Library.Controls.CIDWait.Code;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.DTOs;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Session;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    public partial class FrmOpcionesCuestionario : Form
    {
        #region Propiedades
        public OpcionesViewModel Model { get; set; }
        private int opcion = 1;
        ConsultaDto dtoConsulta;
        #endregion

        #region Constructor
        public FrmOpcionesCuestionario()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<OpcionesViewModel>();
            dtgEncuestas.ShowGroupDropArea = false;
            dtgMediciones.ShowGroupDropArea = false;
            dtgComentarios.ShowGroupDropArea = false;
            tab.GetControl(1).Enabled = false;
        }

        public FrmOpcionesCuestionario(ConsultaDto _value)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<OpcionesViewModel>();
            dtoConsulta = _value;
            Model._listaComentario = _value.dtoComentariosConsulta;
            Model._listaCuestionario = _value.dtoEncuestaConsulta;
            Model._ListaMediciones = _value.dtoMedicionesConsulta;
            Model._tablaRespuestas = _value.dtoEncuestaConsultaOpciones.ToList().ToDataTable(new List<string> { "IdEncuesta", "IdPregunta", "IdRespuesta", "Respuesta", "RespuestaSINO" });
            Model._tablaRespuestasMultiple = _value.dtoRespuestaMultiple.ToList().ToDataTable(new List<string> { "IdPregunta", "IdRespuesta" });
            //Model._tablaMedicion =TablaMedicion();
            Model._tablaMedicion = _value.dtoMedicionesConsulta.Where(x => x.asignar).ToList().ToDataTable(new List<string> { "dato", "IdMedicion", "Nombre", "IdValorSeleccionado", "valor" });
            Model.State = EntityState.Update;
        }
        #endregion        

        #region Metodos
        //private DataTable TablaMedicion()
        //{
        //    DataTable tblMedicion = new DataTable();
        //    tblMedicion.Columns.Add("IdMedicion", typeof(int));
        //    tblMedicion.Columns.Add("Nombre", typeof(string));
        //    tblMedicion.Columns.Add("IdValorSeleccionado", typeof(int));
        //    tblMedicion.Columns.Add("valor", typeof(string));
        //    foreach (var item in dtoConsulta.dtoMedicionesConsulta.Where(x => x.asignar))
        //    {
        //        tblMedicion.Rows.Add(new object[] { item.dato.IdMedicion, item.dato.Nombre, item.dato.IdValorSeleccionado, item.dato.valor });
        //    }

        //    return tblMedicion;
        //}

        private void Iniciarcombo()
        {
            try
            {               
                TipoConsultaControl.DisplayMember = "Descripcion";
                TipoConsultaControl.ValueMember = "IdTipoConsulta";              
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
                FechaControl.DataBindings.Add("Value", Model, "FechaConsulta", true, DataSourceUpdateMode.OnPropertyChanged);

                NombreCompleto.DataBindings.Add("Text", Model, "NombreCompleto", true, DataSourceUpdateMode.OnPropertyChanged);

                TipoConsultaControl.DataBindings.Add("SelectedValue", Model, "IdTipoConsulta", true, DataSourceUpdateMode.OnPropertyChanged);
                TipoConsultaControl.DataBindings.Add("DataSource", Model, "_ListaTipoconsulta", true, DataSourceUpdateMode.OnPropertyChanged);
                Iniciarcombo();

                dtgEncuestas.AutoGenerateColumns = false;
                dtgEncuestas.DataBindings.Add("Datasource", Model, "_listaCuestionario", true, DataSourceUpdateMode.OnPropertyChanged);

                dtgMediciones.AutoGenerateColumns = false;
                dtgMediciones.DataBindings.Add("Datasource", Model, "_ListaMediciones", true, DataSourceUpdateMode.OnPropertyChanged);

                DiagnosticoControl.DataBindings.Add("Text",Model, "Diagnostico",true,DataSourceUpdateMode.OnPropertyChanged);
                RecomendacionesControl.DataBindings.Add("Text",Model, "Recomendaciones", true,DataSourceUpdateMode.OnPropertyChanged);
                ObservacionesControl.DataBindings.Add("Text",Model, "Observaciones", true,DataSourceUpdateMode.OnPropertyChanged);

                this.dtgComentarios.AutoGenerateColumns = false;
                dtgComentarios.DataBindings.Add("DataSource", Model, "_listaComentario", true, DataSourceUpdateMode.OnPropertyChanged);

            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmOpcionCuestionario ~ iniciarBinding()");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        public void LLenarGridComentarios()
        {
            try
            {
                this.dtgComentarios.DataSource = Model._listaComentario;
            }
            catch (Exception ex)
            {
                CIDMessageBox.ShowAlert(Messages.SystemName, ex.Message.ToString(), TypeMessage.error);
            }
        }

        //private void llenarLista()
        //{
        //    try
        //    {
        //        this.dtgEncuestas.DataSource = Model._listaCuestionario;
        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorLogHelper.AddExcFileTxt(ex, "FrmOpcionCuestionario ~ llenarLista()");
        //        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
        //    }
        //}

        //private void llenarListamediciones()
        //{
        //    try
        //    {
        //        this.dtgMediciones.DataSource = Model._ListaMediciones;
        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorLogHelper.AddExcFileTxt(ex, "FrmOpcionCuestionario ~ llenarListamediciones()");
        //        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
        //    }
        //}

        private void CargarDatos(Cliente value)
        {
            try
            {
                this.NombreCompleto.Text = value.NombreCompleto.ToUpper();
                Model.IdCliente = value.IdCliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CargarDatosConsulta()
        {
            try
            {
                Model.FechaConsulta = dtoConsulta.dtoConsulta.Fecha;
                Model.NombreCompleto = dtoConsulta.dtoConsulta.datosCliente.NombreCompleto;
                Model.IdTipoConsulta = dtoConsulta.dtoConsulta.IdTipoConsulta;
                Model.Observaciones = dtoConsulta.dtoConsulta.Observaciones;
                Model.Recomendaciones = dtoConsulta.dtoConsulta.Recomendaciones;
                Model.Diagnostico = dtoConsulta.dtoConsulta.Diagnostico;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Botones()
        {
            this.tab.Visible = true;
            this.groupOpciones.Visible = true;
            this.btnAceptar.Visible = true;
            this.btnGuardarConsulta.Visible = true;
            this.btnGuardarConsulta.Enabled = false;
        }
        private (DataTable comentarios, DataTable cuestionario) ObtenerTabla()
        {
            try
            {
                DataTable _comentarios = new DataTable();
                _comentarios.Columns.Add("IdComentario", typeof(Guid));
                _comentarios.Columns.Add("Comentario", typeof(string));
                _comentarios.Columns.Add("Fecha", typeof(DateTime));
                _comentarios.Columns.Add("Nombre", typeof(string));
                _comentarios.Columns.Add("IdConsulta", typeof(Guid));

                DataTable _Cuestionario = new DataTable();
                _Cuestionario.Columns.Add("IdEncuesta", typeof(Guid));
                _Cuestionario.Columns.Add("NombreEncuesta", typeof(string));
                _Cuestionario.Columns.Add("Asignado", typeof(bool));                

                foreach (var item in Model._listaComentario)
                {
                    _comentarios.Rows.Add(new object[] { item.IdComentario, item.Comentario, item.Fecha, item.Nombre, item.dato.IdConsulta });
                }

                foreach (var x in Model._listaCuestionario.Where(x => x.asignar))
                {
                    _Cuestionario.Rows.Add(new object[] { x.datos.IdEncuesta, x.datos.NombreEncuesta, x.asignar });
                }

                return (_comentarios, _Cuestionario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eventos  
        private async void FrmOpcionesCuestionario_Load(object sender, EventArgs e)
        {
            Model.FechaConsulta = DateTime.Today;
            await Model.listaTipoConsulta();
            if (Model.State == EntityState.Update)
            {
                groupOpciones.Visible = true;
                groupOpciones.Enabled = true;
                tab.Visible = true;
                NombreCompleto.Enabled = false;
                ptbCliente.Enabled = false;
                btnAceptar.Visible = true;
                btnGuardarConsulta.Visible = true;                
                CargarDatosConsulta();
                LLenarGridComentarios();
                Model.IdCliente = dtoConsulta.dtoConsulta.IdCliente;
                Model.IdConsulta = dtoConsulta.dtoConsulta.IdConsulta;
            }
            dtgEncuestas.Columns["asignar"].AllowEditing = true;
            dtgMediciones.Columns["asignar"].AllowEditing = true;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (opcion == 1)
                {
                    var result = Model._listaCuestionario.Where(x => x.asignar);

                    if (result.Count() > 0)
                    {
                        List<Cuestionario> lista = new List<Cuestionario>();
                        lista.Add(new Cuestionario { IdEncuesta = Guid.Empty, IdTipoEncuesta = 0, NombreEncuesta = "SELECCIONE", Descripcion = "" });
                        Model._listaCuestionario.Where(x => x.asignar == true).Select(u => { lista.Add(u.datos); return u; }).ToList();

                        FrmNuevaConsultaControl _frmNuevaconsulta;                       
                        if (Model.State == EntityState.Update)
                        {
                            List<Respuestas> lt = new List<Respuestas>(dtoConsulta.dtoEncuestaConsultaOpciones);
                            List<Respuestas> lstM = new List<Respuestas>(dtoConsulta.dtoRespuestaMultiple);

                            _frmNuevaconsulta = new FrmNuevaConsultaControl(lista,lt,lstM);                           
                        }
                        else
                        {
                            _frmNuevaconsulta = new FrmNuevaConsultaControl(lista);
                        }

                        _frmNuevaconsulta.ShowDialog();
                        _frmNuevaconsulta.Dispose();

                        if (_frmNuevaconsulta.DialogResult == DialogResult.OK)
                        {                         
                            Model._tablaRespuestasMultiple = _frmNuevaconsulta.tablaRespuestasMultiples;                        
                            Model._tablaRespuestas = _frmNuevaconsulta.tablaRespuestas;
                            tab.GetControl(1).Enabled = true;
                        }
                    }
                    else
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, "DEBE SELECCIONAR UNA PREGUNTA", TypeMessage.informacion);
                    }
                }
                else if (opcion == 2)
                {
                    var result = Model._ListaMediciones.Where(x => x.asignar);
                    if (result.Count() > 0)
                    {
                      List<Medicion> lst = new List<Medicion>();

                        Model._ListaMediciones.Where(x => x.asignar).Select(a => { lst.Add(a.dato); return a; }).ToList();

                        FrmContestarMedicion _medicion = new FrmContestarMedicion(lst);
                        _medicion.ShowDialog();
                        _medicion.Dispose();
                        
                        if(_medicion.DialogResult == DialogResult.OK)
                        {
                            Model._tablaMedicion = _medicion._tablaMedicion;
                            groupOpciones.Enabled = true;
                            btnGuardarConsulta.Enabled = true;
                        }                       
                    }
                    else
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, "DEBE SELECCIONAR UNA MEDICION", TypeMessage.informacion);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Tab_Click(object sender, EventArgs e)
        {
            var x = tab.SelectedIndex;

            switch (x)
            {
                case 0:
                    opcion = 1;
                    //llenarLista();
                    this.btnAceptar.Text = "CONTESTAR ENCUESTAS";
                    break;
                case 1:
                    opcion = 2;
                    //await Model.llenarListaMediciones();
                    //llenarListamediciones();
                    this.btnAceptar.Text = "CONTESTAR MEDICIONES";
                    break;
            }
        }

        private void PtbCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSelectCliente _select = new FrmSelectCliente();
                _select.ShowDialog();
                _select.Dispose();
                if (_select.cliente != null && _select.DialogResult == DialogResult.OK)
                    CargarDatos(_select.cliente);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmNuevaConsulta ~ PtbCliente_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        private void BtnOpciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.NombreCompleto.Text != string.Empty && this.TipoConsultaControl.SelectedIndex > 0)
                {
                    bool controlNutricional = (TipoConsultaControl.SelectedIndex == 3) ? true : false;
                    if (!controlNutricional)
                    {
                        tab.TabPages.Remove(tabPlanAlimentacion);//Aquí se oculta el tab.                          
                    }
                    else
                    {
                        if (!tab.Controls.Contains(tabPlanAlimentacion))
                            tab.TabPages.Add(tabPlanAlimentacion);
                    }
                    Botones();
                }
                else
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, "DEBE SELECCIONAR UN CLIENTE Y TIPO DE CONSULTA", TypeMessage.informacion);
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmNuevaConsulta ~ BtnOpciones_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        private void FrmOpcionesCuestionario_Shown(object sender, EventArgs e)
        {
            try
            {
                CIDWait.Show(async () =>
                {
                    if (Model.State != EntityState.Update)
                    {
                        Task task1 = Model.llenarListaEncuesta();
                        Task task2 = Model.llenarListaMediciones();
                        Task task3 = Model.listaTipoConsulta();
                        await Task.WhenAll(new[] { task1,task2, task3 });
                    }
                   
                }, "Espere");
                this.IniciarBinding();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private async void BtnGuardarConsulta_Click(object sender, EventArgs e)
        {
            try
            {         
                btnGuardarConsulta.Enabled = false;

                this.CleanErrors(errorProvider1, typeof(OpcionesViewModel));
                var validationResults = Model.Validate();
                validationResults.ToString();

                if (validationResults.IsValid)
                {
                    if (Model._listaComentario.Count > 0)
                    {
                        Model._tablaComentario = ObtenerTabla().comentarios;
                        Model._tablaCuestionario = ObtenerTabla().cuestionario;
                        Model.idUsuario = CurrentSession.IdCuentaUsuario;
                        var x = await Model.GuardarConsulta();

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
                        CIDMessageBox.ShowAlert(Messages.SystemName, "DEBE INGRESAR ALMENOS UN COMENTARIO", TypeMessage.informacion);
                    }
                }
                else
                {
                    this.ShowErrors(errorProvider1, typeof(OpcionesViewModel), validationResults);
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmNuevaEncuesta ~ BtnNuevaEncuesta_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
            finally
            {
                btnGuardarConsulta.Enabled = true;
            }
        }
        private void BtnComentarios_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAgregarComentarios _frmComentario = new FrmAgregarComentarios();
                _frmComentario.ShowDialog();
                _frmComentario.Dispose();

                if (_frmComentario.DialogResult == DialogResult.OK)
                {
                    var x = _frmComentario.CargarDatos();
                    Model._listaComentario.Add(x);
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
