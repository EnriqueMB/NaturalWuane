﻿using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Ventas;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Forms.Citas;
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
        public OrdenPaquete OrdenPaquete { get; set; }

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
                GridPaquete.DataBindings.Add("DataSource", Model, "ListaOrdenPaquete", true, DataSourceUpdateMode.OnPropertyChanged);
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

        private DataTable ObtenerTablaPaquete(BindingList<OrdenPaquete> Lista)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla.Columns.Add("IdOrdenPaquete", typeof(Guid));
                Tabla.Columns.Add("EsAbono", typeof(bool));
                Tabla.Columns.Add("Cantidad", typeof(decimal));
                Tabla.Columns.Add("Total", typeof(decimal));
                foreach (var item in Lista)
                {
                    Tabla.Rows.Add(new object[] { item.IdOrdenPaquete, item.Paquete.Seleccionar, item.Paquete.CantidadServicio, item.Paquete.Abono });
                }
                return Tabla;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                BindingList<OrdenPaquete> Lista = (BindingList<OrdenPaquete>)GridPaquete.DataSource;
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
                decimal x = Model.ListaOrdenPaquete.Where(p => p.Paquete.Seleccionar == false).Sum(u => u.Paquete.PorPagar);
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GridPaquete_CurrentCellEndEdit(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventArgs e)
        {
            var x = Model.ListaOrdenPaquete.Where(p => p.Paquete.Abono >= p.Paquete.MontoPaquete).Select(u => {
                u.Paquete.Seleccionar = true;
                u.Paquete.Abono = u.Paquete.MontoPaquete;
                u.Paquete.PorPagar = u.Paquete.MontoPaquete - u.Paquete.Abono;
                return u;
            }).ToList();
            if (x.Count > 0)
            {
                this.GridPaquete.Refresh();
            }

            var y = Model.ListaOrdenPaquete.Where(p => p.Paquete.Abono <= p.Paquete.PagoMinimo).Select(u => {
                u.Paquete.Seleccionar = false;
                u.Paquete.Abono = u.Paquete.PagoMinimo;
                u.Paquete.PorPagar = u.Paquete.MontoPaquete - u.Paquete.Abono;
                return u;
            }).ToList();
            if (y.Count > 0)
            {
                this.GridPaquete.Refresh();
            }

            var z = Model.ListaOrdenPaquete.Where(p => p.Paquete.Abono < p.Paquete.MontoPaquete && p.Paquete.Abono > p.Paquete.PagoMinimo).Select(u => {
                u.Paquete.Seleccionar = false;
                u.Paquete.PorPagar = u.Paquete.MontoPaquete - u.Paquete.Abono;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               

            }
            catch (Exception)
            {

                throw;
            }
        }

        private OrdenPaquete ObtenerSeleccionado()
        {
            try
            {
                if (GridPaquete.SelectedItems.Count == 1)
                {
                    return (OrdenPaquete)GridPaquete.SelectedItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                var item = ObtenerSeleccionado();
                if (item != null)
                {
                    if (item.IdOrdenPaquete == Guid.Empty)
                    {//this.CleanErrors(errorProvider1, typeof(FormaPagoViewModel));
                        Cliente c = new Cliente();
                        c.NombreCompleto = Model.NombreCompleto;
                        c.IdCliente = Model.IdCliente;
                        FrmCapturaCitaNuevo cita = new FrmCapturaCitaNuevo(DateTime.Now, item, c);
                        cita.ShowDialog();
                        Model.ListaOrdenPaquete.Remove(item);
                        Model.ListaOrdenPaquete.Add(cita.ordenPaquete);
                        OrdenPaquete = cita.ordenPaquete;
                        GridPaquete.Refresh();
                        ValidarPaquete();
                    }
                    else
                        CIDMessageBox.ShowAlert(Messages.SystemName,"El paquete ya esta agendado", TypeMessage.informacion);
                }
                else
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.GridSelectMessage, TypeMessage.informacion);

               
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ValidarPaquete()
        {
            try
            {
                var x = Model.ListaOrdenPaquete.Where(p => p.IdOrdenPaquete == Guid.Empty).Select(u => {
                    return u;
                }).ToList();
                if (x.Count == 0)
                {
                    btnCobrar.Enabled = true;
                    btnNuevo.Enabled = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmPaqueteVenta_Load(object sender, EventArgs e)
        {
            try
            {
                ValidarPaquete();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
