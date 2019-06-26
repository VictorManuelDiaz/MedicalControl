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
    class AccesoDatosExpediente
    {

        SqlConnection cnx; //conexion
        Expediente Exp= new Expediente(); // capa entidades
        Conexion cn = new Conexion(); // conexion
        SqlCommand cm = null; //Comandos sql
        int indicador = 0; // variable indicador para comprobar CRUD para cargar datos
        SqlDataReader dr = null;
        List<Expediente> listaExpediente = null;

        public int InsertarExpediente(Expediente Ex)
        {
            try
            {
                SqlConnection cnx = cn.Conectar(); // conectar
                cm = new SqlCommand("Expediente_Proced", cnx); //nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 1); //valores que toman los parametros del procedimiento
                cm.Parameters.AddWithValue("@NumeroExpediente", "");
                cm.Parameters.AddWithValue("@MotivoConsulta",Ex.MotivoConsulta );
                cm.Parameters.AddWithValue("@TratamientoIndicado", Ex.TratamientoIndicado);
                cm.Parameters.AddWithValue("@CedulaPac", Ex.CedulaPac);
                cm.Parameters.AddWithValue("@NombrePac", Ex.NombrePac);
                cm.Parameters.AddWithValue("@ApellidoPac", Ex.ApellidosPac);
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

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaExpediente = new List<Expediente>(); //lista de comentarios

                while (dr.Read()) //Recorre cada registro
                {

                    Expediente exp = new Expediente();

                    exp.NumeroExpediente = Convert.ToInt32(dr["NumeroExpediente"].ToString());
                    exp.MotivoConsulta = dr["MotivoConsulta"].ToString();
                    exp.TratamientoIndicado = dr["TratamientoIndicado"].ToString();
                    exp.CedulaPac = dr["CedulaPac"].ToString();
                    exp.NombrePac = dr["NombrePac"].ToString();
                    exp.ApellidosPac = dr["ApellidoPac"].ToString();
                    exp.FechaNacimiento = dr["FechaNacimiento"].ToString();
                    exp.LugarNacimiento = dr["LugarNacimiento"].ToString();
                    exp.EdadPac = Convert.ToInt32(dr["EdadPac"].ToString());
                    exp.GrupoEtnico = Convert.ToInt32(dr["GrupoEtnico"].ToString());
                    exp.DireccionHabitualPac = dr["DireccionHabitualPac"].ToString();
                    exp.NombrePadre = dr["NombrePadre"].ToString();
                    exp.NombreMadre = dr["NombreMadre"].ToString();
                    exp.ReligionPac = dr["ReligionPac"].ToString();
                    exp.ProcedenciaPac = dr["ProcedenciaPac"].ToString();
                    exp.TelefonoPac = dr["TelefonoPac"].ToString();
                    exp.EstadoCivilPac = dr["EstadoCivilPac"].ToString();

                    listaExpediente.Add(exp); //agergar registros encontrados a la lista

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
                cm.Parameters.AddWithValue("@NumeroExpediente", NumeroExpediente);
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

                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("Medico_Proced", cnx);
                cm.Parameters.AddWithValue("@NumeroExpediente", "");
                cm.Parameters.AddWithValue("@MotivoConsulta", "");
                cm.Parameters.AddWithValue("@TratamientoIndicado", "");
                cm.Parameters.AddWithValue("@CedulaPac", dato);
                cm.Parameters.AddWithValue("@NombrePac", dato);
                cm.Parameters.AddWithValue("@ApellidosPac", dato);
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


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaExpediente = new List<Expediente>();

                while (dr.Read()) //Recorre cada registro
                {

                    Expediente exp = new Expediente();

                    exp.NumeroExpediente = Convert.ToInt32(dr["NumeroExpediente"].ToString());
                    exp.MotivoConsulta = dr["MotivoConsulta"].ToString();
                    exp.TratamientoIndicado = dr["TratamientoIndicado"].ToString();
                    exp.CedulaPac = dr["CedulaPac"].ToString();
                    exp.NombrePac = dr["NombrePac"].ToString();
                    exp.ApellidosPac = dr["ApellidoPac"].ToString();
                    exp.FechaNacimiento = dr["FechaNacimiento"].ToString();
                    exp.LugarNacimiento = dr["LugarNacimiento"].ToString();
                    exp.EdadPac = Convert.ToInt32(dr["EdadPac"].ToString());
                    exp.GrupoEtnico = Convert.ToInt32(dr["GrupoEtnico"].ToString());
                    exp.DireccionHabitualPac = dr["DireccionHabitualPac"].ToString();
                    exp.NombrePadre = dr["NombrePadre"].ToString();
                    exp.NombreMadre = dr["NombreMadre"].ToString();
                    exp.ReligionPac = dr["ReligionPac"].ToString();
                    exp.ProcedenciaPac = dr["ProcedenciaPac"].ToString();
                    exp.TelefonoPac = dr["TelefonoPac"].ToString();
                    exp.EstadoCivilPac = dr["EstadoCivilPac"].ToString();
                    listaExpediente.Add(exp); //agergar registros encontrados a la lista

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
            return listaExpediente;
        }

    }
}
