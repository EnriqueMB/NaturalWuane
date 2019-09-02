using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmServicioNuevo : Form
    {
        #region Propiedades Públicas
        public ServicioViewModel Model { get; set; }
        #endregion

        public FrmServicioNuevo()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ServicioViewModel>();
            IniciarBinding();
        }

        private void IniciarBinding()
        {
            try
            {                
                ClaveControl.DataBindings.Add("Text", Model, "Clave", true, DataSourceUpdateMode.OnPropertyChanged);
                NombreControl.DataBindings.Add("Text", Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
                PrecioControl.DataBindings.Add("Text", Model, "Precio", true, DataSourceUpdateMode.OnPropertyChanged);
                DuracionControl.DataBindings.Add("Text", Model, "Duracion", true, DataSourceUpdateMode.OnPropertyChanged);
                DescripcionControl.DataBindings.Add("Text", Model, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);                
                AplicaIEPS.DataBindings.Add("Checked", Model, "AplicaIEPS", true, DataSourceUpdateMode.OnPropertyChanged);
                IEPSMontoControl.DataBindings.Add("Checked", Model, "IEPSMonto", true, DataSourceUpdateMode.OnPropertyChanged);
                IEPSControl.DataBindings.Add("Text", Model, "IEPS", true, DataSourceUpdateMode.OnPropertyChanged);                

                IdTipoIvaControl.DataBindings.Add("SelectedValue", Model, "IdTipoIva", true, DataSourceUpdateMode.OnPropertyChanged);
                IdTipoIvaControl.DataBindings.Add("DataSource", Model, "ListaIva", true, DataSourceUpdateMode.OnPropertyChanged);
                IniciarCombito(0);

                IdTipoServicioControl.DataBindings.Add("SelectedValue", Model, "IdTipoServicio", true, DataSourceUpdateMode.OnPropertyChanged);
                IdTipoServicioControl.DataBindings.Add("DataSource", Model, "ListaTipoServicio", true, DataSourceUpdateMode.OnPropertyChanged);
                IniciarCombito(1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarCombito(int n)
        {
            try
            {
                if (n == 1)
                {
                    IdTipoServicioControl.DisplayMember = "TipoServicio";
                    IdTipoServicioControl.ValueMember = "IdTipoServicio";
                }                
                else
                {
                    IdTipoIvaControl.DisplayMember = "Porcentaje";
                    IdTipoIvaControl.ValueMember = "IdTipoIva";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void FrmServicioNuevo_Load(object sender, EventArgs e)
        {
            try
            {
                var z = await Model.GetListaTipoIva();
                Model.LlenarListaTI(z);
                var a = await Model.GetListaTipoServicio();
                Model.LlenarListaTServicio(a);
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}
