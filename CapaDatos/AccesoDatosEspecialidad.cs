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
    public class AccesoDatosEspecialidad
    {

        SqlConnection cnx; 
        Especialidad Esp = new Especialidad();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0; 
        SqlDataReader dr = null;
        List<Especialidad> listaEspecialidad = null;
        int IdEspecialidad;

        public int InsertarEspecialidad(Especialidad E)
        {
            try
            {
                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("Especialidad_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@NombreEs", E.NombreEs);


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

        public List<Especialidad> ListarEspecialidad()
        {

            try
            {

                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("Especialidad_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@NombreEs", 3);



                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaEspecialidad = new List<Especialidad>();

                while (dr.Read())
                {

                    Especialidad Esp = new Especialidad();

                    Esp.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    Esp.NombreEs = dr["NombreEs"].ToString();

                    listaEspecialidad.Add(Esp);

                }

            }


            catch (Exception e)
            {
                e.Message.ToString();
                listaEspecialidad = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaEspecialidad;

        }

        public int EliminarEspecialidad(int IdEspecialidad)
        {

            try
            {

                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Especialidad_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdEspecialidad", IdEspecialidad);
                cm.Parameters.AddWithValue("@NombreEs", "");


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

        public int EditarEspecialidad(Especialidad es)
        {
            try
            {
                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Especialidad_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@NombreEs", es.NombreEs);
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

        public List<Especialidad> BuscarEspecialidad(string dato)
        {
            try
            {

                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("Especialidad_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@NombreEs", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaEspecialidad = new List<Especialidad>();

                while (dr.Read())
                {

                    Especialidad Esp = new Especialidad();
                    Esp.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    Esp.NombreEs = dr["NombreEs"].ToString();
                    listaEspecialidad.Add(Esp);
                }

            }
            catch (Exception e)
            {

                e.Message.ToString();
                listaEspecialidad = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaEspecialidad;
        }

        public int BuscarIdEspecialidad(string dato)
        {
            try
            {

                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("Especialidad_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 6);
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@NombreEs", dato);




                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                }


            }
            catch (Exception e)
            {

                e.Message.ToString();
                IdEspecialidad = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return IdEspecialidad;
        }
    }
}
