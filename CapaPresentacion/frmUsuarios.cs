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
    public partial class frmUsuarios : Form
    {
        LogicaNegocioCuentas LNCuentas = new LogicaNegocioCuentas();
        LogicaNegocioUsuario LNUsu = new LogicaNegocioUsuario();
        LogicaNegocioMedico LNMed = new LogicaNegocioMedico();
        public frmUsuarios()
        {
            InitializeComponent();
        }


        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Seguro que quiere cerrar asignar ",
                "Cerrar la Aplicación",
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
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
                        this.Close();
                    }
                    else { MessageBox.Show("Error al asingnar la cuenta"); }
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            List<string> Medico = new List<string>();
            List<string> Cuenta = new List<string>();
            Medico = LNMed.buscarMedicoCuenta().Select(x => x.NombreM + " " + x.ApellidoM).ToList();
            Cuenta = LNCuentas.ListarCuentaUsuario().Select(x => x.NombreCuenta).ToList();
            cmbbxMed.DataSource = Medico;
            cmbbxCuenta.DataSource = Cuenta;
        }
    }
}
