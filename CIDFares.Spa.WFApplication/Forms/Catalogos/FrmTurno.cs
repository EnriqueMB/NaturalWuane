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
using CIDFares.Library.Controls.CIDHorario.Design;
using CIDFares.Library.Controls.CIDHorario.Enums;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmTurno : Form
    {
        public TurnoViewModel Model { get; set; }
        #region Propiedades privadas
        private class Dias
        {
            public string NombreDia { get; set; }
            public DaysHour IdDia { get; set; }
            public Dias(string N, DaysHour I)
            {
                NombreDia = N;
                IdDia = I;
            }
        }
        #endregion
        public FrmTurno()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<TurnoViewModel>();
            RbtnDosHorarios.Checked = true;
            horarioDesignV21.Configurar(DaysNumber.LuDo);
         }

        private void IniciarComboDias()
        {
            try
            {
                List<Dias> ListaDias = new List<Dias>();
                ListaDias.Add(new Dias("SELECCIONE", DaysHour.Default));
                ListaDias.Add(new Dias("Lunes", DaysHour.Lunes));
                ListaDias.Add(new Dias("Martes", DaysHour.Martes));
                ListaDias.Add(new Dias("Miercoles", DaysHour.Miercoles));
                ListaDias.Add(new Dias("Jueves", DaysHour.Jueves));
                ListaDias.Add(new Dias("Viernes", DaysHour.Viernes));
                ListaDias.Add(new Dias("Sabado", DaysHour.Sabado));
                ListaDias.Add(new Dias("Domingo", DaysHour.Domingo));

                DiasControl.DataSource = ListaDias;

                DiasControl.DisplayMember = "NombreDia";
                DiasControl.ValueMember = "IdDia";
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
                IniciarComboDias();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void RbtnDosHorarios_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnDosHorarios.Checked == true)
            {
                PickerHoraEntrada2.Enabled = false;
                PickerHoraSalida2.Enabled = false;
                PickerHoraEntrada1.Enabled = true;
                PickerHoraSalida1.Enabled = true;
            }
        }

        private void RbtnCuatroHorarios_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnCuatroHorarios.Checked == true)
            {
                PickerHoraEntrada2.Enabled = true;
                PickerHoraSalida2.Enabled = true;
                PickerHoraEntrada1.Enabled = true;
                PickerHoraSalida1.Enabled = true;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (RbtnDosHorarios.Checked)
                {
                    Model.ListaTurno.Add(new TurnoDias
                    {
                        NombreDia = DiasControl.SelectedValue.ToString(),
                        HoraEntrada = PickerHoraEntrada1.Value.TimeOfDay.ToString(),
                        HoraSalida = PickerHoraSalida1.Value.TimeOfDay.ToString()
                    });

                    string horario = PickerHoraEntrada1.Value.ToShortTimeString()+ "\n\t   a\n\t" + PickerHoraSalida1.Value.ToShortTimeString();
                    horarioDesignV21.AgregarHora((DaysHour)DiasControl.SelectedValue, horario);
                }
                else if(RbtnCuatroHorarios.Checked)
                {
                    Model.ListaTurno.Add(new TurnoDias
                    {
                        NombreDia = DiasControl.SelectedValue.ToString(),
                        HoraEntrada = PickerHoraEntrada1.Value.TimeOfDay.ToString(),
                        HoraSalida = PickerHoraSalida1.Value.TimeOfDay.ToString()
                    });
                    Model.ListaTurno.Add(new TurnoDias
                    {              
                        NombreDia = DiasControl.SelectedValue.ToString(),
                        HoraEntrada = PickerHoraEntrada2.Value.TimeOfDay.ToString(),
                        HoraSalida = PickerHoraSalida2.Value.TimeOfDay.ToString()
                    });

                    string horario = PickerHoraEntrada1.Value.ToShortTimeString() + "\n\t   a\n\t" + PickerHoraSalida1.Value.ToShortTimeString()
                        +"\n\t\n\t"+ PickerHoraEntrada2.Value.ToShortTimeString() + "\n\t   a\n\t" + PickerHoraSalida2.Value.ToShortTimeString();
                    horarioDesignV21.AgregarHora((DaysHour)DiasControl.SelectedValue, horario);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FrmTurno_Shown(object sender, EventArgs e)
        {
            try
            {
                IniciarBinding();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
