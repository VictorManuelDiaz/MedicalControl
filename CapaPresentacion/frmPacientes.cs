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
        private int IdMedico = 0;
        LogicaNegocioPaciente LNPac = new LogicaNegocioPaciente();
        public frmPacientes()
        {
            InitializeComponent();
            dataGridViewPac.DataSource = LNPac.ListarPaciente();
        }
        public frmPacientes(int IdMedico)
        {
            InitializeComponent();
            this.IdMedico = IdMedico;
            dataGridViewPac.DataSource = LNPac.PacienteMedico(IdMedico);
            panelRegistrar.Visible = false;
            panelVista.Size = new Size(1116, 500);
            dataGridViewPac.Size = new Size(1039, 343);
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
           
            txtbxIdExp.Visible = false;
            lblIdExp.Visible = false;
        }

        

        private void txtbxBuscPaciente_OnTextChange(object sender, EventArgs e)
        {
            if (IdMedico != 0)
            {
                List<Paciente> listaPac = LNPac.BuscarPacienteMedico(IdMedico,txtbxBuscPaciente.text);
                dataGridViewPac.DataSource = listaPac;
            }
            else
            {
                List<Paciente> listaPac = LNPac.BuscarPaciente(txtbxBuscPaciente.text);
                dataGridViewPac.DataSource = listaPac;
            }
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnRegistrar.Text == "Registrar")
                {

                    if (PreGuardarConfirmation() == System.Windows.Forms.DialogResult.Yes)
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
                    else
                    {
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
                    
                }
                if (btnRegistrar.Text == "Actualizar")
                {
                    if (PreEditarConfirmation() == System.Windows.Forms.DialogResult.Yes)
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
                            cmbbxSexo.Text = "";
                            txtbxEdad.Text = "";
                            cmbbxEtnia.Text = "";
                            txtbxDire.Text = "";
                            txtbxPadre.Text = "";
                            txtbxMadre.Text = "";
                            cmbbxRelig.Text = "";
                            txtbxProced.Text = "";
                            maskedtxtbxTele.Text = "";
                            cmbbxCivil.Text = "";
                            lblIdExp.Visible = false;
                            txtbxIdExp.Visible = false;

                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar Paciente");
                        }
                        btnRegistrar.Text = "Registrar";
                    }
                    else
                    {
                        txtbxNumExp.Text = "";
                        maskedtxtbxCed.Text = "";
                        txtbxNom.Text = "";
                        txtbxApell.Text = "";
                        maskedtxtbxFecNac.Text = "";
                        txtbxNac.Text = "";
                        cmbbxSexo.Text = "";
                        txtbxEdad.Text = "";
                        cmbbxEtnia.Text = "";
                        txtbxDire.Text = "";
                        txtbxPadre.Text = "";
                        txtbxMadre.Text = "";
                        cmbbxRelig.Text = "";
                        txtbxProced.Text = "";
                        maskedtxtbxTele.Text = "";
                        cmbbxCivil.Text = "";
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
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
            cmbbxSexo.Text = dataGridViewPac.CurrentRow.Cells["SexoPac"].Value.ToString();
            txtbxEdad.Text = dataGridViewPac.CurrentRow.Cells["EdadPac"].Value.ToString();
            cmbbxEtnia.SelectedItem = dataGridViewPac.CurrentRow.Cells["GrupoEtnico"].Value;
            txtbxDire.Text = dataGridViewPac.CurrentRow.Cells["DireccionhabitualPac"].Value.ToString();
            txtbxPadre.Text = dataGridViewPac.CurrentRow.Cells["NombrePadre"].Value.ToString();
            txtbxMadre.Text = dataGridViewPac.CurrentRow.Cells["NombreMadre"].Value.ToString();
            cmbbxRelig.Text = dataGridViewPac.CurrentRow.Cells["ReligionPac"].Value.ToString();
            txtbxProced.Text = dataGridViewPac.CurrentRow.Cells["ProcedenciaPac"].Value.ToString();
            maskedtxtbxTele.Text = dataGridViewPac.CurrentRow.Cells["TelefonoPac"].Value.ToString();
            cmbbxCivil.Text = dataGridViewPac.CurrentRow.Cells["EstadoCivilPac"].Value.ToString();

            btnRegistrar.Text = "Actualizar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (PreEliminarConfirmation() == System.Windows.Forms.DialogResult.Yes)
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
            
            
        }

        private DialogResult PreGuardarConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Seguro que quiere registrar este paciente?",
                "Guardar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return res;
        }

        private DialogResult PreEliminarConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Seguro que quiere eliminar este paciente?",
                "Eliminar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return res;
        }


        private DialogResult PreEditarConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Seguro que quiere actualizar este paciente?",
                "Actualizar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return res;
        }
    }
}
