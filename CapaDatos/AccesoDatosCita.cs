using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class AccesoDatosCita
    {

        SqlConnection cnx; //conexion
        Cita Cit = new Cita(); // capa entidades
        Conexion cn = new Conexion(); // conexion
        SqlCommand cm = null; //Comandos sql
        int indicador = 0; // variable indicador para comprobar CRUD para cargar datos
        SqlDataReader dr = null;
        List<Cita> listaCita = null;

        public int InsertarCita(Cita ci)
        {
            try
            {
                SqlConnection cnx = cn.Conectar(); // conectar
                cm = new SqlCommand("Cita_Proced", cnx); //nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 1); //valores que toman los parametros del procedimiento
                cm.Parameters.AddWithValue("@IdCita", "");
                cm.Parameters.AddWithValue("@FechaConsul", ci.FechaConsul);
                cm.Parameters.AddWithValue("@FechaRealCita", ci.FechaRealCita);
                cm.Parameters.AddWithValue("@HoraC", ci.HoraC);
                cm.Parameters.AddWithValue("@NumeroExpediente", ci.NumeroExpediente);
                cm.Parameters.AddWithValue("@IdMedico", ci.IdMedico);

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

        public List<Cita> ListarCita()
        {

            try
            {

                SqlConnection cnx = cn.Conectar();//conectar
                cm = new SqlCommand("Cita_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdCita", "");
                cm.Parameters.AddWithValue("@FechaConsul", "");
                cm.Parameters.AddWithValue("@FechaRealCita", "");
                cm.Parameters.AddWithValue("@HoraC", "");
                cm.Parameters.AddWithValue("@NumeroExpediente", "");
                cm.Parameters.AddWithValue("@IdMedico", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCita = new List<Cita>(); //lista de comentarios

                while (dr.Read()) //Recorre cada registro
                {

                    Cita Cit = new Cita();

                    Cit.IdCita = Convert.ToInt32(dr["IdCita"].ToString());
                    Cit.FechaConsul = dr["FechaConsult"].ToString();
                    Cit.FechaRealCita = dr["FechaRealCita"].ToString();
                    Cit.HoraC = dr["HoraC"].ToString();
                    Cit.NumeroExpediente = Convert.ToInt32(dr["NuemroExpediente"].ToString());
                    Cit.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    listaCita.Add(Cit); //agergar registros encontrados a la lista

                }

            }


            catch (Exception e)
            {
                e.Message.ToString();
                listaCita = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaCita; //regresa lista de registros

        }

        public int EliminarCita(int IdCita)
        {

            try
            {

                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Cita_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdCita", IdCita);
                cm.Parameters.AddWithValue("@FechaConsul", "");
                cm.Parameters.AddWithValue("@FechaRealCita", "");
                cm.Parameters.AddWithValue("@HoraC", "");
                cm.Parameters.AddWithValue("@NumeroExpediente", "");
                cm.Parameters.AddWithValue("@IdMedico", "");

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

        //editar cita

        public int EditarCita(Cita ci)
        {
            try
            {
                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Cita_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdCita", ci.IdCita);
                cm.Parameters.AddWithValue("@FechaConsul", "");
                cm.Parameters.AddWithValue("@FechaRealCita", ci.FechaRealCita);
                cm.Parameters.AddWithValue("@HoraC", "");
                cm.Parameters.AddWithValue("@NumeroExpediente", ci.NumeroExpediente);
                cm.Parameters.AddWithValue("@IdMedico", "");

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
        //buscar cita

        public List<Cita> BuscarCita(string dato)
        {
            try
            {

                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("Cita_Proced", cnx);
                cm.Parameters.AddWithValue("@IdCita", "");
                cm.Parameters.AddWithValue("@FechaConsul", "");
                cm.Parameters.AddWithValue("@FechaRealCita", dato);
                cm.Parameters.AddWithValue("@HoraC", "");
                cm.Parameters.AddWithValue("@NumeroExpediente", dato);
                cm.Parameters.AddWithValue("@IdMedico", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCita = new List<Cita>();

                while (dr.Read()) //Recorre cada registro
                {

                    Cita Cit = new Cita();

                    Cit.IdCita = Convert.ToInt32(dr["IdCita"].ToString());
                    Cit.FechaConsul = dr["FechaConsult"].ToString();
                    Cit.FechaRealCita = dr["FechaRealCita"].ToString();
                    Cit.HoraC = dr["HoraC"].ToString();
                    Cit.NumeroExpediente = Convert.ToInt32(dr["NuemroExpediente"].ToString());
                    Cit.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    listaCita.Add(Cit); //agergar registros encontrados a la lista

                }


            }
            catch (Exception e)
            {

                e.Message.ToString();
                listaCita = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaCita;
        }

    }
}
