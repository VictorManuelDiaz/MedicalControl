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
        SqlConnection cnx;
        Consulta Consul = new Consulta(); 
        Conexion cn = new Conexion();
        SqlCommand cm = null; 
        int indicador = 0;
        SqlDataReader dr = null;
        List<Consulta> listaConsulta = null;

        public int InsertarConsulta(Consulta ca)
        {
            try
            {
                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("Consulta_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdConsulta", "");
                cm.Parameters.AddWithValue("@Fecha", ca.Fecha);
                cm.Parameters.AddWithValue("@Hora", ca.Hora);
                cm.Parameters.AddWithValue("@Costo", ca.Costo);
                cm.Parameters.AddWithValue("@Sintomas", ca.Sintomas);
                cm.Parameters.AddWithValue("@Diagnostico", ca.Diagnostico);
                cm.Parameters.AddWithValue("@IdExpediente", ca.IdExpediente);
                cm.Parameters.AddWithValue("@IdMedico", ca.IdMedico);

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

        public List<Consulta> ListarConsulta()
        {

            try
            {

                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("Consulta_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdConsulta", "");
                cm.Parameters.AddWithValue("@Fecha", "");
                cm.Parameters.AddWithValue("@Hora", "");
                cm.Parameters.AddWithValue("@Costo", "");
                cm.Parameters.AddWithValue("@Sintomas", "");
                cm.Parameters.AddWithValue("@Diagnostico", "");
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@IdMedico", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaConsulta = new List<Consulta>();

                while (dr.Read())
                {

                    Consulta Consul = new Consulta();
                    Consul.IdConsulta = Convert.ToInt32(dr["IdConsulta"].ToString());
                    Consul.Fecha = Convert.ToDateTime(dr["Fecha"].ToString());
                    Consul.Hora = dr["Hora"].ToString();
                    Consul.Costo = dr["Costo"].ToString();
                    Consul.Sintomas = dr["Sintomas"].ToString();
                    Consul.Diagnostico = dr["Diagnostico"].ToString();
                    Consul.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    Consul.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    listaConsulta.Add(Consul);
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
                cm.Parameters.AddWithValue("@IdExpediente", "");
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
                cm.Parameters.AddWithValue("@IdExpediente", "");
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
                cm.Parameters.AddWithValue("@IdExpediente", dato);
                cm.Parameters.AddWithValue("@IdMedico", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaConsulta = new List<Consulta>();

                while (dr.Read())
                {

                    Consulta Consul = new Consulta();

                    Consul.IdConsulta = Convert.ToInt32(dr["IdConsulta"].ToString());
                    Consul.Fecha = Convert.ToDateTime(dr["Fecha"].ToString());
                    Consul.Hora = dr["Hora"].ToString();
                    Consul.Costo = dr["Costo"].ToString();
                    Consul.Sintomas = dr["Sintomas"].ToString();
                    Consul.Diagnostico = dr["Diagnostico"].ToString();
                    Consul.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    Consul.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    listaConsulta.Add(Consul);

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
