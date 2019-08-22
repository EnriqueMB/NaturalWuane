using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
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

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmProducto : Form
    {
        #region Propiedades Publicas


        public ProductoViewModel Model { get; set; }

        #endregion

        #region Propiedades Privadas

     

        private Producto infoModel { get; set; }

        #endregion
        #region Constructor

        public FrmProducto()
        {
            InitializeComponent();
            //lblSubtitle.Text = "NUEVO REGISTRO";
            Model = ServiceLocator.Instance.Resolve<ProductoViewModel>();

        }

        public FrmProducto(int IdProducto)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ProductoViewModel>();
            LimpiarPropiedades();
            Model.PDatos.IdProducto = IdProducto;
            Model.State = EntityState.Update;
        }
        #endregion

        private void LimpiarPropiedades()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
