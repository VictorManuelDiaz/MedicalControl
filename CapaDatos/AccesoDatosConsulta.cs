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
    public class AccesoDatosConsulta
    {
        SqlConnection cnx; //conexion
        Consulta Consul = new Consulta(); // capa entidades
        Conexion cn = new Conexion(); // conexion
        SqlCommand cm = null; //Comandos sql
        int indicador = 0; // variable indicador para comprobar CRUD para cargar datos
        SqlDataReader dr = null;
        List<Consulta> listaConsulta = null;

        public int InsertarConsulta(Consulta ca)
        {
            try
            {
                SqlConnection cnx = cn.Conectar(); // conectar
                cm = new SqlCommand("Consulta_Proced", cnx); //nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 1); //valores que toman los parametros del procedimiento
                cm.Parameters.AddWithValue("@IdConsulta", "");
                cm.Parameters.AddWithValue("@Fecha", ca.Fecha);
                cm.Parameters.AddWithValue("@Hora", ca.Hora);
                cm.Parameters.AddWithValue("@Costo", ca.Costo);
                cm.Parameters.AddWithValue("@Sintomas", ca.Sintomas);
                cm.Parameters.AddWithValue("@Diagnostico", ca.Diagnostico);
                cm.Parameters.AddWithValue("@NumeroExpediente", ca.NumeroExpediente);
                cm.Parameters.AddWithValue("@IdMedico", ca.IdMedico);

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

        public List<Consulta> ListarConsulta()
        {

            try
            {

                SqlConnection cnx = cn.Conectar();//conectar
                cm = new SqlCommand("Consulta_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdConsulta", "");
                cm.Parameters.AddWithValue("@Fecha", "");
                cm.Parameters.AddWithValue("@Hora", "");
                cm.Parameters.AddWithValue("@Costo", "");
                cm.Parameters.AddWithValue("@Sintomas", "");
                cm.Parameters.AddWithValue("@Diagnostico", "");
                cm.Parameters.AddWithValue("@NumeroExpediente", "");
                cm.Parameters.AddWithValue("@IdMedico", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaConsulta = new List<Consulta>(); //lista de comentarios

                while (dr.Read()) //Recorre cada registro
                {

                    Consulta Consul = new Consulta();

                    Consul.IdConsulta = Convert.ToInt32(dr["IdConsulta"].ToString());
                    Consul.Fecha = dr["Fecha"].ToString();
                    Consul.Hora = dr["Hora"].ToString();
                    Consul.Costo = dr["Costo"].ToString();
                    Consul.Sintomas = dr["Sintomas"].ToString();
                    Consul.Diagnostico = dr["Diagnostico"].ToString();
                    Consul.NumeroExpediente = Convert.ToInt32(dr["NumeroExpediente"].ToString());
                    Consul.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    listaConsulta.Add(Consul); //agergar registros encontrados a la lista

                }

            }


            catch (Exception e)
            {
                e.Message.ToString();
                listaConsulta = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaConsulta; //regresa lista de registros

        }

        public int EliminarConsulta(int IdConsulta)
        {

            try
            {

                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Consulta_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdConsulta", IdConsulta);
                cm.Parameters.AddWithValue("@Fecha", "");
                cm.Parameters.AddWithValue("@Hora", "");
                cm.Parameters.AddWithValue("@Costo", "");
                cm.Parameters.AddWithValue("@Sintomas", "");
                cm.Parameters.AddWithValue("@Diagnostico", "");
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

        //editar comentarios

        public int EditarConsulta(Consulta ca)
        {
            try
            {
                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Consulta_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdConsulta", "");
                cm.Parameters.AddWithValue("@Fecha", "");
                cm.Parameters.AddWithValue("@Hora", "");
                cm.Parameters.AddWithValue("@Costo", ca.Costo);
                cm.Parameters.AddWithValue("@Sintomas", ca.Sintomas);
                cm.Parameters.AddWithValue("@Diagnostico", ca.Diagnostico);
                cm.Parameters.AddWithValue("@NumeroExpediente", "");
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
        //buscar comentarios

        public List<Consulta> BuscarConsulta(string dato)
        {
            try
            {

                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("Consulta_Proced", cnx);
                cm.Parameters.AddWithValue("@IdConsulta", "");
                cm.Parameters.AddWithValue("@Fecha", dato);
                cm.Parameters.AddWithValue("@Hora", "");
                cm.Parameters.AddWithValue("@Costo", "");
                cm.Parameters.AddWithValue("@Sintomas", "");
                cm.Parameters.AddWithValue("@Diagnostico", "");
                cm.Parameters.AddWithValue("@NumeroExpediente", dato);
                cm.Parameters.AddWithValue("@IdMedico", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaConsulta = new List<Consulta>();

                while (dr.Read()) //Recorre cada registro
                {

                    Consulta Consul = new Consulta();

                    Consul.IdConsulta = Convert.ToInt32(dr["IdConsulta"].ToString());
                    Consul.Fecha = dr["Fecha"].ToString();
                    Consul.Hora = dr["Hora"].ToString();
                    Consul.Costo = dr["Costo"].ToString();
                    Consul.Sintomas = dr["Sintomas"].ToString();
                    Consul.Diagnostico = dr["Diagnostico"].ToString();
                    Consul.NumeroExpediente = Convert.ToInt32(dr["NuemroExpediente"].ToString());
                    Consul.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    listaConsulta.Add(Consul); //agergar registros encontrados a la lista

                }


            }
            catch (Exception e)
            {

                e.Message.ToString();
                listaConsulta = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaConsulta;
        }
    }
}
