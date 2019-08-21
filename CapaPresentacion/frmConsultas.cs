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
    
    public partial class frmConsultas : Form
    {

        private int IdMedico = 0;
        LogicaNegocioConsulta LNCon = new LogicaNegocioConsulta();
        LogicaNegocioExpediente LNExp = new LogicaNegocioExpediente();
        LogicaNegocioMedicamentos LNMed = new LogicaNegocioMedicamentos();
        public frmConsultas(int IdMedico)
        {

            InitializeComponent();
            this.IdMedico = IdMedico;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
        }

        

        private DialogResult PreGuardarConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Está seguro que quiere registrar esta nueva consulta?",
                "Cerrar la Aplicación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return res;
        }

        private DialogResult PreEliminarConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Está seguro que quiere eliminar esta consulta?",
                "Cerrar la Aplicación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return res;
        }


        private DialogResult PreEditarConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Está seguro que quiere guardar los cambios realizados a esta consulta",
                "Cerrar la Aplicación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return res;
        }

        private void RegistrarMedicamento()
        {
            try
            {
                Medicamento objetoMedi = new Medicamento();
                objetoMedi.NombreMedica = txtbxMedi.Text;
                objetoMedi.PresentacionMedica = txtbxPresent.Text;
                if (LNMed.insertarMedicamentos(objetoMedi) > 0)
                {
                    txtbxMedi.Text = "";
                    txtbxPresent.Text = "";
                }
            }
            catch
            {

            }
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            dataGridViewConsult.DataSource = LNCon.ListarConsultaMedico(IdMedico);
            dataGridViewConsult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewConsultasHoy.DataSource = LNCon.ListarConsultaHoy(IdMedico);
            dataGridViewConsultasHoy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblIdConsul.Visible = false;
            txtbxIdConsul.Visible = false;
            List<int> NumEx = new List<int>();
            NumEx = LNCon.ListarConsultaMedico(IdMedico).Select(x => x.IdExpediente).ToList();
            cmbExp.DataSource = NumEx;
        }

        private void txtbxBuscar_OnTextChange(object sender, EventArgs e)
        {
            List<Consulta> listaConsult = LNCon.BuscarConsulta(txtbxBuscar.text);
            dataGridViewConsult.DataSource = listaConsult;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnRegistrar.Text == "Registrar")
                {

                    if (PreGuardarConfirmation() == System.Windows.Forms.DialogResult.Yes)
                    {
                        Consulta objetoConsulta = new Consulta();

                        objetoConsulta.Fecha = datetimepickerFecha.Value;
                        objetoConsulta.Hora = maskedtxtbxHora.Text;
                        objetoConsulta.Costo = txtbxCosto.Text;
                        objetoConsulta.Sintomas = txtbxSinto.Text;
                        objetoConsulta.Diagnostico = txtbxDiag.Text;
                        objetoConsulta.IdExpediente = Convert.ToInt32(cmbExp.Text);
                        objetoConsulta.IdMedico = IdMedico;
                        RegistrarMedicamento();

                        if (LNCon.InsertarConsulta(objetoConsulta) > 0)
                        {
                            MessageBox.Show("Agregada con éxito");
                            dataGridViewConsult.DataSource = LNCon.ListarConsultaMedico(IdMedico);
                            datetimepickerFecha.Value = DateTime.Now;
                            maskedtxtbxHora.Text = "";
                            txtbxCosto.Text = "";
                            txtbxSinto.Text = "";
                            txtbxDiag.Text = "";
                            cmbExp.Text = "";
                        }
                        else
                        { MessageBox.Show("Error al agregar la consulta"); }
                    }
                    else
                    {
                        datetimepickerFecha.Value = DateTime.Now;
                        maskedtxtbxHora.Text = "";
                        txtbxCosto.Text = "";
                        txtbxSinto.Text = "";
                        txtbxDiag.Text = "";
                        cmbExp.Text = "";
                    }

                }
                if (btnRegistrar.Text == "Actualizar")
                {

                    if (PreEditarConfirmation() == System.Windows.Forms.DialogResult.Yes)
                    {
                        Consulta objetoConsulta = new Consulta();

                        objetoConsulta.Fecha = datetimepickerFecha.Value;
                        objetoConsulta.Hora = maskedtxtbxHora.Text;
                        objetoConsulta.Costo = txtbxCosto.Text;
                        objetoConsulta.Sintomas = txtbxSinto.Text;
                        objetoConsulta.Diagnostico = txtbxDiag.Text;
                        objetoConsulta.IdExpediente = Convert.ToInt32(cmbExp.Text);
                        objetoConsulta.IdMedico = IdMedico;


                        if (LNCon.EditarConsulta(objetoConsulta) > 0)
                        {
                            MessageBox.Show("Actualizado con éxito");
                            dataGridViewConsult.DataSource = LNCon.ListarConsulta();
                            datetimepickerFecha.Value = DateTime.Now;
                            maskedtxtbxHora.Text = "";
                            txtbxCosto.Text = "";
                            txtbxSinto.Text = "";
                            txtbxDiag.Text = "";
                            cmbExp.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar especialidad");
                        }
                        btnRegistrar.Text = "Registrar";
                    }
                    else
                    {
                        datetimepickerFecha.Value = DateTime.Now;
                        maskedtxtbxHora.Text = "";
                        txtbxCosto.Text = "";
                        txtbxSinto.Text = "";
                        txtbxDiag.Text = "";
                        cmbExp.Text = "";
                    }

                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (PreEliminarConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                int codigoConsul = Convert.ToInt32(dataGridViewConsult.CurrentRow.Cells["IdConsulta"].Value.ToString());
                try
                {
                    if (LNCon.EliminarConsulta(codigoConsul) > 0)
                    {
                        MessageBox.Show("Eliminado con éxito");
                        dataGridViewConsult.DataSource = LNCon.ListarConsulta();
                    }
                }
                catch
                {
                    MessageBox.Show("ERROR al eliminar consulta");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
