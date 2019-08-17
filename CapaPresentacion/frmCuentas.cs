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
    public partial class frmCuentas : Form
    {
        LogicaNegocioCuentas LNCuentas = new LogicaNegocioCuentas();
        public frmCuentas()
        {
            InitializeComponent();
        }

        private void frmCuentas_Load(object sender, EventArgs e)
        {

            dataGridViewCuentas.DataSource = LNCuentas.ListarCuenta();
            dataGridViewCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblIdCuen.Visible = false;
            txtbxIdCuen.Visible = false;
            
        }


        private void txtbxBuscCuenta_OnTextChange(object sender, EventArgs e)
        {
            List<Cuenta> listaCuenta = LNCuentas.BuscarCuenta(txtbxBuscCuenta.text);
            dataGridViewCuentas.DataSource = listaCuenta;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigoCuenta = Convert.ToInt32(dataGridViewCuentas.CurrentRow.Cells["IdCuenta"].Value.ToString());
            try
            {
                if (LNCuentas.EliminarCuenta(codigoCuenta) > 0)
                {
                    MessageBox.Show("Eliminado con éxito");
                    dataGridViewCuentas.DataSource = LNCuentas.ListarCuenta();
                }
            }
            catch
            {
                MessageBox.Show("ERROR al eliminar cuenta");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtbxIdCuen.Visible = true;
            txtbxIdCuen.Enabled = false;
            lblIdCuen.Visible = true;
            txtbxNomCuen.Enabled = false;
            cmbbxTipo.Enabled = false;
            lblContra.Text = "Nueva contraseña";

            txtbxIdCuen.Text = dataGridViewCuentas.CurrentRow.Cells["IdCuenta"].Value.ToString();
            txtbxNomCuen.Text = dataGridViewCuentas.CurrentRow.Cells["NombreCuenta"].Value.ToString();
            cmbbxTipo.Text = dataGridViewCuentas.CurrentRow.Cells["TipoCuenta"].Value.ToString();

            btnRegistrar.Text = "Actualizar";
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (btnRegistrar.Text == "Registrar")
                {
                    Cuenta objetoCuenta = new Cuenta();
                    if (txtbxContra.Text == txtbxConf.Text)
                    {
                        objetoCuenta.NombreCuenta = txtbxNomCuen.Text;
                        objetoCuenta.Contrasena = txtbxContra.Text;
                        objetoCuenta.TipoCuenta = cmbbxTipo.Text;
                        if (LNCuentas.InsertarCuenta(objetoCuenta) > 0)
                        {
                            MessageBox.Show("Agregado con éxito");
                            dataGridViewCuentas.DataSource = LNCuentas.ListarCuenta();
                            txtbxNomCuen.Text = "";
                            txtbxContra.Text = "";
                            txtbxConf.Text = "";
                            cmbbxTipo.Text = "";

                        }
                        else { MessageBox.Show("Error al agregar Recurso"); }
                    }
                    else
                    {
                        lblFalloConf.Visible = true;
                    }
                }
                if (btnRegistrar.Text == "Actualizar")
                {

                    Cuenta objetoCuenta = new Cuenta();
                    if (txtbxContra.Text == txtbxConf.Text)
                    {
                        objetoCuenta.Contrasena = txtbxContra.Text;
                        if (LNCuentas.EditarCuenta(objetoCuenta) > 0)
                        {
                            MessageBox.Show("Actualizado con éxito");
                            dataGridViewCuentas.DataSource = LNCuentas.ListarCuenta();
                            txtbxNomCuen.Text = "";
                            txtbxContra.Text = "";
                            txtbxConf.Text = "";
                            cmbbxTipo.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar la cuenta");
                        }

                    }
                    else
                    {
                        lblFalloConf.Visible = true;
                    }
                    btnRegistrar.Text = "Registrar";
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }

        }
    }
}

