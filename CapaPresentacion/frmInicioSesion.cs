﻿using System;
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

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (LNCuen.ValidarCuenta(txtbxNomCuen.Text, txtbxContrasena.Text).Count > 0)
                {
                    MDIAdminPrincipal PrinAdmin = new MDIAdminPrincipal();
                    this.Hide();
                    PrinAdmin.ShowDialog();
                    this.Close();
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
    }
}
