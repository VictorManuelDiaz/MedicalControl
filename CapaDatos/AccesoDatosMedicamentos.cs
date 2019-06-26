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
    class AccesoDatosMedicamentos
    {

        SqlConnection cnx; //conexion
        Medicamento Med = new Medicamento(); // capa entidades
        Conexion cn = new Conexion(); // conexion
        SqlCommand cm = null; //Comandos sql
        int indicador = 0; // variable indicador para comprobar CRUD para cargar datos
        SqlDataReader dr = null;
        List<Medicamento> listaMedicamento = null;

        public int InsertarServicios(Medicamento M)
        {
            try
            {
                SqlConnection cnx = cn.Conectar(); // conectar
                cm = new SqlCommand("Medicamento_Proced", cnx); //nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 1); //valores que toman los parametros del procedimiento
                cm.Parameters.AddWithValue("@IdMedica", "");
                cm.Parameters.AddWithValue("@NombreMedica", M.NombreMedica);
                cm.Parameters.AddWithValue("@PresentacionMedica", M.PresentacionMedica);

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

        public List<Medicamento> ListarMedicamentos()
        {

            try
            {

                SqlConnection cnx = cn.Conectar();//conectar
                cm = new SqlCommand("Medicamento_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdMedica", "");
                cm.Parameters.AddWithValue("@NombreMedica", "");
                cm.Parameters.AddWithValue("@PresentacionMedica", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaMedicamento = new List<Medicamento>(); //lista de comentarios

                while (dr.Read()) //Recorre cada registro
                {

                    Medicamento Med = new Medicamento();

                    Med.IdMedica = Convert.ToInt32(dr["IdMedica"].ToString());
                    Med.NombreMedica = dr["NombreMedica"].ToString();
                    Med.PresentacionMedica = dr["PresentacionMedica"].ToString();

                    listaMedicamento.Add(Med); //agergar registros encontrados a la lista

                }

            }


            catch (Exception e)
            {
                e.Message.ToString();
                listaMedicamento = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaMedicamento ; //regresa lista de registros

        }

        public int EliminarMedicamentos(int IdMedica)
        {

            try
            {

                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Medicamento_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdMedica", IdMedica);
                cm.Parameters.AddWithValue("@NombreMedica", "");
                cm.Parameters.AddWithValue("@PresentacionMedica", "");


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

        public int EditarMedicamentos(Medicamento me)
        {
            try
            {
                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Medicamento_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdServicio", "");
                cm.Parameters.AddWithValue("@NombreServicio", me.NombreMedica);
                cm.Parameters.AddWithValue("@CostoServicio", me.PresentacionMedica);



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

        public List<Medicamento> BuscarMedicamentos(string dato)
        {
            try
            {

                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("Medicamento_Proced", cnx);
                cm.Parameters.AddWithValue("@IdMedica", "");
                cm.Parameters.AddWithValue("@NombreMedica", dato);
                cm.Parameters.AddWithValue("@PresentacionMedica", "");



                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaMedicamento = new List<Medicamento>();

                while (dr.Read()) //Recorre cada registro
                {

                    Medicamento Med = new Medicamento();

                    Med.IdMedica = Convert.ToInt32(dr["IdMedica"].ToString());
                    Med.NombreMedica = dr["NombreMedica"].ToString();
                    Med.PresentacionMedica = dr["PresentacionMedica"].ToString();

                    listaMedicamento.Add(Med); //agergar registros encontrados a la lista

                }


            }
            catch (Exception e)
            {

                e.Message.ToString();
                listaMedicamento = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaMedicamento;
        }

    }
}
