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
        }

        private void frmCita_Load(object sender, EventArgs e)
        {
            dataGridViewCita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCita.DataSource = LNCita.ListarCita();

            List<string> Medico = new List<string>();
            Medico = LNMed.listarMedico().Select(x => x.NombreM+" "+x.ApellidoM).ToList();
            comboBoxIdMed.DataSource = Medico;

            List<int> NumEx = new List<int>();
            NumEx = LNExp.ListarExpediente().Select(x => x.IdExpediente).ToList();
            comboBoxNumExp.DataSource = NumEx;
        }

        


        private void btnElminar_Click(object sender, EventArgs e)
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

        private void btnEditar_Click(object sender, EventArgs e)
        {

            txtbxIdCita.Visible = true;
            txtbxIdCita.Enabled = false;
            lblIdCita.Visible = true;

            txtbxIdCita.Text = dataGridViewCita.CurrentRow.Cells["Idcita"].Value.ToString();
            dateTimePickerRealCita.Text = dataGridViewCita.CurrentRow.Cells["FechaRealCita"].Value.ToString();
            maskedTextBoxHoraC.Text = dataGridViewCita.CurrentRow.Cells["HoraC"].Value.ToString();
            comboBoxNumExp.Text = dataGridViewCita.CurrentRow.Cells["IdExpediente"].Value.ToString();
            comboBoxIdMed.Text = dataGridViewCita.CurrentRow.Cells["IdMedico"].Value.ToString();
            btnRegistrar.Text = "Actualizar";

        }

        private void txtbxBuscar_OnTextChange(object sender, EventArgs e)
        {

            List<Cita> listaCita = LNCita.BuscarCita(txtbxBuscar.text);
            dataGridViewCita.DataSource = listaCita;
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
                    objetoCita.IdExpediente = 1;
                    //objetoCita.NumeroExpediente = Convert.ToInt32(comboBoxNumExp.Text);
                    objetoCita.IdMedico = LNMed.buscarMedicoPorId(comboBoxIdMed.Text);

                    if (LNCita.InsertarCita(objetoCita) > 0)
                    {
                        MessageBox.Show("Registrada con éxito");
                        dataGridViewCita.DataSource = LNCita.ListarCita();
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
                    objetoCita.IdExpediente = 1;
                    //objetoCita.NumeroExpediente = Convert.ToInt32(comboBoxNumExp.Text);


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
