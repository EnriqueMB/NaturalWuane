using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Promociones;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.WFApplication.Forms.Ventas;
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
    public partial class FrmNuevaPromocion : Form
    {
        public PromocionViewModel Model { get; set; }
        private PromocionGeneral promocion;

        #region Constructor
        public FrmNuevaPromocion()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<PromocionViewModel>();
            promocion = new PromocionGeneral();
            this.IniciarBinding();
        }

        public FrmNuevaPromocion(PromocionGeneral item)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<PromocionViewModel>();
            this.promocion = item;
            this.IniciarBinding();
            Model.State = EntityState.Update;
            LlenarFormulario();
        }

        private void LlenarFormulario()
        {
            try
            {
                Model.IdTipoPromocion = promocion.TipoPromocion.IdTipoPromocion;
                Model.NombrePromocion = promocion.NombrePromocion;
                Model.Nombre = promocion.Nombre;
                Model.IdPromocion = promocion.IdPromocion;
                Model.Limite = promocion.Limite;
                Model.IdGenerico = promocion.IdGenerico;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Métodos
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

        private void IniciarBinding()
        {
            try
            {
                NombrePromocionControl.DataBindings.Add("Text", Model, "NombrePromocion", true, DataSourceUpdateMode.OnPropertyChanged);
                rbProducto.DataBindings.Add("checked", Model, "EsProducto", true, DataSourceUpdateMode.OnPropertyChanged);

                IniciarCombos();
                IdTipoPromocion.DataBindings.Add("SelectedValue", Model, "IdTipoPromocion", true, DataSourceUpdateMode.OnPropertyChanged);
                IdTipoPromocion.DataBindings.Add("DataSource", Model, "ListaTipoPromocion", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarCombos()
        {
            IdTipoPromocion.DisplayMember = "Nombre"; 
            IdTipoPromocion.ValueMember = "IdTipoPromocion";
        }

        #endregion

        #region Eventos
        private async void FrmNuevaPromocion_Load(object sender, EventArgs e)
        {
            try
            {
                var x = await Model.GetListaTipoPromocion();
                Model.LlenarTipoPromocion(x);
                if (promocion.IdPromocion != Guid.Empty)
                {
                    switch(Model.IdTipoPromocion)
                    {
                        case 1:
                            await Model.GetAsync();
                            break;
                        case 2:
                            await Model.GetNxNAsync();
                            break;
                        case 3:
                            await Model.GetMxNAsync();
                            break;
                        default:
                            GetPanel(new FrmSeleccione());
                            break;
                    }
                    


                    this.IdTipoPromocion.Enabled = false;
                    Model.IdTipoPromocion = promocion.TipoPromocion.IdTipoPromocion;
                    if (promocion.IdTipo == 1)
                        this.rbServicio.Checked = true;
                    else
                        this.rbProducto.Checked = true;
                }
                else
                {
                    GetPanel(new FrmSeleccione());
                    Model.EsProducto = true;
                    DescripcionControl.Text = "";
                    grbBuscarServProd.Enabled = false;
                    gbNombre.Enabled = false;
                    grServProd.Enabled = false;
                }
                
            }
            catch (Exception)
            {
                throw;
            }
         }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Model.EsProducto)
                {
                    FrmBusquedaProducto buscar = new FrmBusquedaProducto(1);
                    buscar.ShowDialog();
                    Model.IdGenerico = buscar.producto.IdProducto;
                    Model.Nombre = buscar.producto.Nombre;
                }
                else
                {
                    FrmBuscarServicio buscar = new FrmBuscarServicio();
                    buscar.ShowDialog();
                    Model.IdGenerico = buscar.servicio.IdServicio;
                    Model.Nombre = buscar.servicio.Nombre;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        private void IdTipoPromocion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TipoPromocion item =(TipoPromocion) IdTipoPromocion.SelectedItem;
                DescripcionControl.Text = item.descripcion;
                grbBuscarServProd.Enabled = true;
                grServProd.Enabled = true;
                gbNombre.Enabled = true;
                switch (item.IdTipoPromocion)
                {
                    case 0: DescripcionControl.Text = ""; GetPanel(new FrmSeleccione());
                        grbBuscarServProd.Enabled = false;
                        grServProd.Enabled = false;
                        break;
                    case 1: GetPanel(new FrmPromocionDescuento(Model));
                        break;
                    case 2: GetPanel(new FrmPromocionNxN(Model)); break;
                    case 3: GetPanel(new FrmPromocionMxN(Model)); break;
                    default: DescripcionControl.Text = "Error"; break ;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void rbProducto_CheckedChanged(object sender, EventArgs e)
        {

            if (rbProducto.Checked)
            {
                Model.EsProducto = true;
                grbBuscarServProd.Text = "Producto";
                button1.Text = "Buscar Producto";
                //Model.IdGenerico = 0;
                Model.Nombre = string.Empty;
            }
            else if(rbServicio.Checked)
            {
                Model.EsProducto = false;
                grbBuscarServProd.Text = "Servicio";
                button1.Text = "Buscar servicio";
                Model.Nombre = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panelContenedor.Controls.RemoveAt(0);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if(Model.Resultado == 1)
                {
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
