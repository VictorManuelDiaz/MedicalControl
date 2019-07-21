using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString ="Data Source=VICTORDS-PC;Initial Catalog=bd_proyecto;Integrated Security=True;";
            return cn;
        }
    }
}
