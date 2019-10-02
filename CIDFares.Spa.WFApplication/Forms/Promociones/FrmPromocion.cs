﻿using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Promociones;
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
            Panel panelPromocion = new Panel();
            Label labelEncabezado = new Label();
            Label labelPromo = new Label();

            labelEncabezado.AutoEllipsis = true;
            labelEncabezado.BackColor = Color.Transparent;
            labelEncabezado.Font = new Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelEncabezado.ForeColor = Color.White;
            labelEncabezado.Size = new Size(197, 59);
            labelEncabezado.Text = titulo;
            labelEncabezado.TextAlign = ContentAlignment.MiddleCenter;
        
            labelPromo.BackColor = Color.Transparent;
            labelPromo.Font = new Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPromo.ForeColor = Color.White;
            labelPromo.Location = new Point(46, 74);
            labelPromo.Size = new Size(125, 44);
            labelPromo.TabIndex = 1;
            labelPromo.Text = promocion;
            labelPromo.TextAlign = ContentAlignment.MiddleCenter;

            panelPromocion.BackgroundImage = global::CIDFares.Spa.WFApplication.Properties.Resources.promocionNxN;
            panelPromocion.BackgroundImageLayout = ImageLayout.Stretch;
            panelPromocion.Controls.Add(labelPromo);
            panelPromocion.Controls.Add(labelEncabezado);
            panelPromocion.Location = new Point(3, 3);
            panelPromocion.Size = new Size(215, 242);
            panelPromocion.TabIndex = 2;
            panelPromocion.DoubleClick += new EventHandler(this.panelPromocion_DoubleClick);
            this.flowLayoutPanel1.Controls.Add(panelPromocion);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    FrmNuevaPromocion modificar = new FrmNuevaPromocion(item);
                    modificar.ShowDialog();
                    SfGridPromocion.Refresh();
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {

                ErrorLogHelper.AddExcFileTxt(ex, "FrmFormaPago ~ btnModificar_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //GetPanel(new FrmNuevaPromocion());
            FrmNuevaPromocion nuevo = new FrmNuevaPromocion();
            nuevo.ShowDialog();
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
    }
}
