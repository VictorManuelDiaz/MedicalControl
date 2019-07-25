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
    public partial class frmCita : Form
    {
        LogicaNegocioCita LNCita = new LogicaNegocioCita();
        public frmCita()
        {
            InitializeComponent();
        }

        private void frmCita_Load(object sender, EventArgs e)
        {
            dataGridViewCita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCita.DataSource = LNCita.ListarCita();
        }
    }
}
