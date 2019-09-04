using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Ventas;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Session;
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
        public VentasViewModel Model { get; set; }
        public bool resultado { get; set; }
        public decimal TotalFormaPago;
        public FrmSeleccionarPago(VentasViewModel model)
        {
            InitializeComponent();
            Model = model;
            GridFormaPago.Columns["Seleccionar"].AllowEditing = true;
            this.GridFormaPago.Style.HeaderStyle.Borders.Top = new GridBorder(GridBorderStyle.None);
            this.GridFormaPago.Style.HeaderStyle.Borders.Left = new GridBorder(GridBorderStyle.None);
            this.GridFormaPago.Style.HeaderStyle.Borders.Right = new GridBorder(GridBorderStyle.None);
            this.GridFormaPago.Style.CellStyle.Borders.All = new GridBorder(GridBorderStyle.None);
            this.EfectivoControl.Focus();
            model.GetAllAsync(); 
            IniciarBinding();
        }

        private void IniciarBinding()
        {
            try
            {
                EfectivoControl.DataBindings.Add("Text", Model, "Efectivo", true, DataSourceUpdateMode.OnPropertyChanged);
                this.GridFormaPago.AutoGenerateColumns = false;
                GridFormaPago.DataBindings.Add("DataSource", Model, "ListaFormaPago", true, DataSourceUpdateMode.OnPropertyChanged);
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
            TotalControl.Text = Model.Total.ToString("C2");
        }

        private DataTable ObtenerDatosTabla(BindingList<FormaPago> Lista)
        {
            DataTable Tabla = new DataTable();
            Tabla.Columns.Add("IdFormaPago", typeof(int));
            Tabla.Columns.Add("Cantidad", typeof(decimal));
            foreach (var item in Lista)
            {
                if (item.Seleccionar == true && item.Cantidad > 0)
                {
                    Tabla.Rows.Add(new object[] { item.IdFormaPago, item.Cantidad});
                }
            }
            return Tabla;
        }

        private async void btnCobrar_Click(object sender, EventArgs e)
        {

            try
            {
                BindingList<FormaPago> ListaFormaPago = (BindingList<FormaPago>)GridFormaPago.DataSource;
                this.CleanErrors(errorProvider1, typeof(VentasViewModel));
                TotalVenta();
                if (ValidarPagos(ListaFormaPago))
                {
                    if (TotalFormaPago == Model.Total)
                    {

                        
                        decimal EfectivoIngresado = ObtenerEfectivo(ListaFormaPago);
                        if (Model.Efectivo >= EfectivoIngresado)
                        {
                            Model.TablaFormaPago = ObtenerDatosTabla(ListaFormaPago);
                            Venta Resultado = await Model.GuardarVenta(CurrentSession.IdCuentaUsuario, CurrentSession.IdSucursal);
                            if (Resultado.Resultado == 1)
                            {
                                pnlCambio.BringToFront();
                                CambioControl.Text = (Model.Efectivo - EfectivoIngresado).ToString("C2");
                                this.resultado = true;
                            }
                            else
                                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
                        }
                        else
                            errorProvider1.SetError(EfectivoControl, "Debe ingresar mas efectivo");
                    }
                    else
                        errorProvider1.SetError(ErrorControl, "La suma de las cantidades debe ser igua al total");
                }
                else
                errorProvider1.SetError(ErrorControl, "Agregue al menos una forma de pago");
            }
            catch (Exception)
            {

                throw;
            }

            
            //this.Close();
        }

        private bool ValidarPagos(BindingList<FormaPago> ListaFormaPago)
        {
            bool res;
            int i = 0;
            foreach (var item in ListaFormaPago)
            {
                if (item.Seleccionar == true)
                {
                    i++;
                    res = true;
                }
            }
            if (i == 0)
                res = false;
            else
                res = true;
            return res;
        }

        private decimal ObtenerEfectivo(BindingList<FormaPago> ListaFormaPago)
        {
            decimal EfectivoIngresado = 0;
            foreach (var item in ListaFormaPago)
            {
                if (item.Nombre == "Efectivo")
                {
                    EfectivoIngresado = item.Cantidad;
                }
            }
            return EfectivoIngresado;
        }
        
        private bool RequiereEfectivo(BindingList<FormaPago> ListaFormaPago)
        {
            
            foreach (var item in ListaFormaPago)
            {
                if (item.Nombre == "Efectivo" && item.Cantidad == 0)
                {
                    return false;
                }
            }
            return true;
        }


        private void pnlCambio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TotalControl_Click(object sender, EventArgs e)
        {

        }

        private void btnAceeptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridFormaPago_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void GridFormaPago_CurrentCellEndEdit(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventArgs e)
        {
            this.CleanErrors(errorProvider1, typeof(VentasViewModel));
            var x = Model.ListaFormaPago.Where(p => p.Cantidad > 0).Select(u => {
                u.Seleccionar = true; return u;
            }).ToList();
            if (x.Count > 0)
            {
                this.GridFormaPago.Refresh();
            }

            var y = Model.ListaFormaPago.Where(p => p.Cantidad <= 0).Select(u => {
                u.Seleccionar = false; return u;
            }).ToList();
            if (y.Count > 0)
            {
                this.GridFormaPago.Refresh();
            }
            
            BindingList<FormaPago> ListaFormaPago = (BindingList<FormaPago>)GridFormaPago.DataSource;
            if (RequiereEfectivo(ListaFormaPago))
                pnlEfectivo.Visible = true;
            else
                pnlEfectivo.Visible = false;


        }

        public void TotalVenta()
        {
            try
            {
                TotalFormaPago = Model.ListaFormaPago.Sum(x => x.Cantidad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GridFormaPago_CellCheckBoxClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellCheckBoxClickEventArgs e)
        {
        //    BindingList<FormaPago> ListaFormaPago = (BindingList<FormaPago>)GridFormaPago.DataSource;

        //    var z = Model.ListaFormaPago.Where(p => p.Seleccionar == false).Select(u => {
        //        u.Cantidad = 0; return u;
        //    }).ToList();
        //    if (z.Count > 0)
        //    {
        //        this.GridFormaPago.Refresh();
        //    }
            
        }
    }
}
