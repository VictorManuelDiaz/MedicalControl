using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    class LogicaNegocioServicios
    {
        
        AccesoDatosServicios SER = new AccesoDatosServicios();

        public int InsertarServicio(Servicios se)
        {
            return SER.InsertarServicio(se);
        }

        public List<Servicios> ListarServicio()
        {
            return SER.ListarServicio();
        }

        public int EliminarMedico(int IdServicio)
        {
            return SER.EliminarServicio(IdServicio);
        }

        public int EditarMedico(Servicios ser)
        {
            return SER.EditarServicio(ser);
        }

        public List<Servicios> BuscarServicio(string dato)
        {
            return SER.BuscarServicio(dato);
        }

    }
}
