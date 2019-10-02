using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Library.Controls.CIDWait.Code;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
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

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmSucursal : Form
    {
        #region Propiedades
        public SucursalViewModel Model { get; set; }
        #endregion
        public FrmSucursal(int? IdSucursal)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<SucursalViewModel>();
            if (IdSucursal > 0)
            {
                Model.IdSucursal = IdSucursal;
                Model.State = EntityState.Update;                
            }
            else
            {
                ListaHorario();
                Model.State = EntityState.Create;
                CargarHorarios();
            }               
        }

        public void ListaHorario()
        {
            Model.ListaHorario = new BindingList<HorarioSucursal>();
            Model.ListaHorario.Add(new HorarioSucursal {Nombre = "Lunes", Dia = 1, HoraEntrada = DateTime.Now, HoraSalida = DateTime.Now, Seleccionado = false });
            Model.ListaHorario.Add(new HorarioSucursal {Nombre = "Martes", Dia = 2, HoraEntrada = DateTime.Now, HoraSalida = DateTime.Now, Seleccionado = false });
            Model.ListaHorario.Add(new HorarioSucursal {Nombre = "Miercoles", Dia = 3, HoraEntrada = DateTime.Now, HoraSalida = DateTime.Now, Seleccionado = false });
            Model.ListaHorario.Add(new HorarioSucursal {Nombre = "Jueves", Dia = 4, HoraEntrada = DateTime.Now, HoraSalida = DateTime.Now, Seleccionado = false });
            Model.ListaHorario.Add(new HorarioSucursal {Nombre = "Viernes", Dia = 5, HoraEntrada = DateTime.Now, HoraSalida = DateTime.Now, Seleccionado = false });
            Model.ListaHorario.Add(new HorarioSucursal {Nombre = "Sabado", Dia = 6, HoraEntrada = DateTime.Now, HoraSalida = DateTime.Now, Seleccionado = false });
            Model.ListaHorario.Add(new HorarioSucursal {Nombre = "Domingo", Dia = 7, HoraEntrada = DateTime.Now, HoraSalida = DateTime.Now, Seleccionado = false });
        }

        #region Metodos
        private void IniciarCombos(int combo)
        {
            try
            {
                switch (combo)
                {
                    case 1:
                        IdPaisControl.DisplayMember = "Descripcion";
                        IdPaisControl.ValueMember = "IdPais";
                        break;
                    case 2:
                        IdMunicipioControl.DisplayMember = "Descripcion";
                        IdMunicipioControl.ValueMember = "IdMunicipio";
                        break;
                    case 3:
                        IdEstadoControl.DisplayMember = "Descripcion";
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
        private void LimpiarPropiedades()
        {
            try
            {
                Model.Nombre = string.Empty;
                Model.Direccion = string.Empty;
                Model.Telefono = string.Empty;
                Model.CodigoPostal = string.Empty;
                Model.NombreRepresentante = string.Empty;
                Model.RegimenFiscal = string.Empty;
                Model.Rfc = string.Empty;
                Model.IdTipoSucursal = 0;
                Model.IdPais = 0;
                Model.IdEstado = 0;
                Model.IdMunicipio = 0;
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
                LimpiarPropiedades();
                if (Model.State == EntityState.Update)
                {
                    CIDWait.Show(async () =>
                    {
                        await Model.GetSucursal();
                        lblSubtitle.Text = Model.Nombre;
                    }, "Cargando sucursal");
                    if (Model.ListaHorario.Count == 0)
                        ListaHorario();
                    CargarHorarios();
                }
                else
                {
                    Model.IdPais = 143;
                    Model.IdEstado = 7;
                    IdTipoSucursalControl.SelectedValue = 0;
                }

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
                    IdEstadoControl.SelectedValue = 0;
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
                    IdMunicipioControl.SelectedValue = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardar.Enabled = false;
                this.CleanErrors(errorProvider1, typeof(SucursalViewModel));
                var ValidationsResult = Model.Validate();
                if (ValidationsResult.IsValid)
                {
                    var resultado = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario);
                    if (resultado.Result > 0)
                    {
                        CIDMessageBox.ShowAlert(Constants.Messages.SystemName, Constants.Messages.SuccessMessage, TypeMessage.correcto);
                        Close();
                    }
                }
                else
                    this.ShowErrors(errorProvider1, typeof(SucursalViewModel), ValidationsResult);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (CIDMessageBox.ShowAlertRequest(Constants.Messages.SystemName, Constants.Messages.ConfirmCancelInput) == DialogResult.OK)
                Close();
        }

        private void NombreControl_TextChanged(object sender, EventArgs e)
        {
            NombreControl.Text = NombreControl.Text.Replace("  ", " ");
            NombreControl.Select(NombreControl.Text.Length, 0);
        }

        private void DireccionControl_TextChanged(object sender, EventArgs e)
        {
            DireccionControl.Text = DireccionControl.Text.Replace("  ", " ");
            DireccionControl.Select(DireccionControl.Text.Length, 0);
        }

        private void TelefonoControl_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TelefonoControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            else if (Char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void CodigoPostalControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            else if (Char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void RfcControl_TextChanged(object sender, EventArgs e)
        {
            RfcControl.Text = RfcControl.Text.Replace(" ", "");
            RfcControl.Select(RfcControl.Text.Length, 0);
        }

        private void NombreRepresentanteControl_TextChanged(object sender, EventArgs e)
        {
            NombreRepresentanteControl.Text = NombreRepresentanteControl.Text.Replace("  ", " ");
            NombreRepresentanteControl.Select(NombreRepresentanteControl.Text.Length, 0);
        }

        private void RegimenFiscalControl_TextChanged(object sender, EventArgs e)
        {
            RegimenFiscalControl.Text = RegimenFiscalControl.Text.Replace("  ", " ");
            RegimenFiscalControl.Select(RegimenFiscalControl.Text.Length, 0);
        }

        private void CargarHorarios()
        {
            try
            {
                foreach (var item in Model.ListaHorario)
                {
                    Label label = new Label();
                    label.Text = item.Nombre;
                    //checkDias.DataBindings.Add("Checked", item, "Seleccionado", true, DataSourceUpdateMode.OnPropertyChanged);
                    flowLayoutPanel1.Controls.Add(label);
                    DateTimePicker dateTimePicker = new DateTimePicker();
                    dateTimePicker.Size = new Size(120, 20);
                    dateTimePicker.Format = DateTimePickerFormat.Custom;
                    dateTimePicker.CustomFormat = "HH:mm:ss";
                    dateTimePicker.ShowUpDown = true;
                    dateTimePicker.Margin = new Padding(3, 3, 20, 3);
                    dateTimePicker.DataBindings.Add("Value", item, "HoraEntrada", true, DataSourceUpdateMode.OnPropertyChanged);
                    flowLayoutPanel1.Controls.Add(dateTimePicker);
                    DateTimePicker dateTimePicker1 = new DateTimePicker();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.Size = new Size(120, 20);
                    dateTimePicker1.CustomFormat = "HH:mm:ss";
                    dateTimePicker1.ShowUpDown = true;
                    dateTimePicker1.DataBindings.Add("Value", item, "HoraSalida", true, DataSourceUpdateMode.OnPropertyChanged);
                    flowLayoutPanel1.Controls.Add(dateTimePicker1);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
