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
        LogicaNegocioUsuario LNUsu = new LogicaNegocioUsuario();
        LogicaNegocioMedico LNMed = new LogicaNegocioMedico();
        public frmCuentas()
        {
            InitializeComponent();
        }

        private void frmCuentas_Load(object sender, EventArgs e)
        {

            dataGridViewCuentas.DataSource = LNCuentas.ListarCuenta();
            dataGridViewCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            List<string> Medico = new List<string>();
            Medico = LNMed.buscarMedicoCuenta().Select(x => x.NombreM + " " + x.ApellidoM).ToList();
            List<string> Cuenta = new List<string>();
            Cuenta = LNCuentas.ListarCuentaUsuario().Select(x => x.NombreCuenta).ToList();
            cmbbxMed.DataSource = Medico;
            cmbbxCuenta.DataSource = Cuenta;

            lblIdCuen.Visible = false;
            txtbxIdCuen.Visible = false;
            txtbxNomCuen.Enabled = true;
            cmbbxTipo.Enabled = true;

        }

       

        

        private void txtbxBuscCuenta_OnTextChange(object sender, EventArgs e)
        {
            List<Cuenta> listaCuenta = LNCuentas.BuscarCuenta(txtbxBuscCuenta.text);
            dataGridViewCuentas.DataSource = listaCuenta;
        }

       

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (PreEliminarConfirmation()==System.Windows.Forms.DialogResult.Yes)
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



        private DialogResult PreGuardarConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Seguro que quiere registrar esta cuenta?",
                "Registrar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return res;
        }

        private DialogResult PreEliminarConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Seguro que quiere eliminar esta cuenta?",
                "Eliminar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return res;
        }


        private DialogResult PreEditarConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Seguro que quiere actualizar esta cuenta?",
                "Actualizar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return res;
        }

        private DialogResult PreAsignarConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Seguro que quiere asignar esta cuenta?",
                "Asignar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return res;
        }



        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (btnRegistrar.Text == "Registrar")
                {
                    if (PreGuardarConfirmation()== System.Windows.Forms.DialogResult.Yes)
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
                                List<string> Cuenta = new List<string>();
                                Cuenta = LNCuentas.ListarCuentaUsuario().Select(x => x.NombreCuenta).ToList();
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
                    else
                    {
                        txtbxNomCuen.Text = "";
                        txtbxContra.Text = "";
                        txtbxConf.Text = "";
                        cmbbxTipo.Text = "";
                    }
                    
                }
                if (btnRegistrar.Text == "Actualizar")
                {
                    if (PreEditarConfirmation()== System.Windows.Forms.DialogResult.Yes)
                    {

                        Cuenta objetoCuenta = new Cuenta();
                        if (txtbxContra.Text == txtbxConf.Text)
                        {
                            objetoCuenta.Contrasena = txtbxContra.Text;
                            if (LNCuentas.EditarCuenta(objetoCuenta) > 0)
                            {
                                MessageBox.Show("Actualizado con éxito");
                                dataGridViewCuentas.DataSource = LNCuentas.ListarCuenta();
                                List<string> Cuenta = new List<string>();
                                Cuenta = LNCuentas.ListarCuentaUsuario().Select(x => x.NombreCuenta).ToList();
                                cmbbxCuenta.DataSource = Cuenta;
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
                    else
                    {
                        List<string> Cuenta = new List<string>();
                        Cuenta = LNCuentas.ListarCuentaUsuario().Select(x => x.NombreCuenta).ToList();
                        cmbbxCuenta.DataSource = Cuenta;
                        txtbxNomCuen.Text = "";
                        txtbxContra.Text = "";
                        txtbxConf.Text = "";
                        cmbbxTipo.Text = "";
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                if (PreAsignarConfirmation() == System.Windows.Forms.DialogResult.Yes)
                {
                    Usuario objetoUsuario = new Usuario();
                    objetoUsuario.IdCuenta = LNCuentas.BuscarIdCuenta(cmbbxCuenta.Text);
                    objetoUsuario.IdMedico = LNMed.buscarIdPorMedico(cmbbxMed.Text);

                    if (LNUsu.InsertarUsuario(objetoUsuario) > 0)
                    {
                        MessageBox.Show("Asignada con éxito");
                    }
                    else { MessageBox.Show("Error al asingnar la cuenta"); }
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}

