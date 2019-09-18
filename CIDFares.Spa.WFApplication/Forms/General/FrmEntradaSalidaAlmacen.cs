using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Spa.CrossCutting.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.General
{
    public partial class FrmEntradaSalidaAlmacen : Form
    {
        #region propidesades publicas
        public EntradaSalidaAlmacenViewModel Model { get; set; }
        #endregion
        #region combo Tipo

        private class Tipo
        {
            public string Nombre { get; set; }
            public int Id { get; set; }
            public Tipo(string N, int I)
            {
                Nombre = N;
                Id = I;
            }
        }
        #endregion
        #region constructor
        public FrmEntradaSalidaAlmacen()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<EntradaSalidaAlmacenViewModel>();
        }
        #endregion

        #region Metodos
        public void IniciarCombos()
        {
            List<Tipo> ListaTipo = new List<Tipo>();
            ListaTipo.Add(new Tipo("SELECCIONE", 2));
            ListaTipo.Add(new Tipo("ENTRADA", 0));
            ListaTipo.Add(new Tipo("SALIDA", 1));

            TipoControl.DataSource = ListaTipo;

            TipoControl.DisplayMember = "Nombre";
            TipoControl.ValueMember = "Id";
        }

        public void IniciarBinding()
        {
            TipoControl.DataBindings.Add("SelectedValue", Model, "Tipo", true, DataSourceUpdateMode.OnPropertyChanged);
            FechaControl.DataBindings.Add("Text", Model, "Fecha", true, DataSourceUpdateMode.OnPropertyChanged);
            IniciarCombos();
        }
        #endregion
      
        private void pcMas_Click(object sender, EventArgs e)
        {
            FrmProductoEntradaSalida ES = new FrmProductoEntradaSalida();
            ES.ShowDialog();
        }

        private void FrmEntradaSalidaAlmacen_Load(object sender, EventArgs e)
        {
            IniciarBinding();
        }
    }
}
