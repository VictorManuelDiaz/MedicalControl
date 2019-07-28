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
        private void frmMedicos_Load(object sender, EventArgs e)
        {
            dataGridViewMedico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMedico.DataSource = LNMedico.listarMedico();
            txtbxIdMedico.Visible = false;
            lblIdMedico.Visible = false;
            List<int> Espe = new List<int>();
            Espe = LNEspe.ListarEspecialidad().Select(x => x.IdEspecialidad).ToList();
            combobxEspe.DataSource = Espe;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnRegistrar.Text == "Registrar")
                {
                    Medico objetoMedico = new Medico();
                    objetoMedico.NombreM = txtbxNombM.Text;
                    objetoMedico.ApellidoM = txtbxApellM.Text;
                    objetoMedico.IdEspecialidad = Convert.ToInt32(combobxEspe.Text);
                    objetoMedico.EmailM= txtbxCorreo.Text;
                    objetoMedico.TelefonoM = txtbxCel.Text;
                    objetoMedico.CedulaM = txtbxCed.Text;
                    if (combobxSexo.Text=="Femenino")
                    {
                        objetoMedico.SexoM = "F";
                    }
                    else
                    {
                        objetoMedico.SexoM = "M";
                    }
                    objetoMedico.DireccionM = txtbxDirec.Text;

                    if (LNMedico.insertarMedico(objetoMedico) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewMedico.DataSource = LNMedico.listarMedico();
                        txtbxNombM.Text = "";
                        txtbxApellM.Text = "";
                        txtbxCorreo.Text = "";
                        txtbxCel.Text = "";
                        txtbxCed.Text = "";
                        txtbxDirec.Text = "";
                        tabMedico.SelectedTab = tabPage2;
                    }
                    else { MessageBox.Show("Error al agregar Recurso"); }
                }
                if (btnRegistrar.Text == "Actualizar")
                {
                    Medico objetoMedico = new Medico();
                    objetoMedico.NombreM = txtbxNombM.Text;
                    objetoMedico.ApellidoM = txtbxApellM.Text;
                    objetoMedico.IdEspecialidad = Convert.ToInt32(combobxEspe.Text);
                    objetoMedico.EmailM = txtbxCorreo.Text;
                    objetoMedico.TelefonoM = txtbxCel.Text;
                    objetoMedico.CedulaM = txtbxCed.Text;
                    objetoMedico.SexoM = combobxSexo.Text;
                    objetoMedico.DireccionM = txtbxDirec.Text;

                    if (LNMedico.editarMedico(objetoMedico) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewMedico.DataSource = LNMedico.listarMedico();
                        dataGridViewMedico.DataSource = LNMedico.listarMedico();
                        txtbxNombM.Text = "";
                        txtbxApellM.Text = "";
                        txtbxCorreo.Text = "";
                        txtbxCel.Text = "";
                        txtbxCed.Text = "";
                        txtbxDirec.Text = "";
                        tabMedico.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Recurso");
                    }
                    btnRegistrar.Text = "Registrar";
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtbxIdMedico.Visible = true;
            txtbxIdMedico.Enabled = true;
            lblIdMedico.Visible = true;

            txtbxIdMedico.Text = dataGridViewMedico.CurrentRow.Cells["IdMedico"].Value.ToString();
            txtbxNombM.Text = dataGridViewMedico.CurrentRow.Cells["NombreM"].Value.ToString();
            txtbxApellM.Text = dataGridViewMedico.CurrentRow.Cells["ApellidoM"].Value.ToString();
            combobxEspe.SelectedItem = dataGridViewMedico.CurrentRow.Cells["IdEspecialidad"].Value;
            txtbxCorreo.Text = dataGridViewMedico.CurrentRow.Cells["EmailM"].Value.ToString();
            txtbxCel.Text = dataGridViewMedico.CurrentRow.Cells["TelefonoM"].Value.ToString();
            txtbxCed.Text = dataGridViewMedico.CurrentRow.Cells["CedulaM"].Value.ToString();
            combobxSexo.SelectedItem = dataGridViewMedico.CurrentRow.Cells["SexoM"].Value;
            txtbxDirec.Text = dataGridViewMedico.CurrentRow.Cells["DireccionM"].Value.ToString();
            tabMedico.SelectedTab = tabPage1;
            btnRegistrar.Text = "Actualizar";
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            int codigoM = Convert.ToInt32(dataGridViewMedico.CurrentRow.Cells["IdMedico"].Value.ToString());
            try
            {
                if (LNMedico.eliminarMedico(codigoM) > 0)
                {
                    MessageBox.Show("Eliminado con éxito");
                    dataGridViewMedico.DataSource = LNMedico.listarMedico();
                }
            }
            catch
            {
                MessageBox.Show("ERROR al eliminar Medico");
            }
        }
    }
}
