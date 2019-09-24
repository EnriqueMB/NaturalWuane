using CIDFares.Library.Code.Helpers;
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
    public partial class FrmOpcionesCuestionario : Form
    {
        #region Propiedades
        public OpcionesViewModel Model { get; set; }
        private int opcion = 1;
        private bool _controlNutricional;
        #endregion

        #region Constructor
        public FrmOpcionesCuestionario(bool controlNutricional)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<OpcionesViewModel>();
            _controlNutricional = controlNutricional;
        }
        #endregion  
        
        #region Metodos
        private void IniciarBinding()
        {
            try
            {
                dtgEncuestas.AutoGenerateColumns = false;
                dtgEncuestas.DataBindings.Add("Datasource", Model, "_listaCuestionario", true, DataSourceUpdateMode.OnPropertyChanged);
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
       
        #endregion

        #region Eventos
        private void BtnOpcCuestionario_Click(object sender, EventArgs e)
        {
            //GetPanel(new FrmOpcionCuestionario());
        }

        private void FrmOpcionesCuestionario_Load(object sender, EventArgs e)
        {
            IniciarBinding();
            dtgEncuestas.Columns["asignar"].AllowEditing = true;

            if (!_controlNutricional)
            {
                tab.TabPages.Remove(tabPlanAlimentacion);//Aquí se oculta el tab.             
            }          
        }

        private void Tab_Click(object sender, EventArgs e)
        {
            opcion = 1;
            llenarLista();           
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
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, "DEBE MARCAR EL CHECK DE UNA PREGUNTA", TypeMessage.informacion);
                    }
                }
                else if (opcion == 2)
                {

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
