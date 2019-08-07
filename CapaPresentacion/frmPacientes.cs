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
            txtbxIdExp.Visible = false;
            lblIdExp.Visible = false;
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {

            int codigoP = Convert.ToInt32(dataGridViewPac.CurrentRow.Cells["IdPaciente"].Value.ToString());
            try
            {
                if (LNPac.EliminarPaciente(codigoP) > 0)
                {
                    MessageBox.Show("Eliminado con éxito");
                    dataGridViewPac.DataSource = LNPac.ListarPaciente();
                }
            }
            catch
            {
                MessageBox.Show("ERROR al eliminar Paciente");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            txtbxIdExp.Visible = true;
            txtbxIdExp.Enabled = false;
            lblIdExp.Visible = true;

            txtbxIdExp.Text = dataGridViewPac.CurrentRow.Cells["IdExpediente"].Value.ToString();
            txtbxNumExp.Text = dataGridViewPac.CurrentRow.Cells["NumeroExpediente"].Value.ToString();
            maskedtxtbxCed.Text = dataGridViewPac.CurrentRow.Cells["CedulaPac"].Value.ToString();
            txtbxNom.Text = dataGridViewPac.CurrentRow.Cells["NombrePac"].Value.ToString();
            txtbxApell.Text = dataGridViewPac.CurrentRow.Cells["ApellidosPac"].Value.ToString();
            maskedtxtbxFecNac.Text = dataGridViewPac.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
            txtbxNac.Text = dataGridViewPac.CurrentRow.Cells["LugarNacimiento"].Value.ToString();
            cmbbxSexo.SelectedItem = dataGridViewPac.CurrentRow.Cells["SexoPac"].Value;
            txtbxEdad.Text = dataGridViewPac.CurrentRow.Cells["EdadPac"].Value.ToString();
            cmbbxEtnia.SelectedItem = dataGridViewPac.CurrentRow.Cells["GrupoEtnico"].Value;
            txtbxDire.Text = dataGridViewPac.CurrentRow.Cells["DireccionhabitualPac"].Value.ToString();
            txtbxPadre.Text = dataGridViewPac.CurrentRow.Cells["NombrePadre"].Value.ToString();
            txtbxMadre.Text = dataGridViewPac.CurrentRow.Cells["NombreMadre"].Value.ToString();
            cmbbxRelig.SelectedItem = dataGridViewPac.CurrentRow.Cells["ReligionPac"].Value;
            txtbxProced.Text = dataGridViewPac.CurrentRow.Cells["ProcedenciaPac"].Value.ToString();
            maskedtxtbxTele.Text = dataGridViewPac.CurrentRow.Cells["TelefonoPac"].Value.ToString();
            cmbbxCivil.SelectedItem = dataGridViewPac.CurrentRow.Cells["EstadoCivilPac"].Value;

            btnRegistrar.Text = "Actualizar";

        }

        private void txtbxBuscPaciente_OnTextChange(object sender, EventArgs e)
        {
            List<Paciente> listaPac = LNPac.BuscarPaciente(txtbxBuscPaciente.text);
            dataGridViewPac.DataSource = listaPac;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            try
            {
                if (btnRegistrar.Text == "Registrar")
                {
                    Paciente objetoPaciente = new Paciente();
                    objetoPaciente.NumeroExpediente = txtbxNumExp.Text;
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
                        txtbxNumExp.Text = "";
                        maskedtxtbxCed.Text = "";
                        txtbxNom.Text = "";
                        txtbxApell.Text = "";
                        maskedtxtbxFecNac.Text = "";
                        txtbxNac.Text = "";
                        txtbxEdad.Text = "";
                        cmbbxEtnia.Text = "";
                        txtbxDire.Text = "";
                        txtbxPadre.Text = "";
                        txtbxMadre.Text = "";
                        txtbxProced.Text = "";
                        maskedtxtbxTele.Text = "";
                        cmbbxCivil.Text = "";

                    }
                    else { MessageBox.Show("Error al agregar Paciente"); }
                }
                if (btnRegistrar.Text == "Actualizar")
                {
                    Paciente objetoPaciente = new Paciente();
                    objetoPaciente.NumeroExpediente = txtbxNumExp.Text;
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
                        txtbxNumExp.Text = "";
                        maskedtxtbxCed.Text = "";
                        txtbxNom.Text = "";
                        txtbxApell.Text = "";
                        maskedtxtbxFecNac.Text = "";
                        txtbxNac.Text = "";
                        txtbxEdad.Text = "";
                        cmbbxEtnia.Text = "";
                        txtbxDire.Text = "";
                        txtbxPadre.Text = "";
                        txtbxMadre.Text = "";
                        txtbxProced.Text = "";
                        maskedtxtbxTele.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Paciente");
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
