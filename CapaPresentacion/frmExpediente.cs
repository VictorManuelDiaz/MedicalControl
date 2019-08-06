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

        private void frmExpediente_Load(object sender, EventArgs e)
        {
            dataGridViewExp.DataSource = LNExp.ListarExpediente();
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnRegistrar.Text == "Registrar")
                {
                    Expediente objetoExpediente= new Expediente ();
                    objetoExpediente.NumeroExpediente = txtbxNumeroExp.Text;
                    objetoExpediente.MotivoConsulta = txtbxMotiConsul.Text;
                    objetoExpediente.TratamientoIndicado = txtbxTrataIndiPac.Text;
                    objetoExpediente.CedulaPac = maskedtxtbxCedPac.Text;
                    objetoExpediente.NombrePac = txtbxNombrePac.Text;
                    objetoExpediente.ApellidosPac = txtbxApellidosPac.Text;
                    objetoExpediente.FechaNacimiento = mtxtbxFechaNac.Text;
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
                    objetoExpediente.ReligionPac = cbxReligionPac.Text;
                    objetoExpediente.ProcedenciaPac = txtbxProcedenciaPac.Text;
                    objetoExpediente.TelefonoPac = maskedtxtbxTelefonoPac.Text;
                    objetoExpediente.EstadoCivilPac = cmbbxEstCivil.Text;

                    if (chkbxHepatitis.Checked==true)
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
                        mtxtbxFechaNac.Text = "";
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
                        chkbxHepatitis.Checked=false;
                        chkbxSifilis.Checked=false;
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
                    objetoExpediente.FechaNacimiento = mtxtbxFechaNac.Text;
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
                    objetoExpediente.ReligionPac = cbxReligionPac.Text;
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
                        mtxtbxFechaNac.Text = "";
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

        private void txtbxBuscar_Click(object sender, EventArgs e)
        {
            List<Expediente> listaExpe = LNExp.BuscarExpediente(txtbxBuscar.text);
            dataGridViewExp.DataSource = listaExpe;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtbxIdExpe.Visible = true;
            txtbxIdExpe.Enabled = false;
            lblIdExpe.Visible = true;


        }
    }
}
