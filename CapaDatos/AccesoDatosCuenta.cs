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
    public class AccesoDatosCuenta
    {
        SqlConnection cnx; //conexion
        Cuenta Cu = new Cuenta(); // capa entidades
        Conexion cn = new Conexion(); // conexion
        SqlCommand cm = null; //Comandos sql
        int indicador = 0; // variable indicador para comprobar CRUD para cargar datos
        SqlDataReader dr = null;
        List<Cuenta> listaCuenta = null;

        public int InsertarCuenta(Cuenta cu)
        {
            try
            {
                SqlConnection cnx = cn.Conectar(); // conectar
                cm = new SqlCommand("Cuenta_Proced", cnx); //nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 1); //valores que toman los parametros del procedimiento
                cm.Parameters.AddWithValue("@IdCuenta", "");
                cm.Parameters.AddWithValue("@NombreCuenta", cu.NombreCuenta);
                cm.Parameters.AddWithValue("@Contrasena", cu.Contrasena);
                cm.Parameters.AddWithValue("@TipoCuenta", cu.TipoCuenta);

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

        public List<Cuenta> ListarCuenta()
        {

            try
            {

                SqlConnection cnx = cn.Conectar();//conectar
                cm = new SqlCommand("Cuenta_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdCuenta", "");
                cm.Parameters.AddWithValue("@NombreCuenta", "");
                cm.Parameters.AddWithValue("@Contrasena", "");
                cm.Parameters.AddWithValue("@TipoCuenta", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCuenta = new List<Cuenta>(); //lista de comentarios

                while (dr.Read()) //Recorre cada registro
                {

                    Cuenta Cu = new Cuenta();

                    Cu.IdCuenta = Convert.ToInt32(dr["IdCuenta"].ToString());
                    Cu.NombreCuenta = dr["NombreCuenta"].ToString();
                    Cu.Contrasena = dr["Contrasena"].ToString();
                    Cu.TipoCuenta = dr["TipoCuenta"].ToString();
                    listaCuenta.Add(Cu); //agergar registros encontrados a la lista

                }

            }


            catch (Exception e)
            {
                e.Message.ToString();
                listaCuenta = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaCuenta; //regresa lista de registros

        }

        public int EliminarCuenta(int IdCuenta)
        {

            try
            {

                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Cuenta_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdCuenta", IdCuenta);
                cm.Parameters.AddWithValue("@NombreCuenta", "");
                cm.Parameters.AddWithValue("@Contrasena","");
                cm.Parameters.AddWithValue("@TipoCuenta", "");

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

        public int EditarCuenta(Cuenta cu)
        {
            try
            {
                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Cuenta_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdCuenta", "");
                cm.Parameters.AddWithValue("@NombreCuenta", "");
                cm.Parameters.AddWithValue("@Contrasena", cu.Contrasena);
                cm.Parameters.AddWithValue("@TipoCuenta", "");

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

        public List<Cuenta> BuscarCuenta(string dato)
        {
            try
            {

                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("Cuenta_Proced", cnx);
                cm.Parameters.AddWithValue("@IdCuenta", "");
                cm.Parameters.AddWithValue("@NombreCuenta",dato);
                cm.Parameters.AddWithValue("@Contrasena", "");
                cm.Parameters.AddWithValue("@TipoCuenta", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCuenta = new List<Cuenta>();

                while (dr.Read()) //Recorre cada registro
                {

                    Cuenta Cu = new Cuenta();

                    Cu.IdCuenta = Convert.ToInt32(dr["IdCuenta"].ToString());
                    Cu.NombreCuenta = dr["NombreCuenta"].ToString();
                    Cu.Contrasena = dr["Contrasena"].ToString();
                    Cu.TipoCuenta = dr["TipoCuenta"].ToString();
                    listaCuenta.Add(Cu); //agergar registros encontrados a la lista

                }


            }
            catch (Exception e)
            {

                e.Message.ToString();
                listaCuenta = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaCuenta;
        }
    }
}
