using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmInicioSesion : Form
    {
        LogicaNegocioCuentas LNCuen = new LogicaNegocioCuentas();
        LogicaNegocioUsuario LNUsu = new LogicaNegocioUsuario();
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            int IdCuenta = 0;
            try
            {
                if (LNCuen.ValidarCuenta(txtbxNomCuen.Text, txtbxContrasena.Text).Count > 0)
                {
                    IdCuenta = LNCuen.BuscarIdCuenta(txtbxNomCuen.Text);
                    ValidarUsuario(IdCuenta);
                }
                else
                {
                    txtbxNomCuen.Text = "";
                    txtbxContrasena.Text = "";
                    lblErrorSesion.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void txtbxContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnEntrar_Click(sender, e);
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

        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Está seguro que quiere cerrar la aplicación?",
                "Cerrar la Aplicación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return res;
        }

        private void ValidarUsuario(int IdCuenta)
        {
            MDIAdminPrincipal PrinAdmin = new MDIAdminPrincipal(LNCuen.ObtenerTipoUsuario(txtbxNomCuen.Text, txtbxContrasena.Text), LNUsu.ListarIdMedico(IdCuenta));
            this.Hide();
            PrinAdmin.ShowDialog();
            this.Close();
        }
    }
}
