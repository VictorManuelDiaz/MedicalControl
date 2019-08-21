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
    public class AccesoDatosUsuario
    {
        SqlConnection cnx; //conexion
        Usuario Med = new Usuario(); // capa entidades
        Conexion cn = new Conexion(); // conexion
        SqlCommand cm = null; //Comandos sql
        int indicador = 0; // variable indicador para comprobar CRUD para cargar datos
        SqlDataReader dr = null;
        List<Usuario> listaUsuario = null;
        int IdMedico = 0;
        public int InsertarUsuario(Usuario USU)
        {
            try
            {
                SqlConnection cnx = cn.Conectar(); // conectar
                cm = new SqlCommand("Usuario_Proced", cnx); //nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 1); //valores que toman los parametros del procedimiento
                cm.Parameters.AddWithValue("@IdCuenta", USU.IdCuenta);
                cm.Parameters.AddWithValue("@IdMedico", USU.IdMedico);

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

        public List<Usuario> ListarUsuario()
        {

            try
            {

                SqlConnection cnx = cn.Conectar();//conectar
                cm = new SqlCommand("Usuario_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdCuenta", "");
                cm.Parameters.AddWithValue("@IdMedico", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaUsuario = new List<Usuario>(); //lista de comentarios

                while (dr.Read()) //Recorre cada registro
                {

                    Usuario Usu = new Usuario();

                    Usu.IdCuenta = Convert.ToInt32(dr["IdCuenta"].ToString());
                    Usu.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());

                    listaUsuario.Add(Usu); //agergar registros encontrados a la lista

                }

            }


            catch (Exception e)
            {
                e.Message.ToString();
                listaUsuario = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaUsuario; //regresa lista de registros

        }

        public int EliminarUsuario(int IdMed)
        {

            try
            {

                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Usuario_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdCuenta", "");
                cm.Parameters.AddWithValue("@IdMedico", IdMed);


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

        public int EditarUsuario(Usuario USU)
        {
            try
            {
                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Usuario_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdCuenta", USU.IdCuenta);
                cm.Parameters.AddWithValue("@IdMedico", USU.IdMedico);



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

        public int ListarIdMedico(int IdCuent)
        {

            try
            {

                SqlConnection cnx = cn.Conectar();//conectar
                cm = new SqlCommand("Usuario_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@IdCuenta", IdCuent);
                cm.Parameters.AddWithValue("@IdMedico", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();

                while (dr.Read()) //Recorre cada registro
                {
                    IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                }

            }


            catch (Exception e)
            {
                e.Message.ToString();
                IdMedico = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return IdMedico;

        }
    }
}


