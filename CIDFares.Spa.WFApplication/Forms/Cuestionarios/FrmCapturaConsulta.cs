using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Library.Controls.CIDWait.Code;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Session;
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
    public partial class FrmCapturaConsulta : Form
    {
        #region Propiedades
        public CapturaConsultaViewModel Model { get; set; }
        #endregion

        #region constructor
        public FrmCapturaConsulta()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<CapturaConsultaViewModel>();
            this.dtgConsultas.ShowGroupDropArea = false;
        }

        #endregion

        #region Eventos
        private void BtnNuevaConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                btnNuevaConsulta.Enabled = false;
                Model.State = EntityState.Create;

                FrmOpcionesCuestionario _consulta = new FrmOpcionesCuestionario();
                _consulta.ShowDialog();
                _consulta.Dispose();

                CargarGridConsulta();

            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCapturaConsulta ~ BtnNuevaConsulta_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
            finally
            {
                btnNuevaConsulta.Enabled = true;
            }
        }
        private async void BuscarValor_TextChanged(object sender, EventArgs e)
        {
            await Model.llenarListaConsultas(BuscarValor.Text);
        }
        private void FrmCapturaConsulta_Shown(object sender, EventArgs e)
        {
            try
            {
                CIDWait.Show(async () =>
                {
                    await Model.llenarListaConsultas("");
                }, "Espere");
                this.IniciarBinding();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private async void BtnModificarConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                btnModificarConsulta.Enabled = false;
                Model.State = EntityState.Update;

                var item =  ObtenerSeleccionado();
                if (item != null)
                {
                    Model.IdConsulta = item.IdConsulta;
                    Model.IdUsuario = CurrentSession.IdCuentaUsuario; 
                    var result = await Model.ObtenerConsultaXId();

                    if (result != null)
                    {
                        FrmOpcionesCuestionario _CapturaConsulta = new FrmOpcionesCuestionario(result);
                        _CapturaConsulta.ShowDialog();
                        _CapturaConsulta.Dispose();

                        CargarGridConsulta();
                    }
                }
                else
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName,Messages.GridSelectMessage,TypeMessage.informacion);
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCapturaConsulta ~ BtnModificarConsulta_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
            finally
            {
                btnModificarConsulta.Enabled = true;
            }
        }
        #endregion

        #region Metodos
        private void IniciarBinding()
        {
            try
            {
                dtgConsultas.AutoGenerateColumns = false;
                dtgConsultas.DataBindings.Add("DataSource", Model, "_listaConsulta", true, DataSourceUpdateMode.OnPropertyChanged);

            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmCapturaConsulta ~ IniciarBinding()");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private async void CargarGridConsulta()
        {
            try
            {
                await Model.llenarListaConsultas("");
                this.dtgConsultas.DataSource = Model._listaConsulta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CapturaConsulta ObtenerSeleccionado()
        {
            try
            {
                if (dtgConsultas.SelectedItems.Count == 1)
                {
                    return (CapturaConsulta)dtgConsultas.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion      
    }
}
