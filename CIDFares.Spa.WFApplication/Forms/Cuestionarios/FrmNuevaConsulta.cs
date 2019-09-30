using CIDFares.Library.Code.Extensions;
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

        #endregion

        #region constructor
        public FrmNuevaConsultaControl(List<Cuestionario> listaEncuesta)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ConsultaViewModel>();
            Model.AplicarEncuestaLista = listaEncuesta;
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
        private void PtbCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSelectCliente _select = new FrmSelectCliente();
                _select.ShowDialog();
                _select.Dispose();
                if (_select.cliente != null)
                    CargarDatos(_select.cliente);

            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmNuevaConsulta ~ PtbCliente_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        private void PtbNuevoCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCliente _cliente = new FrmCliente();
                _cliente.ShowDialog();
                _cliente.Dispose();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmNuevaConsulta ~ PtbNuevoCliente_Click(object sender, EventArgs e)");
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

                    FrmOpcionesCuestionario _opcion = new FrmOpcionesCuestionario(/*controlNutricional*/);
                    _opcion.ShowDialog();
                    _opcion.Dispose();

                    if (_opcion.DialogResult == DialogResult.OK)
                    {
                         Model.AplicarEncuestaLista.Add(new Cuestionario {IdEncuesta = Guid.Empty, IdTipoEncuesta = 0,NombreEncuesta = "SELECCIONE",Descripcion= ""});
                         _opcion.Model._listaCuestionario.Where(x => x.asignar == true).Select(u => { Model.AplicarEncuestaLista.Add(u.datos); return u; }).ToList();

                        IniciarComboEncuestas();
                    }
                }
                else
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName,"DEBE SELECCIONAR UN CLIENTE Y TIPO DE CONSULTA", TypeMessage.informacion);
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmNuevaConsulta ~ BtnOpciones_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        #endregion

        #region Metodos
        private void Iniciarbinding()
        {
            try
            {
                NombreCompleto.DataBindings.Add("Text", Model, "NombreCompleto", true, DataSourceUpdateMode.OnPropertyChanged);

                TipoConsultaControl.DataBindings.Add("SelectedValue", Model, "IdTipoConsulta", true, DataSourceUpdateMode.OnPropertyChanged);
                TipoConsultaControl.DataBindings.Add("DataSource", Model, "_ListaTipoconsulta", true, DataSourceUpdateMode.OnPropertyChanged);
                Iniciarcombo();

                cmbEncuestas.DataBindings.Add("SelectedItem", Model, "cuestionario", true, DataSourceUpdateMode.OnPropertyChanged);
                cmbEncuestas.DataBindings.Add("DataSource", Model, "AplicarEncuestaLista", true, DataSourceUpdateMode.OnPropertyChanged);
                IniciarComboEncuestas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CargarDatos(Cliente value)
        {
            try
            {
                this.NombreCompleto.Text = value.NombreCompleto.ToUpper();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Iniciarcombo()
        {
            try
            {
                try
                {
                    TipoConsultaControl.DisplayMember = "Descripcion";
                    TipoConsultaControl.ValueMember = "IdTipoConsulta";
                }
                catch (Exception ex)
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, ex.Message.ToString(), TypeMessage.error);
                }
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

                //var result = Model.cuestionario.ListaPreguntas;                
                //var result1 = result.Where(a => a.IdPreguntaDepende == item.IdPregunta).ToList();               
                
                IndexPregunta = 0;
                AgregarPreguntaAPanel();               
            }
        }
    
        private void Button1_Click(object sender, EventArgs e)
        {
            this.lblError.Visible = false;
            if (PanelPreguntas.Controls.Count > 0)
            {
                var controlPreguntaActual = (PanelPreguntas.Controls[0] as CIDEncuesta.CIDEncuesta);

                var dato = controlPreguntaActual.Model;  
                var validationResults = controlPreguntaActual.Model.Validate();
                if (validationResults.IsValid)
                {
                    //guardar las respuesuestas en una nueva lista.
                    //generar una tabla atravez de la lista.

                    //verificar si lapregunta es de tipo SI/No
                    if (dato.TipoPregunta == "SI/NO")
                    {
                        //ver si el id de la pregunta actual sean iguales a algun iddependede de la lista
                        var result = Model.cuestionario.ListaPreguntas.Where(x => x.IdPreguntaDepende == dato.IDPre).OrderBy(x=>x.Orden).ToList();
                        if(result.Count > 0)
                        {
                            string value = "";
                            //si existe resultados que sean iguales preguntar cuando activarla (si o no)
                            foreach (var item in result)
                            {                        
                                value = item.ActivarCuando;
                            }

                            if (dato.RdioBtonValue && value == "SI")
                            {
                               
                            }
                        }
                    }
                  
                    PanelPreguntas.Controls.RemoveAt(0);
                    IndexPregunta++;
                    AgregarPreguntaAPanel();
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

        private void AgregarPreguntaAPanel()
        {
            if (Model.cuestionario.ListaPreguntas.Count == (IndexPregunta + 1))
            {
                button1.Text = "FINALIZAR ENCUESTA";
                button1.AutoSize = true;                            
            }
            else
            {
                button1.Text = ">";
                button1.Size = new Size(41, 28);
                button1.Location = new Point(762, 6);
            }
           
            if (Model.cuestionario.ListaPreguntas.Count > 0 && IndexPregunta >= 0 && IndexPregunta < Model.cuestionario.ListaPreguntas.Count)
            {                
                CIDEncuesta.CIDEncuesta frmEncuesta = new CIDEncuesta.CIDEncuesta(Model.cuestionario.ListaPreguntas[IndexPregunta]);
                frmEncuesta.Dock = DockStyle.Fill;
                PanelPreguntas.Controls.Add(frmEncuesta);
            }            
        }

        private void BtnNuevaConsulta_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

