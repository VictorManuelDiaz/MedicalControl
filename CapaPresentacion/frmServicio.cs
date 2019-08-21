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
    public partial class frmServicio : Form
    {
        LogicaNegocioServicios LNSer = new LogicaNegocioServicios();
        public frmServicio()
        {
            InitializeComponent();
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

        private void frmServicio_Load(object sender, EventArgs e)
        {
            txtbxIdSer.Visible = false;
            lblIdSer.Visible = false;
            dataGridViewServicio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewServicio.DataSource = LNSer.ListarServicio();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnRegistrar.Text == "Registrar")
                {

                    if (PreGuardarConfirmation() == System.Windows.Forms.DialogResult.Yes)
                    {
                        Servicios objetoServicio = new Servicios();
                        objetoServicio.NombreServicio = txtbxNombreSer.Text;
                        objetoServicio.CostoServicio = txtbxCosto.Text;

                        if (LNSer.InsertarServicio(objetoServicio) > 0)
                        {
                            MessageBox.Show("Agregado con éxito");
                            dataGridViewServicio.DataSource = LNSer.ListarServicio();
                            txtbxNombreSer.Text = "";
                            txtbxCosto.Text = "";


                        }
                        else { MessageBox.Show("Error al agregar especialidad"); }
                    }
                    else
                    {
                        txtbxNombreSer.Text = "";
                        txtbxCosto.Text = "";
                    }

                }
                if (btnRegistrar.Text == "Actualizar")
                {

                    if (PreEditarConfirmation() == System.Windows.Forms.DialogResult.Yes)
                    {
                        Servicios objetoServicio = new Servicios();
                        objetoServicio.NombreServicio = txtbxNombreSer.Text;
                        objetoServicio.CostoServicio = txtbxCosto.Text;


                        if (LNSer.EditarMedico(objetoServicio) > 0)
                        {
                            MessageBox.Show("Actualizado con éxito");
                            dataGridViewServicio.DataSource = LNSer.ListarServicio();
                            txtbxNombreSer.Text = "";
                            txtbxCosto.Text = "";
                            txtbxIdSer.Visible = false;
                            lblIdSer.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar especialidad");
                        }
                        btnRegistrar.Text = "Registrar";
                    }
                    else
                    {
                        txtbxNombreSer.Text = "";
                        txtbxCosto.Text = "";
                        txtbxIdSer.Visible = false;
                        lblIdSer.Visible = false;
                    }

                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void txtbxBuscar_OnTextChange(object sender, EventArgs e)
        {
            List<Servicios> listaSer = LNSer.BuscarServicio(txtbxBuscar.text);
            dataGridViewServicio.DataSource = listaSer;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtbxIdSer.Visible = true;
            txtbxIdSer.Enabled = false;
            lblIdSer.Visible = true;

            txtbxIdSer.Text = dataGridViewServicio.CurrentRow.Cells["IdServicios"].Value.ToString();
            txtbxNombreSer.Text = dataGridViewServicio.CurrentRow.Cells["NombreServicio"].Value.ToString();
            txtbxCosto.Text = dataGridViewServicio.CurrentRow.Cells["CostoServicio"].Value.ToString();
            btnRegistrar.Text = "Actualizar";
        }
    }
}
