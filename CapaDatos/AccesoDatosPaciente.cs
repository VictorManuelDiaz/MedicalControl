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
    public class AccesoDatosPaciente
    {

        SqlConnection cnx;
        Expediente Exp = new Expediente();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Paciente> listaPaciente = null;

        public int InsertarPaciente(Paciente Pac)
        {
            try
            {
                SqlConnection cnx = cn.Conectar(); // conectar
                cm = new SqlCommand("Paciente_Proced", cnx); //nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@NumeroExpediente", Pac.NumeroExpediente);
                cm.Parameters.AddWithValue("@CedulaPac", Pac.CedulaPac);
                cm.Parameters.AddWithValue("@NombrePac", Pac.NombrePac);
                cm.Parameters.AddWithValue("@ApellidosPac", Pac.ApellidosPac);
                cm.Parameters.AddWithValue("@FechaNacimiento", Pac.FechaNacimiento);
                cm.Parameters.AddWithValue("@LugarNacimiento", Pac.LugarNacimiento);
                cm.Parameters.AddWithValue("@SexoPac", Pac.SexoPac);
                cm.Parameters.AddWithValue("@EdadPac", Pac.EdadPac);
                cm.Parameters.AddWithValue("@GrupoEtnico", Pac.GrupoEtnico);
                cm.Parameters.AddWithValue("@DireccionHabitualPac", Pac.DireccionHabitualPac);
                cm.Parameters.AddWithValue("@NombrePadre", Pac.NombrePadre);
                cm.Parameters.AddWithValue("@NombreMadre", Pac.NombreMadre);
                cm.Parameters.AddWithValue("@ReligionPac", Pac.ReligionPac);
                cm.Parameters.AddWithValue("@ProcedenciaPac", Pac.ProcedenciaPac);
                cm.Parameters.AddWithValue("@TelefonoPac", Pac.TelefonoPac);
                cm.Parameters.AddWithValue("@EstadoCivilPac", Pac.EstadoCivilPac);
                

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

        public List<Paciente> ListarPaciente()
        {

            try
            {

                SqlConnection cnx = cn.Conectar();//conectar
                cm = new SqlCommand("Paciente_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@NumeroExpediente", "");
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
                listaPaciente = new List<Paciente>(); //lista de comentarios

                while (dr.Read()) //Recorre cada registro
                {

                    Paciente pac = new Paciente();

                    pac.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    pac.NumeroExpediente = dr["NumeroExpediente"].ToString();
                    pac.CedulaPac = dr["CedulaPac"].ToString();
                    pac.NombrePac = dr["NombrePac"].ToString();
                    pac.ApellidosPac = dr["ApellidosPac"].ToString();
                    pac.FechaNacimiento = dr["FechaNacimiento"].ToString();
                    pac.LugarNacimiento = dr["LugarNacimiento"].ToString();
                    pac.SexoPac = dr["SexoPac"].ToString();
                    pac.EdadPac = Convert.ToInt32(dr["EdadPac"].ToString());
                    pac.GrupoEtnico = dr["GrupoEtnico"].ToString();
                    pac.DireccionHabitualPac = dr["DireccionHabitualPac"].ToString();
                    pac.NombrePadre = dr["NombrePadre"].ToString();
                    pac.NombreMadre = dr["NombreMadre"].ToString();
                    pac.ReligionPac = dr["ReligionPac"].ToString();
                    pac.ProcedenciaPac = dr["ProcedenciaPac"].ToString();
                    pac.TelefonoPac = dr["TelefonoPac"].ToString();
                    pac.EstadoCivilPac = dr["EstadoCivilPac"].ToString();

                    listaPaciente.Add(pac); //agergar registros encontrados a la lista

                }

            }


            catch (Exception e)
            {
                e.Message.ToString();
                listaPaciente = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaPaciente; //regresa lista de registros

        }

        public int EliminarPaciente(int NumeroPac)
        {

            try
            {

                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Paciente_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdExpediente", NumeroPac);


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

        public int EditarPaciente(Paciente Pac)
        {
            try
            {
                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Paciente_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@NumeroExpediente", "");
                cm.Parameters.AddWithValue("@CedulaPac", "");
                cm.Parameters.AddWithValue("@NombrePac", Pac.NombrePac);
                cm.Parameters.AddWithValue("@ApellidosPac", Pac.ApellidosPac);
                cm.Parameters.AddWithValue("@FechaNacimiento", "");
                cm.Parameters.AddWithValue("@LugarNacimiento", "");
                cm.Parameters.AddWithValue("@SexoPac", "");
                cm.Parameters.AddWithValue("@EdadPac", Pac.EdadPac);
                cm.Parameters.AddWithValue("@GrupoEtnico", "");
                cm.Parameters.AddWithValue("@DireccionHabitualPac", Pac.DireccionHabitualPac);
                cm.Parameters.AddWithValue("@NombrePadre", "");
                cm.Parameters.AddWithValue("@NombreMadre", "");
                cm.Parameters.AddWithValue("@ReligionPac", "");
                cm.Parameters.AddWithValue("@ProcedenciaPac", Pac.ProcedenciaPac);
                cm.Parameters.AddWithValue("@TelefonoPac", Pac.TelefonoPac);
                cm.Parameters.AddWithValue("@EstadoCivilPac", Pac.EstadoCivilPac);

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

        public List<Paciente> BuscarPaciente(string dato)
        {
            try
            {

                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("Paciente_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@NumeroExpediente", "");
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
                listaPaciente = new List<Paciente>();

                while (dr.Read()) //Recorre cada registro
                {

                    Paciente pac = new Paciente();

                    pac.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    pac.NumeroExpediente = dr["NumeroExpediente"].ToString();
                    pac.CedulaPac = dr["CedulaPac"].ToString();
                    pac.NombrePac = dr["NombrePac"].ToString();
                    pac.ApellidosPac = dr["ApellidoPac"].ToString();
                    pac.FechaNacimiento = dr["FechaNacimiento"].ToString();
                    pac.LugarNacimiento = dr["LugarNacimiento"].ToString();
                    pac.EdadPac = Convert.ToInt32(dr["EdadPac"].ToString());
                    pac.GrupoEtnico = dr["GrupoEtnico"].ToString();
                    pac.DireccionHabitualPac = dr["DireccionHabitualPac"].ToString();
                    pac.NombrePadre = dr["NombrePadre"].ToString();
                    pac.NombreMadre = dr["NombreMadre"].ToString();
                    pac.ReligionPac = dr["ReligionPac"].ToString();
                    pac.ProcedenciaPac = dr["ProcedenciaPac"].ToString();
                    pac.TelefonoPac = dr["TelefonoPac"].ToString();
                    pac.EstadoCivilPac = dr["EstadoCivilPac"].ToString();
                    
                    listaPaciente.Add(pac); //agergar registros encontrados a la lista

                }


            }
            catch (Exception e)
            {

                e.Message.ToString();
                listaPaciente = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaPaciente;
        }

    }
}

