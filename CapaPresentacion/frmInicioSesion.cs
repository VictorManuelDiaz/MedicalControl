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
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cuenta ObjetoCuenta = new Cuenta();
                if (LNCuen.BuscarCuenta(txtbxNomCuen.Text,txtbxContra.Text) ==null)
                {
                    frmPanelPrincipalAdmin PrinAdmin = new frmPanelPrincipalAdmin();
                    this.Hide();
                    PrinAdmin.ShowDialog();
                    this.Close();
                }
                else
                {
                    txtbxNomCuen.Text = "";
                    txtbxContra.Text = "";
                    lblErrorSesion.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }

            
        }
    }
}
