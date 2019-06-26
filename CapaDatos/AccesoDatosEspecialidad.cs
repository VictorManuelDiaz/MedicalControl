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
    class AccesoDatosEspecialidad
    {

        SqlConnection cnx; //conexion
        Especialidad Esp = new Especialidad(); // capa entidades
        Conexion cn = new Conexion(); // conexion
        SqlCommand cm = null; //Comandos sql
        int indicador = 0; // variable indicador para comprobar CRUD para cargar datos
        SqlDataReader dr = null;
        List<Especialidad> listaEspecialidad = null;

        public int InsertarServicios(Especialidad E)
        {
            try
            {
                SqlConnection cnx = cn.Conectar(); // conectar
                cm = new SqlCommand("Especialidad_Proced", cnx); //nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 1); //valores que toman los parametros del procedimiento
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@NombreES", E.NombreEs);


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

        public List<Especialidad> ListarEspecialidad()
        {

            try
            {

                SqlConnection cnx = cn.Conectar();//conectar
                cm = new SqlCommand("Especialidad_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@NombreEs", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaEspecialidad = new List<Especialidad>(); //lista de comentarios

                while (dr.Read()) //Recorre cada registro
                {

                    Especialidad Esp = new Especialidad();

                    Esp.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    Esp.NombreEs = dr["NombreEs"].ToString();

                    listaEspecialidad.Add(Esp); //agergar registros encontrados a la lista

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
            return listaEspecialidad; //regresa lista de registros

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

        //editar comentarios

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
        //buscar comentarios

        public List<Especialidad> BuscarEspecialidad(string dato)
        {
            try
            {

                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("Especialidad_Proced", cnx);
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@NombreEspecialidad", dato);




                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaEspecialidad = new List<Especialidad>();

                while (dr.Read()) //Recorre cada registro
                {

                    Especialidad Esp = new Especialidad();

                    Esp.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    Esp.NombreEs = dr["NombreEs"].ToString();

                    listaEspecialidad.Add(Esp); //agergar registros encontrados a la lista

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

    }
}
