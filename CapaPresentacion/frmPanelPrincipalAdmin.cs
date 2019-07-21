using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPanelPrincipalAdmin : Form
    {
        public frmPanelPrincipalAdmin()
        {
            InitializeComponent();
        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedicos Registro = new frmMedicos();
            this.Hide();
            Registro.ShowDialog();
            this.Close();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void expedientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void tlsInicio_Click(object sender, EventArgs e)
        {
            
        }
    }
}
