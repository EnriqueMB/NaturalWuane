using CIDFares.Library.Code.Extensions;
using CIDFares.Spa.Business.ViewModels.Catalogos;
using CIDFares.Spa.CrossCutting.Services;
using CIDFares.Spa.DataAccess.Contracts.Entities;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    public partial class FrmContestarMedicion : Form
    {
        #region Propiedades
        public List<Medicion> _lstMedicion { get; set; }
        public ContestarMedicionViewModel Model { get; set; }
        public DataTable _tablaMedicion { get; set; }
        #endregion

        #region constructor
        public FrmContestarMedicion(List<Medicion> lstMedicion)
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<ContestarMedicionViewModel>();
            _lstMedicion = lstMedicion;
            Model._listaMedicion = lstMedicion;
            cargarMediciones();
        }
        #endregion

        #region Eventos
        private void BtnNuevaConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                var validationResults = Model.Validate();
                if (validationResults.IsValid)
                {
                    _tablaMedicion =  ObtenerTablaMediciones();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    DibujarErrores(validationResults);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Metodos
        private async Task cargarMediciones()
        {
            try
            {
                //foreach (var item in _lstMedicion)
                foreach (var item in Model._listaMedicion)
                {
                    TextBox txt = new TextBox();
                    txt.Text = item.Nombre.ToUpper();
                    txt.ReadOnly = true;
                    txt.Size = new Size(253, 26);
                    flowLayoutPanel1.Controls.Add(txt);
                    var index = Model._listaMedicion.IndexOf(item);
                    TextBox txtUnidad = new TextBox();
                    txtUnidad.Text = item.NombreUnidadMedida.ToUpper();
                    txtUnidad.ReadOnly = true;
                    txtUnidad.Size = new Size(110, 26);
                    flowLayoutPanel1.Controls.Add(txtUnidad);

                    if (item.NombreLista != "Es abierta")
                    {
                        try
                        {
                            ComboBox combo = new ComboBox();
                            combo.DataSource = await Model.llenarlistaValor(item.IdListaMedicion);
                            combo.DisplayMember = "Valor";
                            combo.ValueMember = "IdValorLista";
                            combo.Name = string.Format("_listaMedicion[{0}]Control", index);
                            combo.DataBindings.Add("SelectedValue", item, "IdValorSeleccionado", true, DataSourceUpdateMode.OnPropertyChanged);
                            combo.Size = new Size(200, 26);
                            flowLayoutPanel1.Controls.Add(combo);
                            combo.SelectedIndex = 0;
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }

                    }
                    else
                    {
                        TextBox txt2 = new TextBox();
                        txt2.Name = string.Format("_listaMedicion[{0}]Control", index);
                        txt2.DataBindings.Add("Text", item, "valor", true, DataSourceUpdateMode.OnPropertyChanged);
                        txt2.Size = new Size(200, 26);
                        flowLayoutPanel1.Controls.Add(txt2);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void DibujarErrores(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                var controlName = error.PropertyName + "Control";
                var aux = flowLayoutPanel1.Controls.Find(controlName, true);
                if (aux != null)
                {
                    errorProvider1.SetError(aux[0], error.ErrorMessage);
                }
            }
        }

        private DataTable ObtenerTablaMediciones()
        {
            try
            {
                DataTable TablaM = new DataTable();
                TablaM.Columns.Add("IdMedicion", typeof(int));
                TablaM.Columns.Add("Nombre", typeof(string));
                TablaM.Columns.Add("IdValorSeleccionado", typeof(int));
                TablaM.Columns.Add("Valor", typeof(string));
                foreach (var item in Model._listaMedicion)
                {
                    TablaM.Rows.Add(new object[] { item.IdMedicion, item.Nombre, item.IdValorSeleccionado, item.valor });
                }
                return TablaM;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
