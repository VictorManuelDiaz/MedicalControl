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
    public class AccesoDatosComplete
    {
        SqlConnection cnx;
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        SqlDataReader dr = null;
        int IdMedico;
        public int BuscarMedicoPorId(string dato)
        {
            try
            {

                SqlConnection cnx = cn.Conectar();
                cm = new SqlCommand("CompleteNom_Proced", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@NombreCom", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();

                while (dr.Read()) //Recorre cada registro
                {

                    IdMedico=Convert.ToInt32(dr["IdMedico"].ToString());
                }

            }
            catch (Exception e)
            {

                e.Message.ToString();
                IdMedico= 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return IdMedico;
        }
    }
}
