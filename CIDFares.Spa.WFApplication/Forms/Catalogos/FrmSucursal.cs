using CIDFares.Library.Controls.CIDWait.Code;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.General;
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
    public partial class FrmSucursal : Form
    {
        #region Propiedades
        public SucursalViewModel Model { get; set; }
        #endregion
        public FrmSucursal(int IdSucursal)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<SucursalViewModel>();
            if (IdSucursal > 0)
            {
                Model.IdSucursal = IdSucursal;
                Model.State = EntityState.Update;
            }
            else
                Model.State = EntityState.Create;
        }

        #region Metodos
        private void IniciarCombos(int combo)
        {
            try
            {
                switch (combo)
                {
                    case 1:
                        IdPaisControl.DisplayMember = "Nombre";
                        IdPaisControl.ValueMember = "IdPais";
                        break;
                    case 2:
                        IdMunicipioControl.DisplayMember = "Nombre";
                        IdMunicipioControl.ValueMember = "IdMunicipio";
                        break;
                    case 3:
                        IdEstadoControl.DisplayMember = "Nombre";
                        IdEstadoControl.ValueMember = "IdEstado";
                        break;
                    case 4:
                        IdTipoSucursalControl.DisplayMember = "Nombre";
                        IdTipoSucursalControl.ValueMember = "IdTipoSucursal";
                        break;
                }
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
                NombreControl.DataBindings.Add("Text", Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
                DireccionControl.DataBindings.Add("Text", Model, "Direccion", true, DataSourceUpdateMode.OnPropertyChanged);
                TelefonoControl.DataBindings.Add("Text", Model, "Telefono", true, DataSourceUpdateMode.OnPropertyChanged);
                CodigoPostalControl.DataBindings.Add("Text", Model, "CodigoPostal", true, DataSourceUpdateMode.OnPropertyChanged);
                RfcControl.DataBindings.Add("Text", Model, "Rfc", true, DataSourceUpdateMode.OnPropertyChanged);
                NombreRepresentanteControl.DataBindings.Add("Text", Model, "NombreRepresentante", true, DataSourceUpdateMode.OnPropertyChanged);
                RegimenFiscalControl.DataBindings.Add("Text", Model, "RegimenFiscal", true, DataSourceUpdateMode.OnPropertyChanged);

                IniciarCombos(1);
                IdPaisControl.DataBindings.Add("DataSource", Model, "ListaPais", true, DataSourceUpdateMode.OnPropertyChanged);
                IdPaisControl.DataBindings.Add("SelectedValue", Model, "IdPais", true, DataSourceUpdateMode.OnPropertyChanged);

                IniciarCombos(2);
                IdMunicipioControl.DataBindings.Add("DataSource", Model, "ListaMunicipios", true, DataSourceUpdateMode.OnPropertyChanged);
                IdMunicipioControl.DataBindings.Add("SelectedValue", Model, "IdMunicipio", true, DataSourceUpdateMode.OnPropertyChanged);

                IniciarCombos(3);
                IdEstadoControl.DataBindings.Add("DataSource", Model, "ListaEstados", true, DataSourceUpdateMode.OnPropertyChanged);
                IdEstadoControl.DataBindings.Add("SelectedValue", Model, "IdEstado", true, DataSourceUpdateMode.OnPropertyChanged);

                IniciarCombos(4);
                IdTipoSucursalControl.DataBindings.Add("DataSource", Model, "ListaTipoSucursal", true, DataSourceUpdateMode.OnPropertyChanged);
                IdTipoSucursalControl.DataBindings.Add("SelectedValue", Model, "IdTipoSucursal", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion

        private void FrmSucursal_Shown(object sender, EventArgs e)
        {
            try
            {
                Model.IdPais = 143;
                Model.IdEstado = 7;
                    CIDWait.Show(async () =>
                    {
                        var ListaTipoSucursal = await Model.GetListaTipoSucursal();
                        Model.LlenarListaTipoSucursal(ListaTipoSucursal);

                        var ListaPais = await Model.GetListaPaises();
                        Model.LlenarListaPaises(ListaPais);

                        var ListaEstado = await Model.GetListaEstados();
                        Model.LlenarListaEstado(ListaEstado);

                        var ListaMunicipio = await Model.GetListaMunicipios();
                        Model.LlenarListaMunicipios(ListaMunicipio);

                    }, "Espere");

                IniciarBinding();

                if(Model.State == EntityState.Update)
                {
                    CIDWait.Show(async () =>
                    {
                        await Model.GetSucursal();
                        lblSubtitle.Text = Model.Nombre;
                    }, "Cargando sucursal");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void IdPaisControl_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (IdPaisControl.DataBindings["SelectedValue"] != null)
                {
                    IdPaisControl.DataBindings["SelectedValue"].WriteValue();
                    var ListaEstados = await Model.GetListaEstados();
                    Model.LlenarListaEstado(ListaEstados);
                    Model.IdEstado = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void IdEstadoControl_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (IdEstadoControl.DataBindings["SelectedValue"] != null)
                {
                    IdEstadoControl.DataBindings["SelectedValue"].WriteValue();
                    var ListaMunicipios = await Model.GetListaMunicipios();
                    Model.LlenarListaMunicipios(ListaMunicipios);
                    Model.IdMunicipio = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
