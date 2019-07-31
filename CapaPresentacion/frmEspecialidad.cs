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
    }
}
