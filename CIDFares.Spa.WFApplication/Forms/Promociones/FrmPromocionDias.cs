using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ViewModels.Promociones;
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
    public partial class FrmPromocionDias : Form
    {
        public PromocionViewModel Model { get; set; }
        public int Resultado { get; set; }
        public FrmPromocionDias(PromocionViewModel model)
        {
            InitializeComponent();
            this.Model = model;
            this.IniciarBinding();
        }

        private void IniciarBinding()
        {
            try
            {
                LimiteControl.DataBindings.Add("Text", Model, "Limite", true, DataSourceUpdateMode.OnPropertyChanged);
                rbPeriodo.DataBindings.Add("Checked", Model, "EsPeriodo", true, DataSourceUpdateMode.OnPropertyChanged);
                FechaInicioControl.DataBindings.Add("Text", Model, "FechaInicio", true, DataSourceUpdateMode.OnPropertyChanged);
                FechaFinControl.DataBindings.Add("Text", Model, "FechaFin", true, DataSourceUpdateMode.OnPropertyChanged);
                Lunes.DataBindings.Add("Checked", Model, "Lunes", true, DataSourceUpdateMode.OnPropertyChanged);
                Martes.DataBindings.Add("Checked", Model, "Martes", true, DataSourceUpdateMode.OnPropertyChanged);
                Miercoles.DataBindings.Add("Checked", Model, "Miercoles", true, DataSourceUpdateMode.OnPropertyChanged);
                Jueves.DataBindings.Add("Checked", Model, "Jueves", true, DataSourceUpdateMode.OnPropertyChanged);
                Viernes.DataBindings.Add("Checked", Model, "Viernes", true, DataSourceUpdateMode.OnPropertyChanged);
                Sabado.DataBindings.Add("Checked", Model, "Sabado", true, DataSourceUpdateMode.OnPropertyChanged);
                Domingo.DataBindings.Add("Checked", Model, "Domingo", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPeriodo.Checked)
            {
                Model.EsPeriodo = true;
                panelPeriodo.Visible = true;
                panelDias.Visible = false;
            }
            else if (rbDias.Checked)
            {
                Model.EsPeriodo =false;
                panelPeriodo.Visible = false;
                panelDias.Visible = true;
            }
        }

        private async void FrmPromocionDias_Load(object sender, EventArgs e)
        {
            try
            {
                if (Model.IdPromocion != Guid.Empty)
                {
                    await Model.GetDiasAsync();
                    if (Model.EsPeriodo)
                    {
                        rbPeriodo.Checked = true;
                        panelPeriodo.Visible = true;
                        panelDias.Visible = false;
                    }
                    else
                    {
                        rbDias.Checked = true;
                        panelPeriodo.Visible = false;
                        panelDias.Visible = true;
                    }
                }
                else
                {
                    rbPeriodo.Checked = true;
                    Model.FechaInicio = DateTime.Now;
                    Model.FechaInicio = DateTime.Now.AddMonths(1);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private async void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int resultado = 0;

                if (Model.IdTipoPromocion == 1)
                {
                    PromocionDescuento promocionDescuento = await Model.GuardarPromocionDescuento(CurrentSession.IdCuentaUsuario);
                    resultado = promocionDescuento.Promocion.Resultado;
                }
                else if (Model.IdTipoPromocion == 2)
                {
                    PromocionNxN promocionNxN = await Model.GuardarPromocionNxN(CurrentSession.IdCuentaUsuario);
                    resultado = promocionNxN.Promocion.Resultado; 
                }
                else if (Model.IdTipoPromocion == 3)
                {
                    PromocionMxN promocionMxN = await Model.GuardarPromocionMxN(CurrentSession.IdCuentaUsuario);
                    resultado = promocionMxN.Promocion.Resultado;
                }

                if (resultado == 1)
                {
                    CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                    this.Close();
                    Resultado = 1;
                }
                else
                    CIDMessageBox.ShowAlert(Messages.ErrorMessage, "Desconocido", TypeMessage.error);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
