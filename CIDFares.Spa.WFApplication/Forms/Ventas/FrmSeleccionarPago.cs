using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Ventas;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Ventas
{
    public partial class FrmSeleccionarPago : Form
    {
        public SeleccionarPagoViewModel Model { get; set; }
        public FrmSeleccionarPago()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<SeleccionarPagoViewModel>();
            GridFormaPago.Columns["Seleccionar"].AllowEditing = true;
            this.GridFormaPago.Style.HeaderStyle.Borders.Top = new GridBorder(GridBorderStyle.None);
            this.GridFormaPago.Style.HeaderStyle.Borders.Left = new GridBorder(GridBorderStyle.None);
            this.GridFormaPago.Style.HeaderStyle.Borders.Right = new GridBorder(GridBorderStyle.None);
            this.GridFormaPago.Style.CellStyle.Borders.All = new GridBorder(GridBorderStyle.None);
            this.EfectivoControl.Focus();
            IniciarBinding();
        }

        private void IniciarBinding()
        {
            try
            {
                this.GridFormaPago.AutoGenerateColumns = false;
                GridFormaPago.DataBindings.Add("DataSource", Model.ModelFormaPago, "ListaFormaPago", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlPagarWithFormaPago_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            //if(EfectivoControl.Text == "$0")
            //{
            //    EfectivoControl.Text = "$ ";
            //    EfectivoControl.ForeColor = Color.FromArgb(60, 186, 60);
            //}
        }

        private void EfectivoControl_Leave(object sender, EventArgs e)
        {
            //if (EfectivoControl.Text == "$" || EfectivoControl.Text == "")
            //{
            //    EfectivoControl.Text = "$0";
            //    EfectivoControl.ForeColor = Color.Silver;
            //}
        }

        private void FrmSeleccionarPago_Load(object sender, EventArgs e)
        {
            this.EfectivoControl.Focus();
        }

        

        
    }
}
