﻿using System;
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
    public partial class frmMedicos : Form
    {
        LogicaNegocioMedico LNMedico = new LogicaNegocioMedico();
        LogicaNegocioEspecialidad LNEspe = new LogicaNegocioEspecialidad();
        public frmMedicos()
        {
            InitializeComponent();
            
            
            
        }
        private void frmMedicos_Load(object sender, EventArgs e)
        {
            dataGridViewMedico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMedico.DataSource = LNMedico.listarMedico();
            txtbxIdMedico.Visible = false;
            lblIdMedico.Visible = false;
            List<string> Espe = new List<string>();
            Espe = LNEspe.ListarEspecialidad().Select(x => x.NombreEs).ToList();
            combobxEspe.DataSource = Espe;

        }


       

        private void txtbxBuscMed_OnTextChange(object sender, EventArgs e)
        {

            List<Medico> listaMed = LNMedico.buscarMedico(txtbxBuscMed.text);
            dataGridViewMedico.DataSource = listaMed;

        }

        

        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (PreEliminarConfirmation()==System.Windows.Forms.DialogResult.Yes)
            {
                int codigoM = Convert.ToInt32(dataGridViewMedico.CurrentRow.Cells["IdMedico"].Value.ToString());
                try
                {
                    if (LNMedico.eliminarMedico(codigoM) > 0)
                    {
                        MessageBox.Show("Eliminado con éxito");
                        dataGridViewMedico.DataSource = LNMedico.listarMedico();
                    }
                }
                catch
                {
                    MessageBox.Show("ERROR al eliminar Medico");
                }
            }
            
        }

        

        private DialogResult PreGuardarConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Seguro que quiere registrar este médico?",
                "Registrar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return res;
        }

        private DialogResult PreEliminarConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Seguro que quiere eliminar este médico?",
                "Eliminar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return res;
        }


        private DialogResult PreEditarConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "¿Seguro que quiere actualizar este médico?",
                "Actualizar",
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
                        Medico objetoMedico = new Medico();
                        objetoMedico.NombreM = txtbxNombM.Text;
                        objetoMedico.ApellidoM = txtbxApellM.Text;
                        objetoMedico.IdEspecialidad = LNEspe.BuscarIdEspecialidad(combobxEspe.Text);
                        objetoMedico.EmailM = txtbxCorreo.Text;
                        objetoMedico.TelefonoM = maskedtxtbxTelefonoMed.Text;
                        objetoMedico.CedulaM = maskedtxtbxCedMed.Text;
                        if (combobxSexo.Text == "Femenino")
                        {
                            objetoMedico.SexoM = "F";
                        }
                        else
                        {
                            objetoMedico.SexoM = "M";
                        }
                        objetoMedico.DireccionM = txtbxDirec.Text;

                        if (LNMedico.insertarMedico(objetoMedico) > 0)
                        {
                            MessageBox.Show("Agregado con éxito");
                            dataGridViewMedico.DataSource = LNMedico.listarMedico();
                            txtbxNombM.Text = "";
                            txtbxApellM.Text = "";
                            txtbxCorreo.Text = "";
                            maskedtxtbxTelefonoMed.Text = "";
                            maskedtxtbxCedMed.Text = "";
                            txtbxDirec.Text = "";

                        }
                        else { MessageBox.Show("Error al agregar Recurso"); }
                    }
                    else
                    {
                        txtbxNombM.Text = "";
                        txtbxApellM.Text = "";
                        txtbxCorreo.Text = "";
                        maskedtxtbxTelefonoMed.Text = "";
                        maskedtxtbxCedMed.Text = "";
                        txtbxDirec.Text = "";
                    }

                }
                if (btnRegistrar.Text == "Actualizar")
                {
                    if (PreEditarConfirmation() == System.Windows.Forms.DialogResult.Yes)
                    {
                        Medico objetoMedico = new Medico();
                        objetoMedico.NombreM = txtbxNombM.Text;
                        objetoMedico.ApellidoM = txtbxApellM.Text;
                        objetoMedico.IdEspecialidad = LNEspe.BuscarIdEspecialidad(combobxEspe.Text);
                        objetoMedico.EmailM = txtbxCorreo.Text;
                        objetoMedico.TelefonoM = maskedtxtbxTelefonoMed.Text;
                        objetoMedico.CedulaM = maskedtxtbxCedMed.Text;
                        objetoMedico.SexoM = combobxSexo.Text;
                        objetoMedico.DireccionM = txtbxDirec.Text;

                        if (LNMedico.editarMedico(objetoMedico) > 0)
                        {
                            MessageBox.Show("Actualizado con éxito");
                            dataGridViewMedico.DataSource = LNMedico.listarMedico();
                            txtbxNombM.Text = "";
                            txtbxApellM.Text = "";
                            txtbxCorreo.Text = "";
                            maskedtxtbxTelefonoMed.Text = "";
                            maskedtxtbxCedMed.Text = "";
                            txtbxDirec.Text = "";
                            lblIdMedico.Visible = false;
                            txtbxIdMedico.Visible = false;

                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar Medico");
                        }
                        btnRegistrar.Text = "Registrar";
                    }
                    else
                    {
                        txtbxNombM.Text = "";
                        txtbxApellM.Text = "";
                        txtbxCorreo.Text = "";
                        maskedtxtbxTelefonoMed.Text = "";
                        maskedtxtbxCedMed.Text = "";
                        txtbxDirec.Text = "";
                        lblIdMedico.Visible = false;
                        txtbxIdMedico.Visible = false;
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
            txtbxIdMedico.Visible = true;
            txtbxIdMedico.Enabled = false;
            lblIdMedico.Visible = true;

            txtbxIdMedico.Text = dataGridViewMedico.CurrentRow.Cells["IdMedico"].Value.ToString();
            txtbxNombM.Text = dataGridViewMedico.CurrentRow.Cells["NombreM"].Value.ToString();
            txtbxApellM.Text = dataGridViewMedico.CurrentRow.Cells["ApellidoM"].Value.ToString();
            combobxEspe.SelectedItem = dataGridViewMedico.CurrentRow.Cells["IdEspecialidad"].Value;
            txtbxCorreo.Text = dataGridViewMedico.CurrentRow.Cells["EmailM"].Value.ToString();
            maskedtxtbxTelefonoMed.Text = dataGridViewMedico.CurrentRow.Cells["TelefonoM"].Value.ToString();
            maskedtxtbxCedMed.Text = dataGridViewMedico.CurrentRow.Cells["CedulaM"].Value.ToString();
            combobxSexo.SelectedItem = dataGridViewMedico.CurrentRow.Cells["SexoM"].Value;
            txtbxDirec.Text = dataGridViewMedico.CurrentRow.Cells["DireccionM"].Value.ToString();
            btnRegistrar.Text = "Actualizar";
        }
    }
}
