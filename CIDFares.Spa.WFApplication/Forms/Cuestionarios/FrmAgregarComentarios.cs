using CIDFares.Spa.Business.ViewModels.Catalogos;
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

namespace CIDFares.Spa.WFApplication.Forms.Cuestionarios
{
    public partial class FrmAgregarComentarios : Form
    {
        public OpcionesViewModel Model { get; set; }
        public FrmAgregarComentarios()
        {
            InitializeComponent();
            Model = ServiceLocator.Instance.Resolve<OpcionesViewModel>();
            IniciarBinding();
        }

        private void BtnGuardarComentario_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Model.comentarios))
                {           
                    CargarDatos();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    errorProvider1.SetError(Comentario, "EL CAMPO COMENTARIO NO DEBE ESTAR VACIO.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public ComentariosConsulta CargarDatos()
        {
            try
            {
                ComentariosConsulta _dato = new ComentariosConsulta();
                _dato.Comentario = Model.comentarios;
                _dato.Fecha = DateTime.Now;
                _dato.Nombre = CurrentSession.Nombres;
                _dato.IdUsuario = CurrentSession.IdCuentaUsuario;

                return _dato;
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
                Comentario.DataBindings.Add("Text",Model, "comentarios",true,DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
