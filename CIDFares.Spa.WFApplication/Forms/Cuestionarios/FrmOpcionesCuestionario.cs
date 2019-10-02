using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    public partial class FrmOpcionesCuestionario : Form
    {
        #region Propiedades
        public OpcionesViewModel Model { get; set; }
        private int opcion = 1;
        #endregion

        #region Constructor
        public FrmOpcionesCuestionario()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<OpcionesViewModel>();     
            dtgEncuestas.ShowGroupDropArea = false;
            dtgMediciones.ShowGroupDropArea = false;
            dtgComentarios.ShowGroupDropArea = false;
        }
        #endregion

        #region Metodos
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

        private void IniciarBinding()
        {
            try
            {
                NombreCompleto.DataBindings.Add("Text", Model, "NombreCompleto", true, DataSourceUpdateMode.OnPropertyChanged);

                TipoConsultaControl.DataBindings.Add("SelectedValue", Model, "IdTipoConsulta", true, DataSourceUpdateMode.OnPropertyChanged);
                TipoConsultaControl.DataBindings.Add("DataSource", Model, "_ListaTipoconsulta", true, DataSourceUpdateMode.OnPropertyChanged);
                Iniciarcombo();


                dtgEncuestas.AutoGenerateColumns = false;
                dtgEncuestas.DataBindings.Add("Datasource", Model, "_listaCuestionario", true, DataSourceUpdateMode.OnPropertyChanged);

                dtgMediciones.AutoGenerateColumns = false;
                dtgMediciones.DataBindings.Add("Datasource", Model, "_ListaMediciones", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmOpcionCuestionario ~ iniciarBinding()");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private void llenarLista()
        {
            try
            {
                this.dtgEncuestas.DataSource = Model._listaCuestionario;
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmOpcionCuestionario ~ llenarLista()");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private void llenarListamediciones()
        {
            try
            {
                this.dtgMediciones.DataSource = Model._ListaMediciones;
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmOpcionCuestionario ~ llenarListamediciones()");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
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

        private void Botones()
        {
            this.tab.Visible = true;
            this.groupOpciones.Visible = true;
            this.btnAceptar.Visible = true;
            this.btnGuardarConsulta.Visible = true;
            this.btnGuardarConsulta.Enabled = false;
        }
        #endregion

        #region Eventos  
        private void FrmOpcionesCuestionario_Load(object sender, EventArgs e)
        {
            IniciarBinding();
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

                        FrmNuevaConsultaControl _frmNuevaconsulta = new FrmNuevaConsultaControl(lista);
                        _frmNuevaconsulta.ShowDialog();
                        _frmNuevaconsulta.Dispose();
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
        private async void Tab_Click(object sender, EventArgs e)
        {
            var x = tab.SelectedIndex;

            switch (x)
            {
                case 0:
                    opcion = 1;
                    llenarLista();
                    this.btnAceptar.Text = "CONTESTAR ENCUESTAS";
                    break;
                case 1:
                    opcion = 2;
                    await Model.llenarListaMediciones();
                    llenarListamediciones();
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
        #endregion

        private void BtnGuardarConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardarConsulta.Enabled = false;

                var x = Model._tablaMedicion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                btnGuardarConsulta.Enabled = true;
            }
        }
     
    }
}
