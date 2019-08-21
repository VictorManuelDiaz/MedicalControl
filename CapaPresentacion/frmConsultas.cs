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
        public frmConsultas(int IdMedico)
        {

            InitializeComponent();
            this.IdMedico = IdMedico;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
                        // obtener medicamento del textbox
                        //objetoConsulta.IdExpediente = Convert.ToInt32(cmbbxIdExpe.Text);
                        objetoConsulta.IdMedico = IdMedico;

                        if (LNCon.InsertarConsulta(objetoConsulta) > 0)
                        {
                            MessageBox.Show("Agregada con éxito");
                            dataGridViewConsult.DataSource = LNCon.ListarConsultaMedico(IdMedico);
                            datetimepickerFecha.Value = DateTime.Now;
                            maskedtxtbxHora.Text = "";
                            txtbxCosto.Text = "";
                            txtbxSinto.Text = "";
                            txtbxDiag.Text = "";
                            //cmbbxIdExpe.Text = "";
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
                        //cmbbxIdExpe.Text = "";
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
                        //objetoConsulta.IdExpediente = Convert.ToInt32(cmbbxIdExpe.Text);
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
                            //cmbbxIdExpe.Text = "";
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
                        //cmbbxIdExpe.Text = "";
                    }

                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }

        }

        private void txtbxBuscar_OnTextChange(object sender, EventArgs e)
        {
            List<Consulta> listaConsult = LNCon.BuscarConsulta(txtbxBuscar.text);
            dataGridViewConsult.DataSource = listaConsult;
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

        private void RegistrarMedicamento()
        {
            try
            {

                Medicamento objetoMedi = new Medicamento();
                objetoMedi.NombreMedica = txtbxMedi.Text;
                objetoMedi.PresentacionMedica = txtbxPresent.Text;
            }
            catch
            {


            }
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            dataGridViewConsult.DataSource = LNCon.ListarConsultaMedico(IdMedico);
            dataGridViewConsult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblIdConsul.Visible = false;
            txtbxIdConsul.Visible = false;
        }
    }
}
