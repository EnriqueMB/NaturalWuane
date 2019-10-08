using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Promociones;
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

namespace CIDFares.Spa.WFApplication.Forms.Promociones
{
    public partial class FrmPromocion : Form
    {
        public PromocionViewModel Model { get; set; }
        public FrmPromocion()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<PromocionViewModel>();
            this.IniciarBinding();
        }

        private void IniciarBinding()
        {
            try
            {
                this.SfGridPromocion.AutoGenerateColumns = false;
                SfGridPromocion.DataBindings.Add("DataSource", Model, "ListaPromocion", true, DataSourceUpdateMode.OnPropertyChanged);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        private void Agregar (string titulo, string promocion)
        {
           
        }
                
        private void panelPromocion_DoubleClick(object sender, EventArgs e)
        {
            //Console.WriteLine("The threshold was reached.");
        }

        private PromocionGeneral ObtenerSeleccionado()
        {
            try
            {
                if (SfGridPromocion.SelectedItems.Count == 1)
                {
                    return (PromocionGeneral)SfGridPromocion.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    FrmNuevaPromocion modificar = new FrmNuevaPromocion(item);
                    modificar.ShowDialog();
                    await Model.GetAllPromocionAsync();
                    this.SfGridPromocion.Refresh();
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {

                ErrorLogHelper.AddExcFileTxt(ex, "FrmPromocion ~ btnModificar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                //GetPanel(new FrmNuevaPromocion());
                FrmNuevaPromocion nuevo = new FrmNuevaPromocion();
                nuevo.ShowDialog();
                await Model.GetAllPromocionAsync();
                this.SfGridPromocion.Refresh();
            }
            catch (Exception ex)
            {

                ErrorLogHelper.AddExcFileTxt(ex, "FrmPromocion ~ btnNuevo_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
           
        }

        public void GetPanel(object Formhijo)
        {
            try
            {
                if (this.panelContenedor.Controls.Count > 0)
                {
                    this.panelContenedor.Controls.RemoveAt(0);
                }
                Form Fchild = Formhijo as Form;
                Fchild.TopLevel = false;
                Fchild.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(Fchild);
                this.panelContenedor.Tag = Fchild;
                Fchild.Dock = DockStyle.Fill;
                Fchild.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnNuevo_BackColorChanged(object sender, EventArgs e)
        {
            if (this.btnNuevo.ForeColor == Color.White)
                btnNuevo.ForeColor = Color.FromArgb(60, 186, 60);
            else
                this.btnNuevo.ForeColor = Color.White;
        }

        private void btnNuevo_MouseHover(object sender, EventArgs e)
        {
            //if (this.btnNuevo.ForeColor == Color.White)
            //    btnNuevo.ForeColor = Color.FromArgb(60, 186, 60);
            //else
            //    this.btnNuevo.ForeColor = Color.White;
        }

        private void btnNuevo_MouseMove(object sender, MouseEventArgs e)
        {
            //if (this.btnNuevo.ForeColor == Color.White)
            //    btnNuevo.ForeColor = Color.FromArgb(60, 186, 60);
            //else
            //    this.btnNuevo.ForeColor = Color.White;
        }

        private void btnNuevo_MouseLeave(object sender, EventArgs e)
        {
            //if (this.btnNuevo.ForeColor == Color.White)
            //    btnNuevo.ForeColor = Color.FromArgb(60, 186, 60);
            //else
            //    if (btnNuevo.ForeColor == Color.FromArgb(60, 186, 60))
            //    btnNuevo.ForeColor = Color.White;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {

                    if (CIDMessageBox.ShowAlertRequest(Messages.SystemName, Messages.ConfirmDeleteMessage) == DialogResult.OK)
                    {
                        Model.IdPromocion = item.IdPromocion;
                        var result = await Model.DeleteAsync(CurrentSession.IdCuentaUsuario);
                        if (result == 1)
                        {
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessDeleteMessage, TypeMessage.informacion);
                            await Model.GetAllPromocionAsync();
                            this.SfGridPromocion.Refresh();
                            //this.CleanErrors(errorProvider1, typeof(FormaPagoViewModel));

                        }
                        else
                            CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorDeleteMessage, TypeMessage.informacion);
                    }
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmPromocion ~ btnEliminar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }
    }
}
