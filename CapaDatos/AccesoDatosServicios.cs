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
    public class AccesoDatosServicios
    {

        SqlConnection cnx; 
        Servicios Ser = new Servicios(); 
        Conexion cn = new Conexion();
        SqlCommand cm = null; 
        int indicador = 0; 
        SqlDataReader dr = null;
        List<Servicios> listaServicios = null;

        public int InsertarServicio(Servicios Se)
        {
            try
            {
                SqlConnection cnx = cn.Conectar(); // conectar
                cm = new SqlCommand("Servicios_Proced", cnx); //nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 1); //valores que toman los parametros del procedimiento
                cm.Parameters.AddWithValue("@IdServicios", "");
                cm.Parameters.AddWithValue("@NombreServicio", Se.NombreServicio);
                cm.Parameters.AddWithValue("@CostoServicio", Se.CostoServicio);

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

        public List<Servicios> ListarServicio()
        {

            try
            {

                SqlConnection cnx = cn.Conectar();//conectar
                cm = new SqlCommand("Servicios_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdServicios", "");
                cm.Parameters.AddWithValue("@NombreServicio", "");
                cm.Parameters.AddWithValue("@CostoServicio", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaServicios = new List<Servicios>(); //lista de comentarios

                while (dr.Read()) //Recorre cada registro
                {

                    Servicios Ser = new Servicios();

                    Ser.IdServicios = Convert.ToInt32(dr["IdServicios"].ToString());
                    Ser.NombreServicio = dr["NombreServicio"].ToString();
                    Ser.CostoServicio = dr["CostoServicio"].ToString();

                    listaServicios.Add(Ser); //agergar registros encontrados a la lista

                }

            }


            catch (Exception e)
            {
                e.Message.ToString();
                listaServicios = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaServicios; //regresa lista de registros

        }

        public int EliminarServicio(int IdServicio)
        {

            try
            {

                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Servicios_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdConsulta", IdServicio);
                cm.Parameters.AddWithValue("@NombreServicio", "");
                cm.Parameters.AddWithValue("@CostoServicio", "");


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

        public int EditarServicio(Servicios se)
        {
            try
            {
                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Servicios_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdServicio", "");
                cm.Parameters.AddWithValue("@NombreServicio", se.NombreServicio);
                cm.Parameters.AddWithValue("@CostoServicio", se.CostoServicio);



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

        public List<Servicios> BuscarServicio(string dato)
        {
            try
            {

                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("Servicios_Proced", cnx);
                cm.Parameters.AddWithValue("@IdServicio", "");
                cm.Parameters.AddWithValue("@NombreServicio", dato);
                cm.Parameters.AddWithValue("@CostoServicio", "");



                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaServicios = new List<Servicios>();

                while (dr.Read()) //Recorre cada registro
                {

                    Servicios Se = new Servicios();

                    Se.IdServicios = Convert.ToInt32(dr["IdServicio"].ToString());
                    Se.NombreServicio = dr["NombreServicio"].ToString();
                    Se.CostoServicio = dr["CostoServicio"].ToString();

                    listaServicios.Add(Se); //agergar registros encontrados a la lista

                }


            }
            catch (Exception e)
            {

                e.Message.ToString();
                listaServicios = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaServicios;
        }

    }
}
