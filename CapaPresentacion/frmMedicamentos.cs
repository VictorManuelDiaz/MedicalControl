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
    public partial class frmMedicamentos : Form
    {
        LogicaNegocioMedicamentos LNMedica = new LogicaNegocioMedicamentos();
        public frmMedicamentos()
        {
            InitializeComponent();
        }

        private void frmMedicamentos_Load(object sender, EventArgs e)
        {
            dataGridViewMedica.DataSource = LNMedica.listarMedicamentos();
            dataGridViewMedica.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtbxBuscar_OnTextChange(object sender, EventArgs e)
        {
            List<Medicamento> listaMedica=LNMedica.buscarMedicamento(txtbxBuscar.text);
            dataGridViewMedica.DataSource = listaMedica;
        }
    }
}
