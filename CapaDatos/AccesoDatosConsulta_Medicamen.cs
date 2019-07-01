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
    public class AccesoDatosConsulta_Medicamen
    {
        SqlConnection cnx; //conexion
        ConsultaMedicamento Med = new ConsultaMedicamento(); // capa entidades
        Conexion cn = new Conexion(); // conexion
        SqlCommand cm = null; //Comandos sql
        int indicador = 0; // variable indicador para comprobar CRUD para cargar datos
        SqlDataReader dr = null;
        List<ConsultaMedicamento> listaConMedicamento = null;

        public int InsertarConsultMedicamen(ConsultaMedicamento CM)
        {
            try
            {
                SqlConnection cnx = cn.Conectar(); // conectar
                cm = new SqlCommand("Consulta_Medicamen_Proced", cnx); //nombre del procedimiento SQL
                cm.Parameters.AddWithValue("@b", 1); //valores que toman los parametros del procedimiento
                cm.Parameters.AddWithValue("@IdConMedica", CM.IdMedica);
                cm.Parameters.AddWithValue("@IdConsulta", CM.IdConsulta);

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

        public List<ConsultaMedicamento> ListarConsultMedicamen()
        {

            try
            {

                SqlConnection cnx = cn.Conectar();//conectar
                cm = new SqlCommand("Consulta_Medicamen_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdConMedica","");
                cm.Parameters.AddWithValue("@IdConsulta","");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaConMedicamento = new List<ConsultaMedicamento>(); //lista de comentarios

                while (dr.Read()) //Recorre cada registro
                {

                    ConsultaMedicamento ConMed = new ConsultaMedicamento();

                    ConMed.IdMedica = Convert.ToInt32(dr["IdConMedica"].ToString());
                    ConMed.IdConsulta = Convert.ToInt32(dr["IdConsulta"].ToString());

                    listaConMedicamento.Add(ConMed); //agergar registros encontrados a la lista

                }

            }


            catch (Exception e)
            {
                e.Message.ToString();
                listaConMedicamento = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaConMedicamento; //regresa lista de registros

        }

        public int EliminarConsultMedicamen(int IdConMedica)
        {

            try
            {

                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Consulta_Medicamen_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdConMedica", IdConMedica);
                cm.Parameters.AddWithValue("@IdConsulta", "");


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

        public int EditarConsultMedicamen(ConsultaMedicamento CM)
        {
            try
            {
                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Consulta_Medicamen_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdConMedica", CM.IdMedica);
                cm.Parameters.AddWithValue("@IdConsulta", CM.IdConsulta);



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
        
    }
}
