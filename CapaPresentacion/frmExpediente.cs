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
    public partial class frmExpediente : Form
    {
        LogicaNegocioExpediente LNExp = new LogicaNegocioExpediente();
        public frmExpediente()
        {
            InitializeComponent();

        }
        public frmExpediente(int IdMedico)
        {
            InitializeComponent();

        }



        private void frmExpediente_Load(object sender, EventArgs e)
        {
            dataGridViewExp.DataSource = LNExp.ListarExpediente();
        }

       

        private void txtbxBuscar_OnTextChange(object sender, EventArgs e)
        {
            List<Expediente> listaExpe = LNExp.BuscarExpediente(txtbxBuscar.text);
            dataGridViewExp.DataSource = listaExpe;
        }

        

        private void lblEnfermedadH_Click(object sender, EventArgs e)
        {
            if (PanelEnfermedadH.Visible == true)
            {
                PanelEnfermedadH.Visible = false;
            }
            else
            {
                PanelEnfermedadH.Visible = true;
            }
        }

        private void lblDatosgenerales_Click(object sender, EventArgs e)
        {
            if (PanelDatosPer.Visible == true)
            {
                PanelDatosPer.Visible = false;
            }
            else
            {
                PanelDatosPer.Visible = true;
            }
        }

        private void lblEnfermedadIC_Click(object sender, EventArgs e)
        {
            if (PanelEnfermedadIC.Visible == true)
            {
                PanelEnfermedadIC.Visible = false;
            }
            else
            {
                PanelEnfermedadIC.Visible = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnRegistrar.Text == "Registrar")
                {
                    Expediente objetoExpediente = new Expediente();
                    objetoExpediente.NumeroExpediente = txtbxNumeroExp.Text;
                    objetoExpediente.MotivoConsulta = txtbxMotiConsul.Text;
                    objetoExpediente.TratamientoIndicado = txtbxTrataIndiPac.Text;
                    objetoExpediente.CedulaPac = maskedtxtbxCedPac.Text;
                    objetoExpediente.NombrePac = txtbxNombrePac.Text;
                    objetoExpediente.ApellidosPac = txtbxApellidosPac.Text;
                    objetoExpediente.FechaNacimiento = maskedtxtbxFechaNac.Text;
                    objetoExpediente.LugarNacimiento = txtbxLugarNac.Text;

                    if (cmbbxSexoPac.Text == "Femenino")
                    {
                        objetoExpediente.SexoPac = "F";
                    }
                    else
                    {
                        objetoExpediente.SexoPac = "M";
                    }

                    objetoExpediente.EdadPac = Convert.ToInt32(txtbxEdadPac.Text);
                    objetoExpediente.GrupoEtnico = cmbbxGrupoEt.Text;
                    objetoExpediente.DireccionHabitualPac = txtbxDirhabiPac.Text;
                    objetoExpediente.NombrePadre = txtbxNombrePa.Text;
                    objetoExpediente.NombreMadre = txtbxNombreMa.Text;
                    objetoExpediente.ReligionPac = cmbbxReligionPac.Text;
                    objetoExpediente.ProcedenciaPac = txtbxProcedenciaPac.Text;
                    objetoExpediente.TelefonoPac = maskedtxtbxTelefonoPac.Text;
                    objetoExpediente.EstadoCivilPac = cmbbxEstCivil.Text;

                    if (chkbxHepatitis.Checked == true)
                    {
                        objetoExpediente.EnferICHepatitis = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICHepatitis = "F";
                    }

                    if (chkbxSifilis.Checked == true)
                    {
                        objetoExpediente.EnferICSifilis = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICSifilis = "F";
                    }

                    if (chkbxColera.Checked == true)
                    {
                        objetoExpediente.EnferICColera = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICColera = "F";
                    }

                    if (chkbxTosferina.Checked == true)
                    {
                        objetoExpediente.EnferICTosferina = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICTosferina = "F";
                    }

                    if (chkbxSarampion.Checked == true)
                    {
                        objetoExpediente.EnferICSarampion = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICSarampion = "F";
                    }

                    if (chkbxVaricela.Checked == true)
                    {
                        objetoExpediente.EnferICVaricela = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICVaricela = "F";
                    }

                    if (chkbxRubeola.Checked == true)
                    {
                        objetoExpediente.EnferICRubeola = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICRubeola = "F";
                    }

                    if (chkbxPariotiditis.Checked == true)
                    {
                        objetoExpediente.EnferICPariotiditis = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICPariotiditis = "F";
                    }

                    if (chkbxMeningitis.Checked == true)
                    {
                        objetoExpediente.EnferICMeningitis = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICMeningitis = "F";
                    }

                    if (chkbxImpetigo.Checked == true)
                    {
                        objetoExpediente.EnferICImpetigo = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICImpetigo = "F";
                    }

                    if (chkbxFiebreTi.Checked == true)
                    {
                        objetoExpediente.EnferICTifoidea = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICTifoidea = "F";
                    }

                    if (chkbxMalaria.Checked == true)
                    {
                        objetoExpediente.EnferICMalaria = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICMalaria = "F";
                    }

                    if (chkbxEscabiasis.Checked == true)
                    {
                        objetoExpediente.EnferICEscabiasis = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICEscabiasis = "F";
                    }

                    if (chkbxTina.Checked == true)
                    {
                        objetoExpediente.EnferICTina = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICTina = "F";

                    }


                    if (chkboxAlergias.Checked == true)
                    {
                        objetoExpediente.EnferHAlergias = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHAlergias = "F";

                    }

                    if (chkbxDiabetes.Checked == true)
                    {
                        objetoExpediente.EnferHDiabetes = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHDiabetes = "F";

                    }

                    if (chkbxHipertension.Checked == true)
                    {
                        objetoExpediente.EnferHHipertension = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHHipertension = "F";

                    }

                    if (chkbxReumatica.Checked == true)
                    {
                        objetoExpediente.EnferHReumatica = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHReumatica = "F";

                    }

                    if (chkbxRenales.Checked == true)
                    {
                        objetoExpediente.EnferHRenales = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHRenales = "F";

                    }

                    if (chkbxOculares.Checked == true)
                    {
                        objetoExpediente.EnferHOculares = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHOculares = "F";

                    }

                    if (chkbxCardiacas.Checked == true)
                    {
                        objetoExpediente.EnferHCardiacas = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHCardiacas = "F";

                    }

                    if (chkbxHepatica.Checked == true)
                    {
                        objetoExpediente.EnferHHepatica = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHHepatica = "F";

                    }

                    if (chkbxMusculares.Checked == true)
                    {
                        objetoExpediente.EnferHMusculares = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHMusculares = "F";

                    }

                    if (chkbxMalConge.Checked == true)
                    {
                        objetoExpediente.EnferHMalCongenitas = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHMalCongenitas = "F";

                    }

                    if (chkbxDesMentales.Checked == true)
                    {
                        objetoExpediente.EnferHDesorMentales = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHDesorMentales = "F";

                    }


                    if (LNExp.InsertarExpediente(objetoExpediente) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");

                        dataGridViewExp.DataSource = LNExp.ListarExpediente();
                        txtbxNumeroExp.Text = "";
                        txtbxMotiConsul.Text = "";
                        txtbxTrataIndiPac.Text = "";
                        maskedtxtbxCedPac.Text = "";
                        txtbxNombrePac.Text = "";
                        txtbxApellidosPac.Text = "";
                        maskedtxtbxFechaNac.Text = "";
                        txtbxLugarNac.Text = "";
                        cmbbxSexoPac.Text = "";
                        txtbxEdadPac.Text = "";
                        cmbbxGrupoEt.Text = "";
                        txtbxDirhabiPac.Text = "";
                        txtbxNombrePa.Text = "";
                        txtbxNombreMa.Text = "";
                        txtbxProcedenciaPac.Text = "";
                        maskedtxtbxTelefonoPac.Text = "";
                        cmbbxEstCivil.Text = "";
                        chkbxHepatitis.Checked = false;
                        chkbxSifilis.Checked = false;
                        chkbxColera.Checked = false;
                        chkbxTosferina.Checked = false;
                        chkbxSarampion.Checked = false;
                        chkbxVaricela.Checked = false;
                        chkbxRubeola.Checked = false;
                        chkbxPariotiditis.Checked = false;
                        chkbxMeningitis.Checked = false;
                        chkbxImpetigo.Checked = false;
                        chkbxFiebreTi.Checked = false;
                        chkbxMalaria.Checked = false;
                        chkbxEscabiasis.Checked = false;
                        chkbxTina.Checked = false;
                        chkboxAlergias.Checked = false;
                        chkbxDiabetes.Checked = false;
                        chkbxHipertension.Checked = false;
                        chkbxReumatica.Checked = false;
                        chkbxRenales.Checked = false;
                        chkbxOculares.Checked = false;
                        chkbxCardiacas.Checked = false;
                        chkbxHepatica.Checked = false;
                        chkbxMusculares.Checked = false;
                        chkbxMalConge.Checked = false;
                        chkbxDesMentales.Checked = false;




                    }
                    else { MessageBox.Show("Error al agregar Recurso"); }
                }
                if (btnRegistrar.Text == "Actualizar")
                {
                    Expediente objetoExpediente = new Expediente();
                    objetoExpediente.NumeroExpediente = txtbxNumeroExp.Text;
                    objetoExpediente.MotivoConsulta = txtbxMotiConsul.Text;
                    objetoExpediente.TratamientoIndicado = txtbxTrataIndiPac.Text;
                    objetoExpediente.CedulaPac = maskedtxtbxCedPac.Text;
                    objetoExpediente.NombrePac = txtbxNombrePac.Text;
                    objetoExpediente.ApellidosPac = txtbxApellidosPac.Text;
                    objetoExpediente.FechaNacimiento = maskedtxtbxFechaNac.Text;
                    objetoExpediente.LugarNacimiento = txtbxLugarNac.Text;

                    if (cmbbxSexoPac.Text == "Femenino")
                    {
                        objetoExpediente.SexoPac = "F";
                    }
                    else
                    {
                        objetoExpediente.SexoPac = "M";
                    }

                    objetoExpediente.EdadPac = Convert.ToInt32(txtbxEdadPac.Text);
                    objetoExpediente.GrupoEtnico = cmbbxGrupoEt.Text;
                    objetoExpediente.DireccionHabitualPac = txtbxDirhabiPac.Text;
                    objetoExpediente.NombrePadre = txtbxNombrePa.Text;
                    objetoExpediente.NombreMadre = txtbxNombreMa.Text;
                    objetoExpediente.ReligionPac = cmbbxReligionPac.Text;
                    objetoExpediente.ProcedenciaPac = txtbxProcedenciaPac.Text;
                    objetoExpediente.TelefonoPac = maskedtxtbxTelefonoPac.Text;
                    objetoExpediente.EstadoCivilPac = cmbbxEstCivil.Text;

                    if (chkbxHepatitis.Checked == true)
                    {
                        objetoExpediente.EnferICHepatitis = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICHepatitis = "F";
                    }

                    if (chkbxSifilis.Checked == true)
                    {
                        objetoExpediente.EnferICSifilis = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICSifilis = "F";
                    }

                    if (chkbxColera.Checked == true)
                    {
                        objetoExpediente.EnferICColera = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICColera = "F";
                    }

                    if (chkbxTosferina.Checked == true)
                    {
                        objetoExpediente.EnferICTosferina = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICTosferina = "F";
                    }

                    if (chkbxSarampion.Checked == true)
                    {
                        objetoExpediente.EnferICSarampion = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICSarampion = "F";
                    }

                    if (chkbxVaricela.Checked == true)
                    {
                        objetoExpediente.EnferICVaricela = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICVaricela = "F";
                    }

                    if (chkbxRubeola.Checked == true)
                    {
                        objetoExpediente.EnferICRubeola = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICRubeola = "F";
                    }

                    if (chkbxPariotiditis.Checked == true)
                    {
                        objetoExpediente.EnferICPariotiditis = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICPariotiditis = "F";
                    }

                    if (chkbxMeningitis.Checked == true)
                    {
                        objetoExpediente.EnferICMeningitis = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICMeningitis = "F";
                    }

                    if (chkbxImpetigo.Checked == true)
                    {
                        objetoExpediente.EnferICImpetigo = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICImpetigo = "F";
                    }

                    if (chkbxFiebreTi.Checked == true)
                    {
                        objetoExpediente.EnferICTifoidea = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICTifoidea = "F";
                    }

                    if (chkbxMalaria.Checked == true)
                    {
                        objetoExpediente.EnferICMalaria = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICMalaria = "F";
                    }

                    if (chkbxEscabiasis.Checked == true)
                    {
                        objetoExpediente.EnferICEscabiasis = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICEscabiasis = "F";
                    }

                    if (chkbxTina.Checked == true)
                    {
                        objetoExpediente.EnferICTina = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferICTina = "F";

                    }


                    if (chkboxAlergias.Checked == true)
                    {
                        objetoExpediente.EnferHAlergias = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHAlergias = "F";

                    }

                    if (chkbxDiabetes.Checked == true)
                    {
                        objetoExpediente.EnferHDiabetes = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHDiabetes = "F";

                    }

                    if (chkbxHipertension.Checked == true)
                    {
                        objetoExpediente.EnferHHipertension = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHHipertension = "F";

                    }

                    if (chkbxReumatica.Checked == true)
                    {
                        objetoExpediente.EnferHReumatica = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHReumatica = "F";

                    }

                    if (chkbxRenales.Checked == true)
                    {
                        objetoExpediente.EnferHRenales = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHRenales = "F";

                    }

                    if (chkbxOculares.Checked == true)
                    {
                        objetoExpediente.EnferHOculares = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHOculares = "F";

                    }

                    if (chkbxCardiacas.Checked == true)
                    {
                        objetoExpediente.EnferHCardiacas = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHCardiacas = "F";

                    }

                    if (chkbxHepatica.Checked == true)
                    {
                        objetoExpediente.EnferHHepatica = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHHepatica = "F";

                    }

                    if (chkbxMusculares.Checked == true)
                    {
                        objetoExpediente.EnferHMusculares = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHMusculares = "F";

                    }

                    if (chkbxMalConge.Checked == true)
                    {
                        objetoExpediente.EnferHMalCongenitas = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHMalCongenitas = "F";

                    }

                    if (chkbxDesMentales.Checked == true)
                    {
                        objetoExpediente.EnferHDesorMentales = "V";
                    }
                    else
                    {
                        objetoExpediente.EnferHDesorMentales = "F";

                    }



                    if (LNExp.EditarExpediente(objetoExpediente) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewExp.DataSource = LNExp.ListarExpediente();
                        txtbxNumeroExp.Text = "";
                        txtbxMotiConsul.Text = "";
                        txtbxTrataIndiPac.Text = "";
                        maskedtxtbxCedPac.Text = "";
                        txtbxNombrePac.Text = "";
                        txtbxApellidosPac.Text = "";
                        maskedtxtbxFechaNac.Text = "";
                        txtbxLugarNac.Text = "";
                        cmbbxSexoPac.Text = "";
                        txtbxEdadPac.Text = "";
                        cmbbxGrupoEt.Text = "";
                        txtbxDirhabiPac.Text = "";
                        txtbxNombrePa.Text = "";
                        txtbxNombreMa.Text = "";
                        txtbxProcedenciaPac.Text = "";
                        maskedtxtbxTelefonoPac.Text = "";
                        cmbbxEstCivil.Text = "";
                        chkbxHepatitis.Checked = false;
                        chkbxSifilis.Checked = false;
                        chkbxColera.Checked = false;
                        chkbxTosferina.Checked = false;
                        chkbxSarampion.Checked = false;
                        chkbxVaricela.Checked = false;
                        chkbxRubeola.Checked = false;
                        chkbxPariotiditis.Checked = false;
                        chkbxMeningitis.Checked = false;
                        chkbxImpetigo.Checked = false;
                        chkbxFiebreTi.Checked = false;
                        chkbxMalaria.Checked = false;
                        chkbxEscabiasis.Checked = false;
                        chkbxTina.Checked = false;
                        chkboxAlergias.Checked = false;
                        chkbxDiabetes.Checked = false;
                        chkbxHipertension.Checked = false;
                        chkbxReumatica.Checked = false;
                        chkbxRenales.Checked = false;
                        chkbxOculares.Checked = false;
                        chkbxCardiacas.Checked = false;
                        chkbxHepatica.Checked = false;
                        chkbxMusculares.Checked = false;
                        chkbxMalConge.Checked = false;
                        chkbxDesMentales.Checked = false;

                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Expediente");
                    }
                    btnRegistrar.Text = "Registrar";
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtbxIdExpe.Visible = true;
            txtbxIdExpe.Enabled = false;
            lblIdExpe.Visible = true;

            txtbxIdExpe.Text = dataGridViewExp.CurrentRow.Cells["IdExpediente"].Value.ToString();
            txtbxNumeroExp.Text = dataGridViewExp.CurrentRow.Cells["NumeroExpediente"].Value.ToString();
            txtbxMotiConsul.Text = dataGridViewExp.CurrentRow.Cells["MotivoConsulta"].Value.ToString();
            txtbxTrataIndiPac.Text = dataGridViewExp.CurrentRow.Cells["TratamientoIndicado"].Value.ToString();
            maskedtxtbxCedPac.Text = dataGridViewExp.CurrentRow.Cells["CedulaPac"].Value.ToString();
            txtbxNombrePac.Text = dataGridViewExp.CurrentRow.Cells["NombrePac"].Value.ToString();
            txtbxApellidosPac.Text = dataGridViewExp.CurrentRow.Cells["ApellidosPac"].Value.ToString();
            maskedtxtbxFechaNac.Text = dataGridViewExp.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
            txtbxLugarNac.Text = dataGridViewExp.CurrentRow.Cells["LugarNacimiento"].Value.ToString();
            cmbbxSexoPac.Text = dataGridViewExp.CurrentRow.Cells["SexoPac"].Value.ToString();
            txtbxEdadPac.Text = dataGridViewExp.CurrentRow.Cells["EdadPac"].Value.ToString();
            cmbbxGrupoEt.Text = dataGridViewExp.CurrentRow.Cells["GrupoEtnico"].Value.ToString();
            txtbxDirhabiPac.Text = dataGridViewExp.CurrentRow.Cells["DireccionHabitualPac"].Value.ToString();
            txtbxNombrePa.Text = dataGridViewExp.CurrentRow.Cells["NombrePadre"].Value.ToString();
            txtbxNombreMa.Text = dataGridViewExp.CurrentRow.Cells["NombreMadre"].Value.ToString();
            cmbbxReligionPac.Text = dataGridViewExp.CurrentRow.Cells["ReligionPac"].Value.ToString();
            txtbxProcedenciaPac.Text = dataGridViewExp.CurrentRow.Cells["ProcedenciaPac"].Value.ToString();
            maskedtxtbxTelefonoPac.Text = dataGridViewExp.CurrentRow.Cells["TelefonoPac"].Value.ToString();
            cmbbxEstCivil.Text = dataGridViewExp.CurrentRow.Cells["EstadoCivilPac"].Value.ToString();

            if (dataGridViewExp.CurrentRow.Cells["EnferICHepatitis"].Value.ToString() == "V")
            {
                chkbxHepatitis.Checked = true;
            }
            else
            {
                chkbxHepatitis.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferICSifilis"].Value.ToString() == "V")
            {
                chkbxSifilis.Checked = true;
            }
            else
            {
                chkbxSifilis.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferICColera"].Value.ToString() == "V")
            {
                chkbxColera.Checked = true;
            }
            else
            {
                chkbxColera.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferICTosferina"].Value.ToString() == "V")
            {
                chkbxTosferina.Checked = true;
            }
            else
            {
                chkbxTosferina.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferICSarampion"].Value.ToString() == "V")
            {
                chkbxSarampion.Checked = true;
            }
            else
            {
                chkbxSarampion.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferICVaricela"].Value.ToString() == "V")
            {
                chkbxVaricela.Checked = true;
            }
            else
            {
                chkbxVaricela.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferICRubeola"].Value.ToString() == "V")
            {
                chkbxRubeola.Checked = true;
            }
            else
            {
                chkbxRubeola.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferICPariotiditis"].Value.ToString() == "V")
            {
                chkbxPariotiditis.Checked = true;
            }
            else
            {
                chkbxPariotiditis.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferICMeningitis"].Value.ToString() == "V")
            {
                chkbxMeningitis.Checked = true;
            }
            else
            {
                chkbxMeningitis.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferICImpetigo"].Value.ToString() == "V")
            {
                chkbxImpetigo.Checked = true;
            }
            else
            {
                chkbxImpetigo.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferICTifoidea"].Value.ToString() == "V")
            {
                chkbxFiebreTi.Checked = true;
            }
            else
            {
                chkbxFiebreTi.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferICMalaria"].Value.ToString() == "V")
            {
                chkbxMalaria.Checked = true;
            }
            else
            {
                chkbxMalaria.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferICEscabiasis"].Value.ToString() == "V")
            {
                chkbxEscabiasis.Checked = true;
            }
            else
            {
                chkbxEscabiasis.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferICTina"].Value.ToString() == "V")
            {
                chkbxTina.Checked = true;
            }
            else
            {
                chkbxTina.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferHAlergias"].Value.ToString() == "V")
            {
                chkboxAlergias.Checked = true;
            }
            else
            {
                chkboxAlergias.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferHDiabetes"].Value.ToString() == "V")
            {
                chkbxDiabetes.Checked = true;
            }
            else
            {
                chkbxDiabetes.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferHHipertension"].Value.ToString() == "V")
            {
                chkbxHipertension.Checked = true;
            }
            else
            {
                chkbxHipertension.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferHReumatica"].Value.ToString() == "V")
            {
                chkbxReumatica.Checked = true;
            }
            else
            {
                chkbxReumatica.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferHRenales"].Value.ToString() == "V")
            {
                chkbxRenales.Checked = true;
            }
            else
            {
                chkbxRenales.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferHOculares"].Value.ToString() == "V")
            {
                chkbxOculares.Checked = true;
            }
            else
            {
                chkbxOculares.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferHCardiacas"].Value.ToString() == "V")
            {
                chkbxCardiacas.Checked = true;
            }
            else
            {
                chkbxCardiacas.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferHHepatica"].Value.ToString() == "V")
            {
                chkbxHepatica.Checked = true;
            }
            else
            {
                chkbxHepatica.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferHMusculares"].Value.ToString() == "V")
            {
                chkbxMusculares.Checked = true;
            }
            else
            {
                chkbxMusculares.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferHMalcongenitas"].Value.ToString() == "V")
            {
                chkbxMalConge.Checked = true;
            }
            else
            {
                chkbxMalConge.Checked = false;
            }
            if (dataGridViewExp.CurrentRow.Cells["EnferHDesorMentales"].Value.ToString() == "V")
            {
                chkbxDesMentales.Checked = true;
            }
            else
            {
                chkbxDesMentales.Checked = false;
            }


            btnRegistrar.Text = "Actualizar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigoEx = Convert.ToInt32(dataGridViewExp.CurrentRow.Cells["IdExpediente"].Value.ToString());
            try
            {
                if (LNExp.EliminarExpediente(codigoEx) > 0)
                {
                    MessageBox.Show("Eliminado con éxito");
                    dataGridViewExp.DataSource = LNExp.ListarExpediente();
                }
            }
            catch
            {
                MessageBox.Show("ERROR al eliminar Medico");
            }
        }
    }
}
