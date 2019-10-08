using System;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CIDFares.Library.Controls.CIDMessageBox.Code;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIDFares.Library.Code.Helpers;
using CIDFares.Library.Code.Extensions;
using CIDFares.Spa.WFApplication.Constants;
using CIDFares.Spa.WFApplication.Session;
using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using CIDFares.Spa.Business.ValueObjects;
using CIDFares.Library.Controls.CIDHorario.Design;
using CIDFares.Library.Controls.CIDHorario.Enums;
using CIDFares.Spa.Business.ViewModels.General;
using CIDFares.Library.Controls.CIDWait.Code;

namespace CIDFares.Spa.WFApplication.Forms.Catalogos
{
    public partial class FrmTurno : Form
    {
        public TurnoViewModel Model { get; set; }

        public TurnoPrincipalViewModel ModelP { get; set; }
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
        public FrmTurno(int IdTurno)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<TurnoViewModel>();
            ModelP = ServiceLocator.Instance.Resolve<TurnoPrincipalViewModel>();
            RbtnDosHorarios.Checked = true;
            horarioDesignV21.Configurar(DaysNumber.LuDo);
            if (IdTurno > 0)
            {
                Model.IdTurno = IdTurno;
                Model.State = EntityState.Update;
            }
            else
                Model.State = EntityState.Create;
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
                TBoxNombreTurno.DataBindings.Add("Text", Model, "NombreTurno", true, DataSourceUpdateMode.OnPropertyChanged);               
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

        public DataTable ObtenerTabla(List<TurnoDias> lista)
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla.Columns.Add("NombreDia", typeof(string));
                tabla.Columns.Add("HoraEntrada", typeof(string));
                tabla.Columns.Add("HoraSalida", typeof(string));
                foreach (var item in lista)
                {
                    tabla.Rows.Add(item.NombreDia, item.HoraEntrada, item.HoraSalida);
                }
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        private async void FrmTurno_Shown(object sender, EventArgs e)
        {
            try
            {
                if(Model.State == EntityState.Update)
                {
                    Turno turno = await Model.GetListaTurno(Model.IdTurno);
                    List<TurnoDias> lista = turno.DatosValor.ToList();
                    string hora = "";
                    foreach (var item in lista)
                    {
                        hora = "";
                        string nombre = item.NombreDia;
                        var Info = (from inf in lista
                                    where inf.NombreDia == nombre
                                    select inf).ToList();
                        if (Info.Count > 1)
                        {
                            foreach (var item2 in Info)
                            {
                                hora += item2.HoraEntrada + "\r\n   a\r\n" + item2.HoraSalida + "\r\n\r\n";
                                                                   
                            }   
                        }
                        else
                        {
                            hora = item.HoraEntrada + "\r\n   a\r\n" + item.HoraSalida + "\r\n\r\n";
                        }
                        horarioDesignV21.AgregarHora((DaysHour)GetNumDia(item.NombreDia), hora);
                        Model.ListaValores.Add(new TurnoDias
                        {
                            NombreDia = item.NombreDia,
                            HoraEntrada = item.HoraEntrada,
                            HoraSalida = item.HoraSalida
                        });
                    }
                }
                IniciarBinding();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int GetNumDia(string nombreDia)
        {
            int Value = 0;
            switch (nombreDia)
            {
                case "Lunes":
                    Value =  2;
                    break;
                case "Martes":
                    Value =  3;
                    break;
                case "Miercoles":
                    Value =  4;
                    break;
                case "Jueves":
                    Value =  5;
                    break;
                case "Viernes":
                    Value = 6;
                    break;
                case "Sabado":
                    Value = 7;
                    break;
                case "Domingo":
                    Value = 8;
                    break;
            }
            return Value;
        }

        private int ValidarDatos(int NumHorarios)
        {
            int validation = 0;
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
                        errorProvider1.SetError(PickerHoraSalida1, "LA DIFERENCIA MÍNIMA DEBE DE SER DE 1 HORAS");
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
                        errorProvider1.SetError(PickerHoraSalida1, "LA DIFERENCIA MÍNIMA DEBE DE SER DE 1 HORAS");
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
                        errorProvider1.SetError(PickerHoraSalida2, "LA DIFERENCIA MÍNIMA DEBE DE SER DE 1 HORAS");
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
                PickerHoraEntrada1.Value = DateTime.Parse("7:00");
                PickerHoraSalida1.Value = DateTime.Parse("7:00");
                PickerHoraEntrada2.Value = DateTime.Parse("7:00");
                PickerHoraSalida2.Value = DateTime.Parse("7:00");
            }
            else if (sizeList == 2) {
                RbtnDosHorarios.Checked = true;
                PickerHoraEntrada1.Value = Convert.ToDateTime(temp.ElementAt(0));
                PickerHoraSalida1.Value = Convert.ToDateTime(temp.ElementAt(1));
            }
            else if (sizeList == 4)
            {
                RbtnCuatroHorarios.Checked = true;
                PickerHoraEntrada1.Value = Convert.ToDateTime(temp.ElementAt(2));
                PickerHoraSalida1.Value = Convert.ToDateTime(temp.ElementAt(3));
                PickerHoraEntrada2.Value = Convert.ToDateTime(temp.ElementAt(0));
                PickerHoraSalida2.Value = Convert.ToDateTime(temp.ElementAt(1));
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

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = ObtenerTabla(Model.ListaValores.ToList());
                var resul = await Model.GuardarCambios(CurrentSession.IdCuentaUsuario, tabla);
                if (TBoxNombreTurno.Text == "")
                {
                    errorProvider1.SetError(TBoxNombreTurno, "INGRESE EL NOMBRE DEL TURNO");
                }
                else
                {
                    if (resul.IdTurno > 0)
                    {
                        CIDMessageBox.ShowAlert(Messages.SystemName, Messages.SuccessMessage, TypeMessage.correcto);
                        LimpiarPropiedades();
                        this.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void LimpiarPropiedades()
        {
            try
            {
                Model.IdTurno = 0;
                Model.NombreTurno = "";
                Model.ListaValores.Clear();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
