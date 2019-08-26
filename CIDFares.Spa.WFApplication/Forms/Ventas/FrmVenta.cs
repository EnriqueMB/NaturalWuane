using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.WFApplication.Constants;
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
    public partial class FrmVenta : Form
    {
        List<ventax> lista;
        ventax venta;
        int prod = 0;
        decimal precioUnitario = 20;
        string noombreProd = "Shampoo ";
        string totals = "Cobrar $";
        public FrmVenta()
        {

            InitializeComponent();
            //this.sfDataGrid1.Style.HeaderStyle.Borders.All = new GridBorder(GridBorderStyle.None);
            //this.sfDataGrid1.Style.CellStyle.Borders.All = new GridBorder(GridBorderStyle.None);
            venta = new ventax();
            lista = new List<ventax>();
            venta.Nombre = noombreProd;
            venta.Precio = 20;
            venta.Cantidad = 1;
            venta.Total = venta.Precio * venta.Cantidad;
            lista.Add(venta);
            
            sfDataGrid1.DataSource = lista;
        }

        private void FrmVenta2_Load(object sender, EventArgs e)
        {

        }

        private void sfDataGrid1_Click(object sender, EventArgs e)
        {

        }

        private ventax ObtenerSeleccionado()
        {
            try
            {
                if (sfDataGrid1.SelectedItems.Count == 1)
                {
                    return (ventax)sfDataGrid1.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    prod++;
                    venta.Cantidad = prod++;
                    venta.Total = prod * precioUnitario;
                    venta.Precio = precioUnitario;
                    btnTotal.Text = totals + venta.Total.ToString();
                    sfDataGrid1.DataSource = lista;
                    sfDataGrid1.Refresh();
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
