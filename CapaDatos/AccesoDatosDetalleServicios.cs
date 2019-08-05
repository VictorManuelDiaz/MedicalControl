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
    public class AccesoDatosDetalleServicios
    {
        SqlConnection cnx; //conexion
        DetalleServicios DetSer = new DetalleServicios(); // capa entidades
        Conexion cn = new Conexion(); // conexion
        SqlCommand cm = null; //Comandos sql
        int indicador = 0; // variable indicador para comprobar CRUD para cargar datos
        SqlDataReader dr = null;
        List<DetalleServicios> listaDetServicios = null;

        public int InsertarDetServicios(DetalleServicios DetSe)
        {
            try
            {
                SqlConnection cnx = cn.Conectar(); // conectar
                cm = new SqlCommand("DetalleServicios_Proced", cnx); //nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 1); //valores que toman los parametros del procedimiento
                cm.Parameters.AddWithValue("@IdDetServic", "");
                cm.Parameters.AddWithValue("@Precio", DetSe.Precio);
                cm.Parameters.AddWithValue("@IdExpediente", DetSe.IdExpediente);
                cm.Parameters.AddWithValue("@IdServicios", DetSe.IdServicios);

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

        public List<DetalleServicios> ListarDetServicios()
        {

            try
            {

                SqlConnection cnx = cn.Conectar();//conectar
                cm = new SqlCommand("DetalleServicios_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdDetServic", "");
                cm.Parameters.AddWithValue("@Precio", "");
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@IdServicios", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaDetServicios = new List<DetalleServicios>(); //lista de comentarios

                while (dr.Read()) //Recorre cada registro
                {

                    DetalleServicios DetSer = new DetalleServicios();

                    DetSer.IdDetServic = Convert.ToInt32(dr["IdDetServic"].ToString());
                    DetSer.Precio = Convert.ToDouble(dr["Precio"].ToString());
                    DetSer.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    DetSer.IdServicios = Convert.ToInt32(dr["IdServicios"].ToString());

                    listaDetServicios.Add(DetSer); //agergar registros encontrados a la lista

                }

            }


            catch (Exception e)
            {
                e.Message.ToString();
                listaDetServicios = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaDetServicios; //regresa lista de registros

        }

        public int EliminarDetServicios(int IdDetServicio)
        {

            try
            {

                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("DetalleServicios_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdDetServic", "");
                cm.Parameters.AddWithValue("@Precio", "");
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@IdServicios", "");

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

        public int EditarDetServicios(DetalleServicios DetSe)
        {
            try
            {
                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("DetalleServicios_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdDetServic", "");
                cm.Parameters.AddWithValue("@Precio", DetSe.Precio);
                cm.Parameters.AddWithValue("@IdExpediente", DetSe.IdExpediente);
                cm.Parameters.AddWithValue("@IdServicios", DetSe.IdServicios);



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

        public List<DetalleServicios> BuscarDetServicios(string dato)
        {
            try
            {

                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("DetalleServicios_Proced", cnx);
                cm.Parameters.AddWithValue("@IdDetServic", "");
                cm.Parameters.AddWithValue("@Precio", "");
                cm.Parameters.AddWithValue("@IdExpediente", "");
                cm.Parameters.AddWithValue("@IdServicios", "");



                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaDetServicios = new List<DetalleServicios>();

                while (dr.Read()) //Recorre cada registro
                {

                    DetalleServicios DetSer = new DetalleServicios();

                    DetSer.IdDetServic = Convert.ToInt32(dr["IdDetServic"].ToString());
                    DetSer.Precio = Convert.ToDouble(dr["Precio"].ToString());
                    DetSer.IdExpediente = Convert.ToInt32(dr["IdExpediente"].ToString());
                    DetSer.IdServicios = Convert.ToInt32(dr["IdServicios"].ToString());

                    listaDetServicios.Add(DetSer); //agergar registros encontrados a la lista

                }


            }
            catch (Exception e)
            {

                e.Message.ToString();
                listaDetServicios = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaDetServicios;
        }
    }
}
