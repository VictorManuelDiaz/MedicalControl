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
    public class AccesoDatosMedico
    {

        SqlConnection cnx; //conexion
        Medico Medic = new Medico(); // capa entidades
        Conexion cn = new Conexion(); // conexion
        SqlCommand cm = null; //Comandos sql
        int indicador = 0; 
        SqlDataReader dr = null;
        List<Medico> listaMedico = null;
        int IdMedico;
        string NombreMed;
        public int InsertarMedico(Medico Med)
        {
            try
            {
                SqlConnection cnx = cn.Conectar(); 
                cm = new SqlCommand("Medico_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdMedico", "");
                cm.Parameters.AddWithValue("@NombreM", Med.NombreM);
                cm.Parameters.AddWithValue("@ApellidoM", Med.ApellidoM);
                cm.Parameters.AddWithValue("@IdEspecialidad", Med.IdEspecialidad);
                cm.Parameters.AddWithValue("@EmailM", Med.EmailM);
                cm.Parameters.AddWithValue("@TelefonoM", Med.TelefonoM);
                cm.Parameters.AddWithValue("@CedulaM", Med.CedulaM);
                cm.Parameters.AddWithValue("@SexoM", Med.SexoM);
                cm.Parameters.AddWithValue("@DireccionM", Med.DireccionM);


                cm.CommandType = CommandType.StoredProcedure;// tipo de comando ejecutado
                cnx.Open();
                cm.ExecuteNonQuery();
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

        public List<Medico> ListarMedico()
        {

            try
            {

                SqlConnection cnx = cn.Conectar();//conectar

                cm = new SqlCommand("Medico_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdMedico", "");
                cm.Parameters.AddWithValue("@NombreM", "");
                cm.Parameters.AddWithValue("@ApellidoM", "");
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@EmailM", "");
                cm.Parameters.AddWithValue("@TelefonoM", "");
                cm.Parameters.AddWithValue("@CedulaM", "");
                cm.Parameters.AddWithValue("@SexoM", "");
                cm.Parameters.AddWithValue("@DireccionM", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaMedico = new List<Medico>(); //lista de comentarios

                while (dr.Read()) //Recorre cada registro
                {

                    Medico me = new Medico();

                    me.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    me.NombreM = dr["NombreM"].ToString();
                    me.ApellidoM = dr["ApellidoM"].ToString();
                    me.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    me.EmailM = dr["EmailM"].ToString();
                    me.TelefonoM = dr["TelefonoM"].ToString();
                    me.CedulaM = dr["CedulaM"].ToString();
                    me.SexoM = dr["SexoM"].ToString();
                    me.DireccionM = dr["DireccionM"].ToString();

                    listaMedico.Add(me); //agergar registros encontrados a la lista

                }

            }


            catch (Exception e)
            {
                e.Message.ToString();
                listaMedico = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaMedico;

        }

        public int EliminarMedico(int IdMedico)
        {

            try
            {

                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Medico_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdMedico", IdMedico);
                cm.Parameters.AddWithValue("@NombreM", "");
                cm.Parameters.AddWithValue("@ApellidoM", "");
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@EmailM", "");
                cm.Parameters.AddWithValue("@TelefonoM", "");
                cm.Parameters.AddWithValue("@CedulaM", "");
                cm.Parameters.AddWithValue("@SexoM", "");
                cm.Parameters.AddWithValue("@DireccionM", "");


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

        //editar comentarios
        public int EditarMedico(Medico Med)
        {
            try
            {
                SqlConnection cnx = cn.Conectar();

                cm = new SqlCommand("Medico_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdMedico", "");
                cm.Parameters.AddWithValue("@NombreM", Med.NombreM);
                cm.Parameters.AddWithValue("@ApellidoM", Med.ApellidoM);
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@EmailM", Med.EmailM);
                cm.Parameters.AddWithValue("@TelefonoM", Med.TelefonoM);
                cm.Parameters.AddWithValue("@CedulaM", Med.CedulaM);
                cm.Parameters.AddWithValue("@SexoM", "");
                cm.Parameters.AddWithValue("@DireccionM", Med.DireccionM);


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

        public List<Medico> BuscarMedico(string dato)
        {
            try
            {

                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("Medico_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@IdMedico", "");
                cm.Parameters.AddWithValue("@NombreM", dato);
                cm.Parameters.AddWithValue("@ApellidoM", dato);
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@EmailM", "");
                cm.Parameters.AddWithValue("@TelefonoM", "");
                cm.Parameters.AddWithValue("@CedulaM", dato);
                cm.Parameters.AddWithValue("@SexoM", "");
                cm.Parameters.AddWithValue("@DireccionM", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaMedico = new List<Medico>();

                while (dr.Read()) //Recorre cada registro
                {

                    Medico me = new Medico();

                    me.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    me.NombreM = dr["NombreM"].ToString();
                    me.ApellidoM = dr["ApellidoM"].ToString();
                    me.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    me.EmailM = dr["EmailM"].ToString();
                    me.TelefonoM = dr["TelefonoM"].ToString();
                    me.CedulaM = dr["CedulaM"].ToString();
                    me.SexoM = dr["SexoM"].ToString();
                    me.DireccionM = dr["DireccionM"].ToString();

                    listaMedico.Add(me);

                }


            }
            catch (Exception e)
            {

                e.Message.ToString();
                listaMedico = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaMedico;
        }

        public int BuscarIdPorMedico(string dato)
        {
            try
            {

                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("IdMedico_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@NombreCom", dato);

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

        public string BuscarMedicoPorId(int dato)
        {
            try
            {
                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("NombreMedico_Proced", cnx);
                cm.Parameters.AddWithValue("@IdMedico", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();

                while (dr.Read()) //Recorre cada registro
                {

                    NombreMed =dr["NombreM"].ToString() +" "+ dr["ApellidoM"].ToString();
                }

            }
            catch (Exception e)
            {

                e.Message.ToString();
                NombreMed = "";
            }
            finally
            {
                cm.Connection.Close();
            }
            return NombreMed;
        }

        public List<Medico> BuscarMedicoCuenta()
        {
            
            try
            {

                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("Medico_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 6);
                cm.Parameters.AddWithValue("@IdMedico", "");
                cm.Parameters.AddWithValue("@NombreM", "");
                cm.Parameters.AddWithValue("@ApellidoM", "");
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@EmailM", "");
                cm.Parameters.AddWithValue("@TelefonoM", "");
                cm.Parameters.AddWithValue("@CedulaM", "");
                cm.Parameters.AddWithValue("@SexoM", "");
                cm.Parameters.AddWithValue("@DireccionM", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaMedico = new List<Medico>();

                while (dr.Read()) //Recorre cada registro
                {

                    Medico me = new Medico();

                    me.IdMedico = Convert.ToInt32(dr["IdMedico"].ToString());
                    me.NombreM = dr["NombreM"].ToString();
                    me.ApellidoM = dr["ApellidoM"].ToString();
                    me.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    me.EmailM = dr["EmailM"].ToString();
                    me.TelefonoM = dr["TelefonoM"].ToString();
                    me.CedulaM = dr["CedulaM"].ToString();
                    me.SexoM = dr["SexoM"].ToString();
                    me.DireccionM = dr["DireccionM"].ToString();

                    listaMedico.Add(me);

                }


            }
            catch (Exception e)
            {

                e.Message.ToString();
                listaMedico = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaMedico;
        }

    }
}

