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
    public partial class FrmOpcionCuestionario : Form
    {

        #region Propiedades
        public OpcionesViewModel Model { get; set; }
        #endregion

        #region Construcrtor
        public FrmOpcionCuestionario()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<OpcionesViewModel>();
            dtgEncuestas.ShowGroupDropArea = false;
        }
        #endregion

        #region Eventos
        private void FrmOpcionCuestionario_Load(object sender, EventArgs e)
        {
            llenarLista();
            IniciarBinding();
            dtgEncuestas.Columns["asignar"].AllowEditing = true;       
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

        public OpcionCuestionario ObtenerSeleccionado()
        {
            try
            {
                if (dtgEncuestas.SelectedItems.Count == 1)
                {
                    return (OpcionCuestionario)dtgEncuestas.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private void BtnContestarEncuesta_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    if (item.asignar)
                    {
                       // newlista = Model._listaCuestionario;
                    }
                    else
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, "DEBE MARCAR EL CHECK DE UNA PREGUNTA", TypeMessage.informacion);
                    }                        
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

        private void /*OpcionCuestionario */cargarDatos()
        {
            try
            {
                foreach (var item in Model._listaCuestionario)
                {
                    if (item.asignar)
                    {
                        MessageBox.Show("mensaje confirmacion");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
