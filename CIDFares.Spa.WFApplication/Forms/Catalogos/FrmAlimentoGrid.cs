using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Library.Controls.CIDWait.Code;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Session;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.Core.Utils;
using Syncfusion.Windows.Forms;
using CIDFares.Library.Code.Helpers;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmAlimentoGrid : Form
    {
        #region Propiedades Públicas
        /// <summary>
        /// Propiedad del Modelo AlimentoViewModels
        /// </summary>
        public AlimentoViewModels Model { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public FrmAlimentoGrid()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<AlimentoViewModels>();
            Model.Page = -1;
            Model.Opcion = 1;
        }
        #endregion

        #region Evento Shown
        /// <summary>
        /// Evento que se ejecuta despues del evento Load,
        /// encargado de cargar el grid e iniciar los Binding's
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAlimentoGrid_Shown(object sender, EventArgs e)
        {
            try
            {
                VerticalScrollBar x = (VerticalScrollBar)DGridAlimento.TableControl.VerticalScroll.ScrollBar;
                x.ValueChanged += X_ValueChanged;
                CargarGrid();
                IniciarBindig();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Inicializa las propiedades del Grid para bindiarse
        /// </summary>
        private void IniciarBindig()
        {
            try
            {
                this.DGridAlimento.AutoGenerateColumns = false;
                DGridAlimento.DataBindings.Add("DataSource", Model, "ListaAlimentos", true, DataSourceUpdateMode.OnPropertyChanged);
                BusquedaControl.DataBindings.Add("Text", Model, "Busqueda", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        /// <summary>
        /// Método que carga los siguientes 50 registros en el grid
        /// sin afectar a los que ya estan
        /// </summary>
        private void CargarGrid()
        {
            try
            {
                if (Model.Opcion == 1)
                        Model.Page++;
                CIDWait.Show(async () =>
                {
                    await Model.GetAllAsync();
                }, "Espere");
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
        /// <summary>
        /// Evento que detecta cada movimiento del Scroll Vertical del grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void X_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Syncfusion.WinForms.DataGrid.TableControl tableControl = DGridAlimento.TableControl;
                if (tableControl.VerticalScroll.Value + tableControl.VerticalScroll.LargeChange == tableControl.VerticalScroll.Maximum)
                {
                    if(!Model.PaginaMaxima)
                    {
                        Model.Opcion = 1;
                        CargarGrid();
                    }
                    else
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, "No hay mas registros", TypeMessage.informacion);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Obtiene el registro de la fila seleccionado
        /// </summary>
        /// <returns></returns>
        private Alimento ObtenerSeleccionado()
        {
            try
            {
                if (DGridAlimento.SelectedItems.Count == 1)
                {
                    return (Alimento)DGridAlimento.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Eventos de Botones
        /// <summary>
        /// Evento que abre el formulario de Nuevo Alimento con todos los
        /// campos vacios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                VerticalScrollBar x = (VerticalScrollBar)DGridAlimento.TableControl.VerticalScroll.ScrollBar;
                x.ValueChanged -= X_ValueChanged;
                FrmAlimentoNuevo nuevo = new FrmAlimentoNuevo(0);
                nuevo.ShowDialog();
                nuevo.Dispose();
                Model.Opcion = 2;
                CargarGrid();
                x.ValueChanged += X_ValueChanged;
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmAlimentoGrid ~ btnNuevo_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        /// <summary>
        /// Evento que habre el formulario de Nuevo Alimento con los campos
        /// del registro seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                VerticalScrollBar x = (VerticalScrollBar)DGridAlimento.TableControl.VerticalScroll.ScrollBar;
                x.ValueChanged -= X_ValueChanged;
                Alimento item = ObtenerSeleccionado();
                if(item != null)
                {
                    FrmAlimentoNuevo modificar = new FrmAlimentoNuevo(item.IdAlimento);
                    modificar.ShowDialog();
                    modificar.Dispose();
                    Model.Opcion = 2;
                    CargarGrid();
                    x.ValueChanged += X_ValueChanged;
                }
                else
                    CIDMessageBox.ShowAlert(Constants.Messages.SystemName, Constants.Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmAlimentoGrid ~ btnModificar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        /// <summary>
        /// Evento que ejecuta el método del ViewModels de alimentos para
        /// eliminar el registro seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                VerticalScrollBar x = (VerticalScrollBar)DGridAlimento.TableControl.VerticalScroll.ScrollBar;
                x.ValueChanged -= X_ValueChanged;
                Alimento item = ObtenerSeleccionado();
                if(item != null)
                {
                    if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmDeleteMessage) == DialogResult.OK)
                    {
                        Model.IdAlimento = item.IdAlimento;
                        var result = await Model.DeleteAsync(CurrentSession.IdCuentaUsuario);
                        if(result == 1)
                        {
                            CIDMessageBox.ShowAlert(Constants.Messages.SystemName, Constants.Messages.SuccessDeleteMessage, TypeMessage.correcto);
                            Model.Opcion = 2;
                            CargarGrid();
                            x.ValueChanged += X_ValueChanged;
                        }
                        else
                        {
                            CIDMessageBox.ShowAlert(Constants.Messages.SystemName, Constants.Messages.SuccessDeleteMessage, TypeMessage.correcto);
                        }
                    }
                }
                else
                    CIDMessageBox.ShowAlert(Constants.Messages.SystemName, Constants.Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmAlimentoGrid ~ btnEliminar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        /// <summary>
        /// Obtiene nuevamente los registros que ya se habian cargado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                VerticalScrollBar x = (VerticalScrollBar)DGridAlimento.TableControl.VerticalScroll.ScrollBar;
                x.ValueChanged -= X_ValueChanged;
                BusquedaControl.Text = String.Empty;
                Model.Opcion = 2;
                CargarGrid();
                x.ValueChanged += X_ValueChanged;
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmAlimentoGrid ~ btnLimpiarBusqueda_Clic(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }

        /// <summary>
        /// Evento clic que ejecuta el método del viewModels de alimentos
        /// para buscar los registros con el nombre que se le mande como 
        /// parametro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                error.Clear();
                if (!string.IsNullOrEmpty(Model.Busqueda))
                {
                    await Model.GetBusqueda(Model.Busqueda);
                    //sfDataGridCliente.DataBindings.Add("DataSource", Model, "ListaCliente", true, DataSourceUpdateMode.OnPropertyChanged);
                }
                else
                {
                    error.SetError(BusquedaControl, "INGRESE UNA BUSQUEDA.");
                }
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmAlimentoGrid ~ btnBusqueda_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorFormulario, TypeMessage.error);
            }
        }
        #endregion

    }
}
