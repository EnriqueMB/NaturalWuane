using CIDFares.Spa.Business.ViewModels.Ventas;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
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
    public partial class FrmPaqueteVenta : Form
    {
        public VentasViewModel Model { get; set; }
        public bool resultado { get; set; }

        public FrmPaqueteVenta(VentasViewModel model)
        {
            InitializeComponent();
            this.Model = model;
            this.IniciarBinding();
        }

        private void IniciarBinding()
        {
            try
            {
                this.GridPaquete.AutoGenerateColumns = false;
                GridPaquete.DataBindings.Add("DataSource", Model, "ListaPaquete", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void RequiereEfectivo(BindingList<Paquetes> ListaFormaPago)
        {
            foreach (var item in ListaFormaPago)
            {
                Model.ListaPaquete.Clear();
                if (item.Seleccionar == false)
                {
                    var x = Model.ListaPaquete.Where(p => p.IdPaquete > item.IdPaquete).Select(u =>
                    {
                        u.Abono = u.PagoMinimo; return u;
                    }).ToList();
                    if (x.Count > 0)
                    {
                        this.GridPaquete.Refresh();
                    }
                }
                else
                {
                    var x = Model.ListaPaquete.Where(p => p.IdPaquete > item.IdPaquete).Select(u => {
                        u.Abono = u.MontoPaquete; return u;
                    }).ToList();
                    if (x.Count > 0)
                    {
                        this.GridPaquete.Refresh();
                    }
                }
            }
            
        }

        private DataTable ObtenerTablaPaquete(BindingList<Paquetes> Lista)
        {
            DataTable Tabla = new DataTable();
            Tabla.Columns.Add("IdPaquete", typeof(int));
            Tabla.Columns.Add("EsAbono", typeof(bool));
            Tabla.Columns.Add("Cantidad", typeof(decimal));
            Tabla.Columns.Add("Total", typeof(decimal));
            foreach (var item in Lista)
            {
                Tabla.Rows.Add(new object[] { item.IdPaquete, item.Seleccionar, item.CantidadServicio, item.Abono });
            }
            return Tabla;
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                BindingList<Paquetes> Lista = (BindingList<Paquetes>)GridPaquete.DataSource;
                //this.CleanErrors(errorProvider1, typeof(VentasViewModel));
                //var validationResults = Model.Validate();
                //validationResults.ToString();

                //if (validationResults.IsValid)
                //{
                    if (Lista.Count > 0)
                    {
                        Model.Total = Model.Total - TotalVenta();
                        Model.TablaPaquete = ObtenerTablaPaquete(Lista);
                            FrmSeleccionarPago pago = new FrmSeleccionarPago(Model);
                            pago.ShowDialog();
                            this.Close();
                            this.resultado = pago.resultado;
                    }
                    else
                        errorProvider1.SetError(btnCobrar, "Seleccione al menos un articulo.");
                //}
                //else
                //    this.ShowErrors(errorProvider1, typeof(VentasViewModel), validationResults);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public decimal TotalVenta()
        {
            try
            {
                decimal x = Model.ListaPaquete.Where(p => p.Seleccionar == false).Sum(u => u.Abono);
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GridPaquete_CurrentCellEndEdit(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventArgs e)
        {
            var x = Model.ListaPaquete.Where(p => p.Abono >= p.MontoPaquete).Select(u => {
                u.Seleccionar = true;
                u.Abono = u.MontoPaquete;
                u.PorPagar = u.MontoPaquete - u.Abono;
                return u;
            }).ToList();
            if (x.Count > 0)
            {
                this.GridPaquete.Refresh();
            }

            var y = Model.ListaPaquete.Where(p => p.Abono <= p.PagoMinimo).Select(u => {
                u.Seleccionar = false;
                u.Abono = u.PagoMinimo;
                u.PorPagar = u.MontoPaquete - u.Abono;
                return u;
            }).ToList();
            if (y.Count > 0)
            {
                this.GridPaquete.Refresh();
            }

            var z = Model.ListaPaquete.Where(p => p.Abono < p.MontoPaquete && p.Abono > p.PagoMinimo).Select(u => {
                u.Seleccionar = false;
                u.PorPagar = u.MontoPaquete - u.Abono;
                return u;
            }).ToList();
            if (z.Count > 0)
            {
                this.GridPaquete.Refresh();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
