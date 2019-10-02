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
                errorProvider1.Clear();
                if (RbtnDosHorarios.Checked)
                {
                    if (ValidarDatos(2) == 0)
                    {
                        if (existListValue())
                        {
                            string DiasComboBox = DiasControl.SelectedValue.ToString();
                            var Info = (from inf in Model.ListaValores
                                        where inf.NombreDia == DiasComboBox
                                        select inf).ToList();

                            Info.ForEach(inf => Model.ListaValores.Remove(inf));

                            Model.ListaValores.Add(new TurnoDias
                            {
                                NombreDia = DiasControl.SelectedValue.ToString(),
                                HoraEntrada = PickerHoraEntrada1.Value.TimeOfDay.ToString(),
                                HoraSalida = PickerHoraSalida1.Value.TimeOfDay.ToString()
                            });

                            string horario = PickerHoraEntrada1.Value.ToShortTimeString() + "\r\n   a\r\n" + PickerHoraSalida1.Value.ToShortTimeString();
                            horarioDesignV21.AgregarHora((DaysHour)DiasControl.SelectedValue, horario);
                        }
                        else
                        {
                            Model.ListaValores.Add(new TurnoDias
                            {
                                NombreDia = DiasControl.SelectedValue.ToString(),
                                HoraEntrada = PickerHoraEntrada1.Value.TimeOfDay.ToString(),
                                HoraSalida = PickerHoraSalida1.Value.TimeOfDay.ToString()
                            });

                            string horario = PickerHoraEntrada1.Value.ToShortTimeString() + "\r\n   a\r\n" + PickerHoraSalida1.Value.ToShortTimeString();
                            horarioDesignV21.AgregarHora((DaysHour)DiasControl.SelectedValue, horario);
                        } 
                    }
                }
                else if(RbtnCuatroHorarios.Checked)
                {
                    if (ValidarDatos(4) == 0)
                    {
                        if (existListValue())
                        {
                            string DiasComboBox = DiasControl.SelectedValue.ToString();
                            var Info = (from inf in Model.ListaValores
                                        where inf.NombreDia == DiasComboBox
                                        select inf).ToList();

                            Info.ForEach(inf => Model.ListaValores.Remove(inf));
                            Model.ListaValores.Add(new TurnoDias
                            {
                                NombreDia = DiasControl.SelectedValue.ToString(),
                                HoraEntrada = PickerHoraEntrada1.Value.TimeOfDay.ToString(),
                                HoraSalida = PickerHoraSalida1.Value.TimeOfDay.ToString()
                            });

                            Model.ListaValores.Add(new TurnoDias
                            {
                                NombreDia = DiasControl.SelectedValue.ToString(),
                                HoraEntrada = PickerHoraEntrada2.Value.TimeOfDay.ToString(),
                                HoraSalida = PickerHoraSalida2.Value.TimeOfDay.ToString()
                            });

                            string horario = PickerHoraEntrada1.Value.ToShortTimeString() + "\r\n   a\r\n" + PickerHoraSalida1.Value.ToShortTimeString()
                                                    + "\r\n\r\n" + PickerHoraEntrada2.Value.ToShortTimeString() + "\r\n   a\r\n" + PickerHoraSalida2.Value.ToShortTimeString();
                            horarioDesignV21.AgregarHora((DaysHour)DiasControl.SelectedValue, horario);
                        }
                        else
                        {
                            Model.ListaValores.Add(new TurnoDias
                            {
                                NombreDia = DiasControl.SelectedValue.ToString(),
                                HoraEntrada = PickerHoraEntrada1.Value.TimeOfDay.ToString(),
                                HoraSalida = PickerHoraSalida1.Value.TimeOfDay.ToString()
                            });

                            Model.ListaValores.Add(new TurnoDias
                            {
                                NombreDia = DiasControl.SelectedValue.ToString(),
                                HoraEntrada = PickerHoraEntrada2.Value.TimeOfDay.ToString(),
                                HoraSalida = PickerHoraSalida2.Value.TimeOfDay.ToString()
                            });

                            string horario = PickerHoraEntrada1.Value.ToShortTimeString() + "\r\n   a\r\n" + PickerHoraSalida1.Value.ToShortTimeString()
                                                    + "\r\n\r\n" + PickerHoraEntrada2.Value.ToShortTimeString() + "\r\n   a\r\n" + PickerHoraSalida2.Value.ToShortTimeString();
                            horarioDesignV21.AgregarHora((DaysHour)DiasControl.SelectedValue, horario);
                        }
                    }   
                }
                var list = Model.ListaValores;
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

        private int ValidarDatos(int NumHorarios)
        {
            int validation = 0;
            if(TBoxNombreTurno.Text == "")
            {
                errorProvider1.SetError(TBoxNombreTurno, "INGRESE EL NOMBRE DEL TURNO");
                validation++;
            }
            if(DiasControl.Text.ToString() == "SELECCIONE")
            {
                errorProvider1.SetError(DiasControl, "SELECCIONE UN DÍA");
                validation++;
            }
            switch (NumHorarios)
            {
                case 2:
                    if(PickerHoraEntrada1.Value > PickerHoraSalida1.Value)
                    {
                        validation++;
                    }
                    TimeSpan dife = PickerHoraSalida1.Value - PickerHoraEntrada1.Value;
                    int diferencia = Int32.Parse(dife.Hours.ToString());
                    if (diferencia < 1)
                    {
                        errorProvider1.SetError(PickerHoraSalida1, "LA DIFERENCIA MÍNIMA DEBE DE SER DE 2 HORAS");
                        validation++;
                    }
                    break;
                case 4:
                    if (PickerHoraEntrada1.Value > PickerHoraSalida1.Value)
                    {
                        validation++;
                    }
                    TimeSpan dife1 = PickerHoraSalida1.Value - PickerHoraEntrada1.Value;
                    int diferencia1 = Int32.Parse(dife1.Hours.ToString());
                    if (diferencia1 < 1)
                    {
                        errorProvider1.SetError(PickerHoraSalida1, "LA DIFERENCIA MÍNIMA DEBE DE SER DE 2 HORAS");
                        validation++;
                    }
                    if (PickerHoraEntrada2.Value < PickerHoraSalida1.Value)
                    {
                        validation++;
                    }
                    TimeSpan difeInter = PickerHoraEntrada2.Value - PickerHoraSalida1.Value;
                    int diferenciaInter = Int32.Parse(difeInter.TotalMinutes.ToString());
                    Console.WriteLine("Comida dife: {0}" + diferenciaInter);
                    if (diferenciaInter < 30)
                    {
                        errorProvider1.SetError(PickerHoraEntrada2, "LA DIFERENCIA MÍNIMA DEBE DE SER DE 30 MINUTOS");
                        validation++;
                    }
                    if (PickerHoraEntrada2.Value > PickerHoraSalida2.Value)
                    {
                        validation++;
                    }
                    TimeSpan dife2 = PickerHoraSalida2.Value - PickerHoraEntrada2.Value;
                    int diferencia2 = Int32.Parse(dife2.Hours.ToString());
                    if (diferencia2 < 1)
                    {
                        errorProvider1.SetError(PickerHoraSalida2, "LA DIFERENCIA MÍNIMA DEBE DE SER DE 2 HORAS");
                        validation++;
                    }
                    if(PickerHoraEntrada1.Value > PickerHoraSalida1.Value || 
                       PickerHoraSalida1.Value > PickerHoraEntrada2.Value || 
                       PickerHoraEntrada2.Value > PickerHoraSalida2.Value)
                    {
                        validation++;
                    }
                    break;
            }
            return validation;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CIDMessageBox.ShowAlertRequest(Constants.Messages.SystemName, Constants.Messages.ConfirmCancelInput) == DialogResult.OK)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void DiasControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DiasComboBox = DiasControl.SelectedValue.ToString();
            var Info = (from inf in Model.ListaValores
                        where inf.NombreDia == DiasComboBox
                        select inf).ToList();

            List<string> temp = new List<string>(); 
            foreach (var num in Info)
            {
                temp.Add(num.HoraEntrada);
                temp.Add(num.HoraSalida);
            }
            int sizeList = temp.Count;
            if(sizeList == 0)
            {
                RbtnDosHorarios.Checked = true;
                PickerHoraEntrada1.Value = DateTimePicker.MinimumDateTime;
                PickerHoraSalida1.Value = DateTimePicker.MinimumDateTime;
                PickerHoraEntrada2.Value = DateTimePicker.MinimumDateTime;
                PickerHoraSalida2.Value = DateTimePicker.MinimumDateTime;
            }
            else if (sizeList == 2) {
                RbtnDosHorarios.Checked = true;
                PickerHoraEntrada1.Value = Convert.ToDateTime(temp.ElementAt(0));
                PickerHoraSalida1.Value = Convert.ToDateTime(temp.ElementAt(1));
            }
            else if (sizeList == 4)
            {
                RbtnCuatroHorarios.Checked = true;
                PickerHoraEntrada1.Value = Convert.ToDateTime(temp[2]);
                PickerHoraSalida1.Value = Convert.ToDateTime(temp[3]);
                PickerHoraEntrada2.Value = Convert.ToDateTime(temp[0]);
                PickerHoraSalida2.Value = Convert.ToDateTime(temp[1]);
            }
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            string DiasComboBox = DiasControl.SelectedValue.ToString();
            var Info = (from inf in Model.ListaValores
                        where inf.NombreDia == DiasComboBox
                        select inf).ToList();

            Info.ForEach(inf => Model.ListaValores.Remove(inf));

            horarioDesignV21.EliminarHora((DaysHour)DiasControl.SelectedValue);
            //horarioDesignV21.AgregarHora((DaysHour)DiasControl.SelectedValue, horario);
        }

        private bool existListValue()
        {
            string DiasComboBox = DiasControl.SelectedValue.ToString();
            var Info = (from inf in Model.ListaValores
                        where inf.NombreDia == DiasComboBox
                        select inf).ToList();
            if (Info.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }
    }
}
