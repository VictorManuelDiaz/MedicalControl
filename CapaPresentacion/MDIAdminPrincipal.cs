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
    public partial class MDIAdminPrincipal : Form
    {
        private int childFormNumber = 0;
        LogicaNegocioRespaldo LNRes = new LogicaNegocioRespaldo();
        LogicaNegocioUsuario LNUsu = new LogicaNegocioUsuario();
        private int IdMedico = 0;
        private string TipoUsuario = "";
        public MDIAdminPrincipal(string TipoUsuario, int IdMedico)
        {
            InitializeComponent();
            if (TipoUsuario == "Administrador")
            {
                tlsConsultas.Visible = false;
            }
            else if (TipoUsuario == "Estándar")
            {
                tlsMedicos.Visible = false;
                tlsConfiguraciones.Visible = false;
                tlsMantenimiento.Visible = false;
                tlsConsultas.Visible = true;
                this.TipoUsuario = TipoUsuario;
                this.IdMedico = IdMedico;
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
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
        }
        private void tlsSalir_Click(object sender, EventArgs e)
        {

            if (PreLogoutConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                frmInicioSesion InicioS = new frmInicioSesion();
                this.Hide();
                InicioS.ShowDialog();
                this.Close();
            }
        }

        private DialogResult PreLogoutConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Está seguro que quiere Cerrar sesión?",
                "Cerrar la Aplicación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return res;
        }


        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Está seguro que quiere cerrar la aplicación?",
                "Cerrar la Aplicación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return res;
        }

        
        
        private void tlsCitas_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Citas";
            if (Application.OpenForms["frmCita"] != null)
            {
                Application.OpenForms["frmCita"].Activate();
            }
            else
            {
                if (TipoUsuario == "Estándar")
                {
                    frmCita Cita = new frmCita(IdMedico);
                    Cita.MdiParent = this;
                    Cita.Show();
                }
                else
                {
                    frmCita Cita = new frmCita();
                    Cita.MdiParent = this;
                    Cita.Show();
                }

            }
        }

        

        private void tlsRespaldo_Click(object sender, EventArgs e)
        {
            string ateriorTitulo = lblTitulo.Text;
            lblTitulo.Text = "Respaldo Base de datos";
            try
            {
                if (LNRes.respaldarBD() > 0)
                {
                    MessageBox.Show("Respaldo realizado con éxito");
                    lblTitulo.Text = ateriorTitulo;
                }
            }
            catch
            {

                MessageBox.Show("Error al realizar el respaldo");
            }
        }

        private void picturebxCerrar_Click(object sender, EventArgs e)
        {
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
            }
        }

        private void tlsEspecialidades_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Especialidades";
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

        private void tlsConsultas_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Consultas";
            if (Application.OpenForms["frmConsultas"] != null)
            {
                Application.OpenForms["frmConsultas"].Activate();
            }
            else
            {
                frmConsultas Consultas = new frmConsultas(IdMedico);
                Consultas.MdiParent = this;
                Consultas.Show();
            }
        }

        private void tlsExpedientes_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Expedientes";
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

        private void tlsUsuarios_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Cuentas";
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

        private void tlsPacientes_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Pacientes";
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

        private void tlsInicio_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Medical control";
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void tlsMedicos_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Médicos";
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
    }
}
