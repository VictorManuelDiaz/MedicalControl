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
    public partial class frmCita : Form
    {
        LogicaNegocioCita LNCita = new LogicaNegocioCita();
        LogicaNegocioExpediente LNExp = new LogicaNegocioExpediente();
        LogicaNegocioMedico LNMed = new LogicaNegocioMedico();
        public frmCita()
        {
            InitializeComponent();
            dataGridViewCita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCita.DataSource = LNCita.ListarCita();
            dataGridViewCitasHoy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCitasHoy.DataSource = LNCita.ListarCitaHoy();
        }
        public frmCita(int IdMedico)
        {
            InitializeComponent();
            dataGridViewCita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCita.DataSource = LNCita.ListarCitaMedico(IdMedico);
            dataGridViewCitasHoy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCitasHoy.DataSource = LNCita.ListarCitaHoyMedico(IdMedico);
            panelRegistrar.Visible = false;
            panelVista.Size= new Size(1116, 500);
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
        }

        private void frmCita_Load(object sender, EventArgs e)
        {

            List<string> Medico = new List<string>();
            Medico = LNMed.listarMedico().Select(x => x.NombreM + " " + x.ApellidoM).ToList();
            comboBoxIdMed.DataSource = Medico;
            List<int> NumEx = new List<int>();
            NumEx = LNExp.ListarExpediente().Select(x => x.IdExpediente).ToList();
            comboBoxNumExp.DataSource = NumEx;
        }


        private void txtbxBuscar_OnTextChange(object sender, EventArgs e)
        {
            List<Cita> listaCita = LNCita.BuscarCita(txtbxBuscar.text);
            dataGridViewCita.DataSource = listaCita;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtbxIdCita.Visible = true;
            txtbxIdCita.Enabled = false;
            lblIdCita.Visible = true;

            txtbxIdCita.Text = dataGridViewCita.CurrentRow.Cells["IdCita"].Value.ToString();
            dateTimePickerRealCita.Text = dataGridViewCita.CurrentRow.Cells["FechaRealCita"].Value.ToString();
            maskedTextBoxHoraC.Text = dataGridViewCita.CurrentRow.Cells["HoraC"].Value.ToString();
            comboBoxNumExp.Text = dataGridViewCita.CurrentRow.Cells["IdExpediente"].Value.ToString();
            comboBoxIdMed.Text = LNMed.buscarMedicoPorId(Convert.ToInt32(dataGridViewCita.CurrentRow.Cells["IdMedico"].Value.ToString()));
            btnRegistrar.Text = "Actualizar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigoCita = Convert.ToInt32(dataGridViewCita.CurrentRow.Cells["IdCita"].Value.ToString());
            try
            {
                if (LNCita.EliminarCita(codigoCita) > 0)
                {
                    MessageBox.Show("Eliminado con éxito");
                    dataGridViewCita.DataSource = LNCita.ListarCita();
                }
            }
            catch
            {
                MessageBox.Show("ERROR al eliminar cita");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnRegistrar.Text == "Registrar")
                {
                    Cita objetoCita = new Cita();
                    objetoCita.FechaConsul = DateTime.Now;
                    objetoCita.FechaRealCita = dateTimePickerRealCita.Value;
                    objetoCita.HoraC = maskedTextBoxHoraC.Text;
                    objetoCita.IdExpediente = Convert.ToInt32(comboBoxNumExp.Text);
                    objetoCita.IdMedico = LNMed.buscarIdPorMedico(comboBoxIdMed.Text);

                    if (LNCita.InsertarCita(objetoCita) > 0)
                    {
                        MessageBox.Show("Registrada con éxito");
                        dataGridViewCita.DataSource = LNCita.ListarCita();
                        dataGridViewCitasHoy.DataSource = LNCita.ListarCitaHoy();
                        dateTimePickerRealCita.Value = DateTime.Now;
                        maskedTextBoxHoraC.Text = "";
                    }
                    else { MessageBox.Show("Error al registrar Cita"); }
                }
                if (btnRegistrar.Text == "Actualizar")
                {
                    Cita objetoCita = new Cita();
                    objetoCita.IdCita = Convert.ToInt32(txtbxIdCita.Text);
                    objetoCita.FechaConsul = DateTime.Now;
                    objetoCita.FechaRealCita = dateTimePickerRealCita.Value;
                    objetoCita.HoraC = maskedTextBoxHoraC.Text;
                    objetoCita.IdExpediente = Convert.ToInt32(comboBoxNumExp.Text);


                    if (LNCita.EditarCita(objetoCita) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewCita.DataSource = LNCita.ListarCita();
                        dateTimePickerRealCita.Value = DateTime.Now;
                        maskedTextBoxHoraC.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Cita");
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

