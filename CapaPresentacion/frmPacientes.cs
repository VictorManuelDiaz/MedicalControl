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
    public partial class frmPacientes : Form
    {
        LogicaNegocioPaciente LNPac = new LogicaNegocioPaciente();
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            dataGridViewPac.DataSource = LNPac.ListarPaciente();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnRegistrar.Text == "Registrar")
                {
                    Paciente objetoPaciente = new Paciente();
                    objetoPaciente.CedulaPac = maskedtxtbxCed.Text;
                    objetoPaciente.NombrePac = txtbxNom.Text;
                    objetoPaciente.ApellidosPac = txtbxApell.Text;
                    objetoPaciente.FechaNacimiento = maskedtxtbxFecNac.Text;
                    objetoPaciente.LugarNacimiento = txtbxNac.Text;
                    if (cmbbxSexo.Text == "Femenino")
                    {
                        objetoPaciente.SexoPac = "F";
                    }
                    else
                    {
                        objetoPaciente.SexoPac = "M";
                    }
                    objetoPaciente.EdadPac = Convert.ToInt32(txtbxEdad.Text);
                    objetoPaciente.GrupoEtnico = cmbbxEtnia.Text;
                    objetoPaciente.DireccionHabitualPac = txtbxDire.Text;
                    objetoPaciente.NombrePadre = txtbxPadre.Text;
                    objetoPaciente.NombreMadre = txtbxMadre.Text;
                    objetoPaciente.ReligionPac = cmbbxRelig.Text;
                    objetoPaciente.ProcedenciaPac = txtbxProced.Text;
                    objetoPaciente.TelefonoPac = maskedtxtbxTele.Text;
                    objetoPaciente.EstadoCivilPac = cmbbxCivil.Text;

                    if (LNPac.InsertarPaciente(objetoPaciente) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewPac.DataSource = LNPac.ListarPaciente();
                        maskedtxtbxCed.Text = "";
                        txtbxNom.Text = "";
                        txtbxApell.Text = "";
                        maskedtxtbxFecNac.Text = "";
                        txtbxNac.Text = "";
                        txtbxEdad.Text = "";
                        txtbxDire.Text = "";
                        txtbxPadre.Text = "";
                        txtbxMadre.Text = "";
                        txtbxProced.Text = "";
                        maskedtxtbxTele.Text = "";

                    }
                    else { MessageBox.Show("Error al agregar Recurso"); }
                }
                if (btnRegistrar.Text == "Actualizar")
                {
                    Paciente objetoPaciente = new Paciente();
                    objetoPaciente.CedulaPac = maskedtxtbxCed.Text;
                    objetoPaciente.NombrePac = txtbxNom.Text;
                    objetoPaciente.ApellidosPac = txtbxApell.Text;
                    objetoPaciente.FechaNacimiento = maskedtxtbxFecNac.Text;
                    objetoPaciente.LugarNacimiento = txtbxNac.Text;
                    if (cmbbxSexo.Text == "Femenino")
                    {
                        objetoPaciente.SexoPac = "F";
                    }
                    else
                    {
                        objetoPaciente.SexoPac = "M";
                    }
                    objetoPaciente.EdadPac = Convert.ToInt32(txtbxEdad.Text);
                    objetoPaciente.GrupoEtnico = cmbbxEtnia.Text;
                    objetoPaciente.DireccionHabitualPac = txtbxDire.Text;
                    objetoPaciente.NombrePadre = txtbxPadre.Text;
                    objetoPaciente.NombreMadre = txtbxMadre.Text;
                    objetoPaciente.ReligionPac = cmbbxRelig.Text;
                    objetoPaciente.ProcedenciaPac = txtbxProced.Text;
                    objetoPaciente.TelefonoPac = maskedtxtbxTele.Text;
                    objetoPaciente.EstadoCivilPac = cmbbxCivil.Text;

                    if (LNPac.EditarPaciente(objetoPaciente) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewPac.DataSource = LNPac.ListarPaciente();
                        maskedtxtbxCed.Text = "";
                        txtbxNom.Text = "";
                        txtbxApell.Text = "";
                        maskedtxtbxFecNac.Text = "";
                        txtbxNac.Text = "";
                        txtbxEdad.Text = "";
                        txtbxDire.Text = "";
                        txtbxPadre.Text = "";
                        txtbxMadre.Text = "";
                        txtbxProced.Text = "";
                        maskedtxtbxTele.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Recurso");
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
