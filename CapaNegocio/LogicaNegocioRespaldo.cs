using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class LogicaNegocioRespaldo
    {
        AccesoDatosRespaldoBD rbd = new AccesoDatosRespaldoBD();
        public int respaldarBD()
        {
            return rbd.respaldarBD();
        }
    }
}
