using System;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.WFApplication.Constants;
using System.Windows.Forms;
using CIDFares.Library.Controls.CIDWait.Code;
using System.Threading.Tasks;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmTurnoPrincipal : Form
    {
        public TurnoViewModel Model { get; set; }

        public FrmTurnoPrincipal()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                BtnNuevo.Enabled = false;
                FrmTurno Turno = new FrmTurno();
                Turno.ShowDialog();
                Model.State = EntityState.Create;
                CargarDatosAsync();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmEmpleadoGrid ~ BtnNuevo_Click(object sender, EventArgs e)");
                CIDMessageBox.ShowAlert(Messages.SystemName, Messages.ErrorMessage, TypeMessage.error);
            }
            finally
            {
                BtnNuevo.Enabled = true;
            }
        }

        private void CargarDatosAsync()
        {
            try
            {
                CIDWait.Show(async () =>
                {
                    await Model.CargarDatos();
                    await Task.Delay(2000);
                }, "Espere");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
