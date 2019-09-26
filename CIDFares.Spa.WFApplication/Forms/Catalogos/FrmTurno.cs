using System;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Code.Extensions;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Session;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.Business.ValueObjects;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmTurno : Form
    {
        public TurnoViewModel Model { get; set; }
        public FrmTurno()
        {
            InitializeComponent();
            RbtnDosHorarios.Checked = true;
         }

        private void IniciarBinding()
        {
            try
            {
                /*NombreTurnoTextBox.DataBindings.Add("Text", Model, "NombreTurno", true, DataSourceUpdateMode.OnPropertyChanged);
                HoraEntrada1TimePicker.DataBindings.Add("Value", Model, "HoraEntrada1", true, DataSourceUpdateMode.OnPropertyChanged);
                HoraSalida1TimePicker.DataBindings.Add("Value", Model, "HoraSalida1", true, DataSourceUpdateMode.OnPropertyChanged);
                HoraEntrada2TimePicker.DataBindings.Add("Value", Model, "HoraEntrada2", true, DataSourceUpdateMode.OnPropertyChanged);
                HoraSalida2TimePicker.DataBindings.Add("Value", Model, "HoraSalida2", true, DataSourceUpdateMode.OnPropertyChanged);
                LunesCkeckBox.DataBindings.Add("Checked", Model, "Lunes", true, DataSourceUpdateMode.OnPropertyChanged);
                MartesCkeckBox.DataBindings.Add("Checked", Model, "Martes", true, DataSourceUpdateMode.OnPropertyChanged);
                MiercolesCkeckBox.DataBindings.Add("Checked", Model, "Miercoles", true, DataSourceUpdateMode.OnPropertyChanged);
                JuevesCkeckBox.DataBindings.Add("Checked", Model, "Jueves", true, DataSourceUpdateMode.OnPropertyChanged);
                ViernesCkeckBox.DataBindings.Add("Checked", Model, "Viernes", true, DataSourceUpdateMode.OnPropertyChanged);
                SabadoCkeckBox.DataBindings.Add("Checked", Model, "Sabado", true, DataSourceUpdateMode.OnPropertyChanged);
                DomingoCkeckBox.DataBindings.Add("Checked", Model, "Domingo", true, DataSourceUpdateMode.OnPropertyChanged);*/
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void RbtnDosHorarios_CheckedChanged(object sender, EventArgs e)
        {
                PickerHoraEntrada2.Enabled = false;
                PickerHoraSalida2.Enabled = false;
        }

        private void RbtnCuatroHorarios_CheckedChanged(object sender, EventArgs e)
        {
            PickerHoraEntrada2.Enabled = true;
            PickerHoraSalida2.Enabled = true;
        }
    }
}
