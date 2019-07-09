using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class frmMedicos : Form
    {
        LogicaNegocioMedico LNMedico = new LogicaNegocioMedico();
        LogicaNegocioEspecialidad LNEspe = new LogicaNegocioEspecialidad();
        public frmMedicos()
        {
            InitializeComponent();
            
            
            
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (btnRegistrar.Text == "Registrar")
                {
                    Medico objetoMedico = new Medico();
                    objetoMedico.NombreM = textBoxNombrer.Text;
                    objetoRecurso.codigo = textBoxCodigo.Text;
                    objetoRecurso.descripcion = textBoxDescripcion.Text;
                    if (logicaNR.InsertarRecursos(objetoRecurso) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewRecursos.DataSource = logicaNR.ListarRecursos();
                        textBoxNombrer.Text = "";
                        textBoxDescripcion.Text = "";
                        textBoxCodigo.Text = "";
                        tabRecursos.SelectedTab = tabPage2;
                    }
                    else { MessageBox.Show("Error al agregar Recurso"); }
                }
                if (buttonGuardar.Text == "Actualizar")
                {
                    Recursos objetoRecurso = new Recursos();
                    objetoRecurso.idrecursos = Convert.ToInt32(textBoxId.Text);
                    objetoRecurso.nombrer = textBoxNombrer.Text;
                    objetoRecurso.codigo = textBoxCodigo.Text;
                    objetoRecurso.descripcion = textBoxDescripcion.Text;
                    if (logicaNR.EditarRecursos(objetoRecurso) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewRecursos.DataSource = logicaNR.ListarRecursos();
                        textBoxNombrer.Text = "";
                        textBoxDescripcion.Text = "";
                        textBoxCodigo.Text = "";
                        tabRecursos.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Recurso");
                    }
                    buttonGuardar.Text = "Guardar";
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }*/
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            combobxEspe.Items.Add(LNEspe.ListarEspecialidad());
            dataGridViewMedico.DataSource = LNMedico.ListarMedico();
        }
    }
}
