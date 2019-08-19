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
    public partial class frmEspecialidad : Form
    {
        LogicaNegocioEspecialidad LNEsp = new LogicaNegocioEspecialidad();
        public frmEspecialidad()
        {
            InitializeComponent();
        }

        private void frmEspecialidad_Load(object sender, EventArgs e)
        {
            txtbxIdEspe.Visible = false;
            lblIdEspe.Visible = false;
            dataGridViewEspecial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEspecial.DataSource = LNEsp.ListarEspecialidad();
        }


        

        private void txtbxBuscar_OnTextChange(object sender, EventArgs e)
        {
            List<Especialidad> listaEspe = LNEsp.BuscarEspecialidad(txtbxBuscar.text);
            dataGridViewEspecial.DataSource = listaEspe;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnRegistrar.Text == "Registrar")
                {

                    if (PreGuardarConfirmation()== System.Windows.Forms.DialogResult.Yes)
                    {
                        Especialidad objetoEspecialidad = new Especialidad();
                        objetoEspecialidad.NombreEs = txtbxNombreEs.Text;



                        if (LNEsp.InsertarEspecialidad(objetoEspecialidad) > 0)
                        {
                            MessageBox.Show("Agregado con éxito");
                            dataGridViewEspecial.DataSource = LNEsp.ListarEspecialidad();
                            txtbxNombreEs.Text = "";


                        }
                        else { MessageBox.Show("Error al agregar especialidad"); }
                    }
                    else
                    {
                        txtbxNombreEs.Text = "";
                    }
                    
                }
                if (btnRegistrar.Text == "Actualizar")
                {

                    if (PreEditarConfirmation()==System.Windows.Forms.DialogResult.Yes)
                    {
                        Especialidad objetoMedico = new Especialidad();
                        objetoMedico.NombreEs = txtbxNombreEs.Text;


                        if (LNEsp.EditarEspecialidad(objetoMedico) > 0)
                        {
                            MessageBox.Show("Actualizado con éxito");
                            dataGridViewEspecial.DataSource = LNEsp.ListarEspecialidad();
                            txtbxNombreEs.Text = "";
                            txtbxIdEspe.Visible = false;
                            lblIdEspe.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar especialidad");
                        }
                        btnRegistrar.Text = "Registrar";
                    }
                    else
                    {
                        txtbxNombreEs.Text = "";
                        txtbxIdEspe.Visible = false;
                        lblIdEspe.Visible = false;
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtbxIdEspe.Visible = true;
            txtbxIdEspe.Enabled = false;
            lblIdEspe.Visible = true;

            txtbxIdEspe.Text = dataGridViewEspecial.CurrentRow.Cells["IdEspecialidad"].Value.ToString();
            txtbxNombreEs.Text = dataGridViewEspecial.CurrentRow.Cells["NombreEs"].Value.ToString();
            btnRegistrar.Text = "Actualizar";
        }


        private DialogResult PreGuardarConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Está seguro que quiere registrar esta especialidad?",
                "Cerrar la Aplicación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return res;
        }

        private DialogResult PreEliminarConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Está seguro que quiere eliminar esta especialidad?",
                "Cerrar la Aplicación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return res;
        }


        private DialogResult PreEditarConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Está seguro que quiere guardar los cambios realizados en especialidad?",
                "Cerrar la Aplicación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return res;
        }

    }
}
