using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //agregar
using CapaEntidades; //referencias
using System.Data; //agregar


namespace CapaDatos
{
    public class AccesoDatosExpediente
    {

        SqlConnection cnx;
        Expediente Exp = new Expediente();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Expediente> listaExpediente = null;

        public int InsertarExpediente(Expediente Ex)
        {
            try
            {
                SqlConnection cnx = cn.Conectar(); // conectar
                cm = new SqlCommand("Expediente_Proced", cnx); //nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 1); //valores que toman los parametros del procedimiento
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@NumeroExpediente", Ex.NumeroExpediente);
                cm.Parameters.AddWithValue("@MotivoConsulta", Ex.MotivoConsulta);
                cm.Parameters.AddWithValue("@TratamientoIndicado", Ex.TratamientoIndicado);
                cm.Parameters.AddWithValue("@CedulaPac", Ex.CedulaPac);
                cm.Parameters.AddWithValue("@NombrePac", Ex.NombrePac);
                cm.Parameters.AddWithValue("@ApellidosPac", Ex.ApellidosPac);
                cm.Parameters.AddWithValue("@FechaNacimiento", Ex.FechaNacimiento);
                cm.Parameters.AddWithValue("@LugarNacimiento", Ex.LugarNacimiento);
                cm.Parameters.AddWithValue("@SexoPac", Ex.SexoPac);
                cm.Parameters.AddWithValue("@EdadPac", Ex.EdadPac);
                cm.Parameters.AddWithValue("@GrupoEtnico", Ex.GrupoEtnico);
                cm.Parameters.AddWithValue("@DireccionHabitualPac", Ex.DireccionHabitualPac);
                cm.Parameters.AddWithValue("@NombrePadre", Ex.NombrePadre);
                cm.Parameters.AddWithValue("@NombreMadre", Ex.NombreMadre);
                cm.Parameters.AddWithValue("@ReligionPac", Ex.ReligionPac);
                cm.Parameters.AddWithValue("@ProcedenciaPac", Ex.ProcedenciaPac);
                cm.Parameters.AddWithValue("@TelefonoPac", Ex.TelefonoPac);
                cm.Parameters.AddWithValue("@EstadoCivilPac", Ex.EstadoCivilPac);
                cm.Parameters.AddWithValue("@EnferICHepatitis", Ex.EnferICHepatitis);
                cm.Parameters.AddWithValue("@EnferICSifilis", Ex.EnferICSifilis);
                cm.Parameters.AddWithValue("@EnferICColera", Ex.EnferICColera);
                cm.Parameters.AddWithValue("@EnferICTosferina", Ex.EnferICTosferina);
                cm.Parameters.AddWithValue("@EnferICSarampion", Ex.EnferICSarampion);
                cm.Parameters.AddWithValue("@EnferICVaricela", Ex.EnferICVaricela);
                cm.Parameters.AddWithValue("@EnferICRubeola", Ex.EnferICRubeola);
                cm.Parameters.AddWithValue("@EnferICPariotiditis", Ex.EnferICPariotiditis);
                cm.Parameters.AddWithValue("@EnferICMeningitis", Ex.EnferICMeningitis);
                cm.Parameters.AddWithValue("@EnferICImpetigo", Ex.EnferICImpetigo);
                cm.Parameters.AddWithValue("@EnferICTifoidea", Ex.EnferICTifoidea);
                cm.Parameters.AddWithValue("@EnferICMalaria", Ex.EnferICMalaria);
                cm.Parameters.AddWithValue("@EnferICEscabiasis", Ex.EnferICEscabiasis);
                cm.Parameters.AddWithValue("@EnferICTina", Ex.EnferICTina);
                cm.Parameters.AddWithValue("@EnferHAlergias", Ex.EnferHAlergias);
                cm.Parameters.AddWithValue("@EnferHDiabetes", Ex.EnferHDiabetes);
                cm.Parameters.AddWithValue("@EnferHHipertension", Ex.EnferHHipertension);
                cm.Parameters.AddWithValue("@EnferHReumatica", Ex.EnferHReumatica);
                cm.Parameters.AddWithValue("@EnferHRenales", Ex.EnferHRenales);
                cm.Parameters.AddWithValue("@EnferHOculares", Ex.EnferHOculares);
                cm.Parameters.AddWithValue("@EnferHCardiacas", Ex.EnferHCardiacas);
                cm.Parameters.AddWithValue("@EnferHHepatica", Ex.EnferHHepatica);
                cm.Parameters.AddWithValue("@EnferHMusculares", Ex.EnferHMusculares);
                cm.Parameters.AddWithValue("@EnferHMalCongenitas", Ex.EnferHMalCongenitas);
                cm.Parameters.AddWithValue("@EnferHDesorMentales", Ex.EnferHDesorMentales);

                cm.CommandType = CommandType.StoredProcedure;// tipo de comando ejecutado
                cnx.Open(); // abrir conexion de BD
                cm.ExecuteNonQuery(); // ejecución de consulta
                indicador = 1; //valor del indicador
            }
            catch (Exception e)
            {

                e.Message.ToString(); //mostrar mensaje en caso de error
                indicador = 0;

            }

            finally
            {

                cm.Connection.Close(); //cierre de conexión

            }
            return indicador;
        }

        public List<Expediente> ListarExpediente()
        {

            try
            {

                SqlConnection cnx = cn.Conectar();//conectar
                cm = new SqlCommand("Expediente_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@NumeroExpediente", "");
                cm.Parameters.AddWithValue("@MotivoConsulta", "");
                cm.Parameters.AddWithValue("@TratamientoIndicado", "");
                cm.Parameters.AddWithValue("@CedulaPac", "");
                cm.Parameters.AddWithValue("@NombrePac", "");
                cm.Parameters.AddWithValue("@ApellidosPac", "");
                cm.Parameters.AddWithValue("@FechaNacimiento", "");
                cm.Parameters.AddWithValue("@LugarNacimiento", "");
                cm.Parameters.AddWithValue("@SexoPac", "");
                cm.Parameters.AddWithValue("@EdadPac", "");
                cm.Parameters.AddWithValue("@GrupoEtnico", "");
                cm.Parameters.AddWithValue("@DireccionHabitualPac", "");
                cm.Parameters.AddWithValue("@NombrePadre", "");
                cm.Parameters.AddWithValue("@NombreMadre", "");
                cm.Parameters.AddWithValue("@ReligionPac", "");
                cm.Parameters.AddWithValue("@ProcedenciaPac", "");
                cm.Parameters.AddWithValue("@TelefonoPac", "");
                cm.Parameters.AddWithValue("@EstadoCivilPac", "");
                cm.Parameters.AddWithValue("@EnferICHepatitis", "");
                cm.Parameters.AddWithValue("@EnferICSifilis", "");
                cm.Parameters.AddWithValue("@EnferICColera", "");
                cm.Parameters.AddWithValue("@EnferICTosferina", "");
                cm.Parameters.AddWithValue("@EnferICSarampion", "");
                cm.Parameters.AddWithValue("@EnferICVaricela", "");
                cm.Parameters.AddWithValue("@EnferICRubeola", "");
                cm.Parameters.AddWithValue("@EnferICPariotiditis", "");
                cm.Parameters.AddWithValue("@EnferICMeningitis", "");
                cm.Parameters.AddWithValue("@EnferICImpetigo", "");
                cm.Parameters.AddWithValue("@EnferICTifoidea", "");
                cm.Parameters.AddWithValue("@EnferICMalaria", "");
                cm.Parameters.AddWithValue("@EnferICEscabiasis", "");
                cm.Parameters.AddWithValue("@EnferICTina", "");
                cm.Parameters.AddWithValue("@EnferHAlergias", "");
                cm.Parameters.AddWithValue("@EnferHDiabetes", "");
                cm.Parameters.AddWithValue("@EnferHHipertension", "");
                cm.Parameters.AddWithValue("@EnferHReumatica", "");
                cm.Parameters.AddWithValue("@EnferHRenales", "");
                cm.Parameters.AddWithValue("@EnferHOculares", "");
                cm.Parameters.AddWithValue("@EnferHCardiacas", "");
                cm.Parameters.AddWithValue("@EnferHHepatica", "");
                cm.Parameters.AddWithValue("@EnferHMusculares", "");
                cm.Parameters.AddWithValue("@EnferHMalCongenitas", "");
                cm.Parameters.AddWithValue("@EnferHDesorMentales", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaExpediente = new List<Expediente>(); //lista de comentarios

                while (dr.Read()) //Recorre cada registro
                {

                    Expediente exp = new Expediente();

                    exp.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    exp.NumeroExpediente = dr["NumeroExpediente"].ToString();
                    exp.MotivoConsulta = dr["MotivoConsulta"].ToString();
                    exp.TratamientoIndicado = dr["TratamientoIndicado"].ToString();
                    exp.CedulaPac = dr["CedulaPac"].ToString();
                    exp.NombrePac = dr["NombrePac"].ToString();
                    exp.ApellidosPac = dr["ApellidosPac"].ToString();
                    exp.FechaNacimiento = dr["FechaNacimiento"].ToString();
                    exp.LugarNacimiento = dr["LugarNacimiento"].ToString();
                    exp.SexoPac = dr["SexoPac"].ToString();
                    exp.EdadPac = Convert.ToInt32(dr["EdadPac"].ToString());
                    exp.GrupoEtnico =dr["GrupoEtnico"].ToString();
                    exp.DireccionHabitualPac = dr["DireccionHabitualPac"].ToString();
                    exp.NombrePadre = dr["NombrePadre"].ToString();
                    exp.NombreMadre = dr["NombreMadre"].ToString();
                    exp.ReligionPac = dr["ReligionPac"].ToString();
                    exp.ProcedenciaPac = dr["ProcedenciaPac"].ToString();
                    exp.TelefonoPac = dr["TelefonoPac"].ToString();
                    exp.EstadoCivilPac = dr["EstadoCivilPac"].ToString();
                    exp.EnferICHepatitis = dr["EnferICHepatitis"].ToString();
                    exp.EnferICSifilis =dr["EnferICSifilis"].ToString();
                    exp.EnferICColera = dr["EnferICColera"].ToString();
                    exp.EnferICTosferina = dr["EnferICTosferina"].ToString();
                    exp.EnferICSarampion = dr["EnferICSarampion"].ToString();
                    exp.EnferICVaricela = dr["EnferICVaricela"].ToString();
                    exp.EnferICRubeola = dr["EnferICRubeola"].ToString();
                    exp.EnferICPariotiditis = dr["EnferICPariotiditis"].ToString();
                    exp.EnferICMeningitis = dr["EnferICMeningitis"].ToString();
                    exp.EnferICImpetigo = dr["EnferICImpetigo"].ToString();
                    exp.EnferICTifoidea = dr["EnferICTifoidea"].ToString();
                    exp.EnferICMalaria = dr["EnferICMalaria"].ToString();
                    exp.EnferICEscabiasis = dr["EnferICEscabiasis"].ToString();
                    exp.EnferICTina = dr["EnferICTina"].ToString();
                    exp.EnferHAlergias = dr["EnferHAlergias"].ToString();
                    exp.EnferHDiabetes = dr["EnferHDiabetes"].ToString();
                    exp.EnferHHipertension = dr["EnferHHipertension"].ToString();
                    exp.EnferHReumatica = dr["EnferHReumatica"].ToString();
                    exp.EnferHRenales = dr["EnferHRenales"].ToString();
                    exp.EnferHOculares = dr["EnferHOculares"].ToString();
                    exp.EnferHCardiacas = dr["EnferHCardiacas"].ToString();
                    exp.EnferHHepatica = dr["EnferHHepatica"].ToString();
                    exp.EnferHMusculares = dr["EnferHMusculares"].ToString();
                    exp.EnferHMalCongenitas = dr["EnferHMalCongenitas"].ToString();
                    exp.EnferHDesorMentales = dr["EnferHDesorMentales"].ToString();

                    listaExpediente.Add(exp);

                }

            }


            catch (Exception e)
            {
                e.Message.ToString();
                listaExpediente = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaExpediente; //regresa lista de registros

        }

        public int EliminarExpediente(int NumeroExpediente)
        {

            try
            {

                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Expdiente_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdExpediente", NumeroExpediente);


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                indicador = 1;
            }
            catch (Exception e)
            {

                e.Message.ToString();
                indicador = 0;

            }

            finally
            {
                cm.Connection.Close();
            }

            return indicador;

        }

        //editar comentarios

        public int EditarExpediente(Expediente Exp)
        {
            try
            {
                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Expediente_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@NumeroExpediente", "");
                cm.Parameters.AddWithValue("@MotivoConsulta", "");
                cm.Parameters.AddWithValue("@TratamientoIndicado", "");
                cm.Parameters.AddWithValue("@CedulaPac", "");
                cm.Parameters.AddWithValue("@NombrePac", Exp.NombrePac);
                cm.Parameters.AddWithValue("@ApellidosPac", Exp.ApellidosPac);
                cm.Parameters.AddWithValue("@FechaNacimiento", "");
                cm.Parameters.AddWithValue("@LugarNacimiento", "");
                cm.Parameters.AddWithValue("@SexoPac", "");
                cm.Parameters.AddWithValue("@EdadPac", Exp.EdadPac);
                cm.Parameters.AddWithValue("@GrupoEtnico", "");
                cm.Parameters.AddWithValue("@DireccionHabitualPac", Exp.DireccionHabitualPac);
                cm.Parameters.AddWithValue("@NombrePadre", "");
                cm.Parameters.AddWithValue("@NombreMadre", "");
                cm.Parameters.AddWithValue("@ReligionPac", "");
                cm.Parameters.AddWithValue("@ProcedenciaPac", Exp.ProcedenciaPac);
                cm.Parameters.AddWithValue("@TelefonoPac", Exp.TelefonoPac);
                cm.Parameters.AddWithValue("@EstadoCivilPac", Exp.EstadoCivilPac);
                cm.Parameters.AddWithValue("@EnferICHepatitis", "");
                cm.Parameters.AddWithValue("@EnferICSifilis", "");
                cm.Parameters.AddWithValue("@EnferICColera", "");
                cm.Parameters.AddWithValue("@EnferICTosferina", "");
                cm.Parameters.AddWithValue("@EnferICSarampion", "");
                cm.Parameters.AddWithValue("@EnferICVaricela", "");
                cm.Parameters.AddWithValue("@EnferICRubeola", "");
                cm.Parameters.AddWithValue("@EnferICPariotiditis", "");
                cm.Parameters.AddWithValue("@EnferICMeningitis", "");
                cm.Parameters.AddWithValue("@EnferICImpetigo", "");
                cm.Parameters.AddWithValue("@EnferICTifoidea", "");
                cm.Parameters.AddWithValue("@EnferICMalaria", "");
                cm.Parameters.AddWithValue("@EnferICEscabiasis", "");
                cm.Parameters.AddWithValue("EnferICTina", "");
                cm.Parameters.AddWithValue("@EnferHAlergias", "");
                cm.Parameters.AddWithValue("@EnferHDiabetes", "");
                cm.Parameters.AddWithValue("@EnferHHipertension", "");
                cm.Parameters.AddWithValue("@EnferHReumatica", "");
                cm.Parameters.AddWithValue("@EnferHRenales", "");
                cm.Parameters.AddWithValue("@EnferHOculares", "");
                cm.Parameters.AddWithValue("@EnferHCardiacas", "");
                cm.Parameters.AddWithValue("@EnferHHepatica", "");
                cm.Parameters.AddWithValue("@EnferHMusculares", "");
                cm.Parameters.AddWithValue("@EnferHMalCongenitas", "");
                cm.Parameters.AddWithValue("@EnferHDesorMentales", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {

                e.Message.ToString();
                indicador = 0;

            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }
        //buscar comentarios

        public List<Expediente> BuscarExpediente(string dato)
        {
            try
            {

                SqlConnection cnx = cn.Conectar();//conectar
                cm = new SqlCommand("Expediente_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@NumeroExpediente", "");
                cm.Parameters.AddWithValue("@MotivoConsulta", "");
                cm.Parameters.AddWithValue("@TratamientoIndicado", "");
                cm.Parameters.AddWithValue("@CedulaPac", dato);
                cm.Parameters.AddWithValue("@NombrePac", dato);
                cm.Parameters.AddWithValue("@ApellidosPac", "");
                cm.Parameters.AddWithValue("@FechaNacimiento", "");
                cm.Parameters.AddWithValue("@LugarNacimiento", "");
                cm.Parameters.AddWithValue("@SexoPac", "");
                cm.Parameters.AddWithValue("@EdadPac", "");
                cm.Parameters.AddWithValue("@GrupoEtnico", "");
                cm.Parameters.AddWithValue("@DireccionHabitualPac", "");
                cm.Parameters.AddWithValue("@NombrePadre", "");
                cm.Parameters.AddWithValue("@NombreMadre", "");
                cm.Parameters.AddWithValue("@ReligionPac", "");
                cm.Parameters.AddWithValue("@ProcedenciaPac", "");
                cm.Parameters.AddWithValue("@TelefonoPac", "");
                cm.Parameters.AddWithValue("@EstadoCivilPac", "");
                cm.Parameters.AddWithValue("@EnferICHepatitis", "");
                cm.Parameters.AddWithValue("@EnferICSifilis", "");
                cm.Parameters.AddWithValue("@EnferICColera", "");
                cm.Parameters.AddWithValue("@EnferICTosferina", "");
                cm.Parameters.AddWithValue("@EnferICSarampion", "");
                cm.Parameters.AddWithValue("@EnferICVaricela", "");
                cm.Parameters.AddWithValue("@EnferICRubeola", "");
                cm.Parameters.AddWithValue("@EnferICPariotiditis", "");
                cm.Parameters.AddWithValue("@EnferICMeningitis", "");
                cm.Parameters.AddWithValue("@EnferICImpetigo", "");
                cm.Parameters.AddWithValue("@EnferICTifoidea", "");
                cm.Parameters.AddWithValue("@EnferICMalaria", "");
                cm.Parameters.AddWithValue("@EnferICEscabiasis", "");
                cm.Parameters.AddWithValue("@EnferICTina", "");
                cm.Parameters.AddWithValue("@EnferHAlergias", "");
                cm.Parameters.AddWithValue("@EnferHDiabetes", "");
                cm.Parameters.AddWithValue("@EnferHHipertension", "");
                cm.Parameters.AddWithValue("@EnferHReumatica", "");
                cm.Parameters.AddWithValue("@EnferHRenales", "");
                cm.Parameters.AddWithValue("@EnferHOculares", "");
                cm.Parameters.AddWithValue("@EnferHCardiacas", "");
                cm.Parameters.AddWithValue("@EnferHHepatica", "");
                cm.Parameters.AddWithValue("@EnferHMusculares", "");
                cm.Parameters.AddWithValue("@EnferHMalCongenitas", "");
                cm.Parameters.AddWithValue("@EnferHDesorMentales", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaExpediente = new List<Expediente>(); //lista de comentarios

                while (dr.Read()) //Recorre cada registro
                {

                    Expediente exp = new Expediente();

                    exp.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    exp.NumeroExpediente = dr["NumeroExpediente"].ToString();
                    exp.MotivoConsulta = dr["MotivoConsulta"].ToString();
                    exp.TratamientoIndicado = dr["TratamientoIndicado"].ToString();
                    exp.CedulaPac = dr["CedulaPac"].ToString();
                    exp.NombrePac = dr["NombrePac"].ToString();
                    exp.ApellidosPac = dr["ApellidosPac"].ToString();
                    exp.FechaNacimiento = dr["FechaNacimiento"].ToString();
                    exp.LugarNacimiento = dr["LugarNacimiento"].ToString();
                    exp.SexoPac = dr["SexoPac"].ToString();
                    exp.EdadPac = Convert.ToInt32(dr["EdadPac"].ToString());
                    exp.GrupoEtnico = dr["GrupoEtnico"].ToString();
                    exp.DireccionHabitualPac = dr["DireccionHabitualPac"].ToString();
                    exp.NombrePadre = dr["NombrePadre"].ToString();
                    exp.NombreMadre = dr["NombreMadre"].ToString();
                    exp.ReligionPac = dr["ReligionPac"].ToString();
                    exp.ProcedenciaPac = dr["ProcedenciaPac"].ToString();
                    exp.TelefonoPac = dr["TelefonoPac"].ToString();
                    exp.EstadoCivilPac = dr["EstadoCivilPac"].ToString();
                    exp.EnferICHepatitis = dr["EnferICHepatitis"].ToString();
                    exp.EnferICSifilis = dr["EnferICSifilis"].ToString();
                    exp.EnferICColera = dr["EnferICColera"].ToString();
                    exp.EnferICTosferina = dr["EnferICTosferina"].ToString();
                    exp.EnferICSarampion = dr["EnferICSarampion"].ToString();
                    exp.EnferICVaricela = dr["EnferICVaricela"].ToString();
                    exp.EnferICRubeola = dr["EnferICRubeola"].ToString();
                    exp.EnferICPariotiditis = dr["EnferICPariotiditis"].ToString();
                    exp.EnferICMeningitis = dr["EnferICMeningitis"].ToString();
                    exp.EnferICImpetigo = dr["EnferICImpetigo"].ToString();
                    exp.EnferICTifoidea = dr["EnferICTifoidea"].ToString();
                    exp.EnferICMalaria = dr["EnferICMalaria"].ToString();
                    exp.EnferICEscabiasis = dr["EnferICEscabiasis"].ToString();
                    exp.EnferICTina = dr["EnferICTina"].ToString();
                    exp.EnferHAlergias = dr["EnferHAlergias"].ToString();
                    exp.EnferHDiabetes = dr["EnferHDiabetes"].ToString();
                    exp.EnferHHipertension = dr["EnferHHipertension"].ToString();
                    exp.EnferHReumatica = dr["EnferHReumatica"].ToString();
                    exp.EnferHRenales = dr["EnferHRenales"].ToString();
                    exp.EnferHOculares = dr["EnferHOculares"].ToString();
                    exp.EnferHCardiacas = dr["EnferHCardiacas"].ToString();
                    exp.EnferHHepatica = dr["EnferHHepatica"].ToString();
                    exp.EnferHMusculares = dr["EnferHMusculares"].ToString();
                    exp.EnferHMalCongenitas = dr["EnferHMalCongenitas"].ToString();
                    exp.EnferHDesorMentales = dr["EnferHDesorMentales"].ToString();

                    listaExpediente.Add(exp);

                }

            }


            catch (Exception e)
            {
                e.Message.ToString();
                listaExpediente = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaExpediente; //regresa lista de registros
        }

        public List<Expediente> ListarExpedienteId(int IdExpe)
        {

            try
            {

                SqlConnection cnx = cn.Conectar();//conectar
                cm = new SqlCommand("Expediente_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 6);
                cm.Parameters.AddWithValue("@IdExpediente", IdExpe);
                cm.Parameters.AddWithValue("@NumeroExpediente", "");
                cm.Parameters.AddWithValue("@MotivoConsulta", "");
                cm.Parameters.AddWithValue("@TratamientoIndicado", "");
                cm.Parameters.AddWithValue("@CedulaPac", "");
                cm.Parameters.AddWithValue("@NombrePac", "");
                cm.Parameters.AddWithValue("@ApellidosPac", "");
                cm.Parameters.AddWithValue("@FechaNacimiento", "");
                cm.Parameters.AddWithValue("@LugarNacimiento", "");
                cm.Parameters.AddWithValue("@SexoPac", "");
                cm.Parameters.AddWithValue("@EdadPac", "");
                cm.Parameters.AddWithValue("@GrupoEtnico", "");
                cm.Parameters.AddWithValue("@DireccionHabitualPac", "");
                cm.Parameters.AddWithValue("@NombrePadre", "");
                cm.Parameters.AddWithValue("@NombreMadre", "");
                cm.Parameters.AddWithValue("@ReligionPac", "");
                cm.Parameters.AddWithValue("@ProcedenciaPac", "");
                cm.Parameters.AddWithValue("@TelefonoPac", "");
                cm.Parameters.AddWithValue("@EstadoCivilPac", "");
                cm.Parameters.AddWithValue("@EnferICHepatitis", "");
                cm.Parameters.AddWithValue("@EnferICSifilis", "");
                cm.Parameters.AddWithValue("@EnferICColera", "");
                cm.Parameters.AddWithValue("@EnferICTosferina", "");
                cm.Parameters.AddWithValue("@EnferICSarampion", "");
                cm.Parameters.AddWithValue("@EnferICVaricela", "");
                cm.Parameters.AddWithValue("@EnferICRubeola", "");
                cm.Parameters.AddWithValue("@EnferICPariotiditis", "");
                cm.Parameters.AddWithValue("@EnferICMeningitis", "");
                cm.Parameters.AddWithValue("@EnferICImpetigo", "");
                cm.Parameters.AddWithValue("@EnferICTifoidea", "");
                cm.Parameters.AddWithValue("@EnferICMalaria", "");
                cm.Parameters.AddWithValue("@EnferICEscabiasis", "");
                cm.Parameters.AddWithValue("@EnferICTina", "");
                cm.Parameters.AddWithValue("@EnferHAlergias", "");
                cm.Parameters.AddWithValue("@EnferHDiabetes", "");
                cm.Parameters.AddWithValue("@EnferHHipertension", "");
                cm.Parameters.AddWithValue("@EnferHReumatica", "");
                cm.Parameters.AddWithValue("@EnferHRenales", "");
                cm.Parameters.AddWithValue("@EnferHOculares", "");
                cm.Parameters.AddWithValue("@EnferHCardiacas", "");
                cm.Parameters.AddWithValue("@EnferHHepatica", "");
                cm.Parameters.AddWithValue("@EnferHMusculares", "");
                cm.Parameters.AddWithValue("@EnferHMalCongenitas", "");
                cm.Parameters.AddWithValue("@EnferHDesorMentales", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaExpediente = new List<Expediente>(); //lista de comentarios

                while (dr.Read()) //Recorre cada registro
                {

                    Expediente exp = new Expediente();

                    exp.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    exp.NumeroExpediente = dr["NumeroExpediente"].ToString();
                    exp.MotivoConsulta = dr["MotivoConsulta"].ToString();
                    exp.TratamientoIndicado = dr["TratamientoIndicado"].ToString();
                    exp.CedulaPac = dr["CedulaPac"].ToString();
                    exp.NombrePac = dr["NombrePac"].ToString();
                    exp.ApellidosPac = dr["ApellidosPac"].ToString();
                    exp.FechaNacimiento = dr["FechaNacimiento"].ToString();
                    exp.LugarNacimiento = dr["LugarNacimiento"].ToString();
                    exp.SexoPac = dr["SexoPac"].ToString();
                    exp.EdadPac = Convert.ToInt32(dr["EdadPac"].ToString());
                    exp.GrupoEtnico = dr["GrupoEtnico"].ToString();
                    exp.DireccionHabitualPac = dr["DireccionHabitualPac"].ToString();
                    exp.NombrePadre = dr["NombrePadre"].ToString();
                    exp.NombreMadre = dr["NombreMadre"].ToString();
                    exp.ReligionPac = dr["ReligionPac"].ToString();
                    exp.ProcedenciaPac = dr["ProcedenciaPac"].ToString();
                    exp.TelefonoPac = dr["TelefonoPac"].ToString();
                    exp.EstadoCivilPac = dr["EstadoCivilPac"].ToString();
                    exp.EnferICHepatitis = dr["EnferICHepatitis"].ToString();
                    exp.EnferICSifilis = dr["EnferICSifilis"].ToString();
                    exp.EnferICColera = dr["EnferICColera"].ToString();
                    exp.EnferICTosferina = dr["EnferICTosferina"].ToString();
                    exp.EnferICSarampion = dr["EnferICSarampion"].ToString();
                    exp.EnferICVaricela = dr["EnferICVaricela"].ToString();
                    exp.EnferICRubeola = dr["EnferICRubeola"].ToString();
                    exp.EnferICPariotiditis = dr["EnferICPariotiditis"].ToString();
                    exp.EnferICMeningitis = dr["EnferICMeningitis"].ToString();
                    exp.EnferICImpetigo = dr["EnferICImpetigo"].ToString();
                    exp.EnferICTifoidea = dr["EnferICTifoidea"].ToString();
                    exp.EnferICMalaria = dr["EnferICMalaria"].ToString();
                    exp.EnferICEscabiasis = dr["EnferICEscabiasis"].ToString();
                    exp.EnferICTina = dr["EnferICTina"].ToString();
                    exp.EnferHAlergias = dr["EnferHAlergias"].ToString();
                    exp.EnferHDiabetes = dr["EnferHDiabetes"].ToString();
                    exp.EnferHHipertension = dr["EnferHHipertension"].ToString();
                    exp.EnferHReumatica = dr["EnferHReumatica"].ToString();
                    exp.EnferHRenales = dr["EnferHRenales"].ToString();
                    exp.EnferHOculares = dr["EnferHOculares"].ToString();
                    exp.EnferHCardiacas = dr["EnferHCardiacas"].ToString();
                    exp.EnferHHepatica = dr["EnferHHepatica"].ToString();
                    exp.EnferHMusculares = dr["EnferHMusculares"].ToString();
                    exp.EnferHMalCongenitas = dr["EnferHMalCongenitas"].ToString();
                    exp.EnferHDesorMentales = dr["EnferHDesorMentales"].ToString();

                    listaExpediente.Add(exp);

                }

            }


            catch (Exception e)
            {
                e.Message.ToString();
                listaExpediente = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaExpediente; //regresa lista de registros

        }


        public List<Expediente> ListarExpedienteMed(int IdMed)
        {

            try
            {

                SqlConnection cnx = cn.Conectar();//conectar
                cm = new SqlCommand("PacienteMedico_Proced", cnx);
                cm.Parameters.AddWithValue("@IdMedico", IdMed);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@NombrePac", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaExpediente = new List<Expediente>(); //lista de comentarios

                while (dr.Read()) //Recorre cada registro
                {

                    Expediente exp = new Expediente();

                    exp.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    exp.NumeroExpediente = dr["NumeroExpediente"].ToString();
                    exp.MotivoConsulta = dr["MotivoConsulta"].ToString();
                    exp.TratamientoIndicado = dr["TratamientoIndicado"].ToString();
                    exp.CedulaPac = dr["CedulaPac"].ToString();
                    exp.NombrePac = dr["NombrePac"].ToString();
                    exp.ApellidosPac = dr["ApellidosPac"].ToString();
                    exp.FechaNacimiento = dr["FechaNacimiento"].ToString();
                    exp.LugarNacimiento = dr["LugarNacimiento"].ToString();
                    exp.SexoPac = dr["SexoPac"].ToString();
                    exp.EdadPac = Convert.ToInt32(dr["EdadPac"].ToString());
                    exp.GrupoEtnico = dr["GrupoEtnico"].ToString();
                    exp.DireccionHabitualPac = dr["DireccionHabitualPac"].ToString();
                    exp.NombrePadre = dr["NombrePadre"].ToString();
                    exp.NombreMadre = dr["NombreMadre"].ToString();
                    exp.ReligionPac = dr["ReligionPac"].ToString();
                    exp.ProcedenciaPac = dr["ProcedenciaPac"].ToString();
                    exp.TelefonoPac = dr["TelefonoPac"].ToString();
                    exp.EstadoCivilPac = dr["EstadoCivilPac"].ToString();
                    exp.EnferICHepatitis = dr["EnferICHepatitis"].ToString();
                    exp.EnferICSifilis = dr["EnferICSifilis"].ToString();
                    exp.EnferICColera = dr["EnferICColera"].ToString();
                    exp.EnferICTosferina = dr["EnferICTosferina"].ToString();
                    exp.EnferICSarampion = dr["EnferICSarampion"].ToString();
                    exp.EnferICVaricela = dr["EnferICVaricela"].ToString();
                    exp.EnferICRubeola = dr["EnferICRubeola"].ToString();
                    exp.EnferICPariotiditis = dr["EnferICPariotiditis"].ToString();
                    exp.EnferICMeningitis = dr["EnferICMeningitis"].ToString();
                    exp.EnferICImpetigo = dr["EnferICImpetigo"].ToString();
                    exp.EnferICTifoidea = dr["EnferICTifoidea"].ToString();
                    exp.EnferICMalaria = dr["EnferICMalaria"].ToString();
                    exp.EnferICEscabiasis = dr["EnferICEscabiasis"].ToString();
                    exp.EnferICTina = dr["EnferICTina"].ToString();
                    exp.EnferHAlergias = dr["EnferHAlergias"].ToString();
                    exp.EnferHDiabetes = dr["EnferHDiabetes"].ToString();
                    exp.EnferHHipertension = dr["EnferHHipertension"].ToString();
                    exp.EnferHReumatica = dr["EnferHReumatica"].ToString();
                    exp.EnferHRenales = dr["EnferHRenales"].ToString();
                    exp.EnferHOculares = dr["EnferHOculares"].ToString();
                    exp.EnferHCardiacas = dr["EnferHCardiacas"].ToString();
                    exp.EnferHHepatica = dr["EnferHHepatica"].ToString();
                    exp.EnferHMusculares = dr["EnferHMusculares"].ToString();
                    exp.EnferHMalCongenitas = dr["EnferHMalCongenitas"].ToString();
                    exp.EnferHDesorMentales = dr["EnferHDesorMentales"].ToString();

                    listaExpediente.Add(exp);

                }

            }


            catch (Exception e)
            {
                e.Message.ToString();
                listaExpediente = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaExpediente; //regresa lista de registros

        }
    }
}
