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
            dataGridViewEspecial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEspecial.DataSource = LNEsp.ListarEspecialidad();
        }

        private void txtbxBuscar_Click(object sender, EventArgs e)
        {
            List<Especialidad> listaEspe = LNEsp.BuscarEspecialidad(txtbxBuscar.text);
            dataGridViewEspecial.DataSource = listaEspe;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtbxIdEspe.Visible = true;
            txtbxIdEspe.Enabled = false;
            lblIdEspe.Visible = true;

            txtbxNombreEspe.Text = dataGridViewEspecial.CurrentRow.Cells["NombreEs"].Value.ToString();
            btnRegistrar.Text = "Actualizar";

        }
    }
}
