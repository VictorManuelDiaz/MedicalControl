﻿using System;
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
    public partial class MDIAdminPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIAdminPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIAdminPrincipal_Load(object sender, EventArgs e)
        {
            Controls.OfType<MDIAdminPrincipal>().FirstOrDefault().BackColor = Color.White;
        }

        private void tlsMedicos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMedicos"] != null)
            {
                Application.OpenForms["frmMedicos"].Activate();
            }
            else
            {
                frmMedicos Medicos = new frmMedicos();
                Medicos.MdiParent = this;
                Medicos.Text = "Ventana " + childFormNumber++;
                Medicos.Show();
            }
            
        }

        private void tlsSalir_Click(object sender, EventArgs e)
        {
            frmInicioSesion InicioS = new frmInicioSesion();
            this.Hide();
            InicioS.ShowDialog();
            this.Close();
        }

        private void tlsCitas_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCita"] != null)
            {
                Application.OpenForms["frmCita"].Activate();
            }
            else
            {
                frmCita Cita = new frmCita();
                Cita.MdiParent = this;
                Cita.Show();
            }
            
        }

        private void tlsInicio_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void tlsExpedientes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmExpediente"] != null)
            {
                Application.OpenForms["frmExpediente"].Activate();
            }
            else
            {
                frmExpediente Cita = new frmExpediente();
                Cita.MdiParent = this;
                Cita.Show();
            }
        }

        private void tlsPacientes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmPacientes"] != null)
            {
                Application.OpenForms["frmPacientes"].Activate();
            }
            else
            {
                frmPacientes Paci = new frmPacientes();
                Paci.MdiParent = this;
                Paci.Show();
            }
            
        }

        private void tlsUsuarios_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCuentas"] != null)
            {
                Application.OpenForms["frmCuentas"].Activate();
            }
            else
            {
                frmCuentas Cuentas = new frmCuentas();
                Cuentas.MdiParent = this;
                Cuentas.Show();
            }
            
        }

        private void tlsEspecialidades_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmEspecialidad"] != null)
            {
                Application.OpenForms["frmEspecialidad"].Activate();
            }
            else
            {
                frmEspecialidad Especialidad = new frmEspecialidad();
                Especialidad.MdiParent = this;
                Especialidad.Show();
            }
            
        }

        private void picturebxCerrar_Click(object sender, EventArgs e)
        {
            Dispose(true);
            Application.Exit();
        }
    }
}
