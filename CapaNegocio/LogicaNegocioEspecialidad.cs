using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class LogicaNegocioEspecialidad
    {

        AccesoDatosEspecialidad ES = new AccesoDatosEspecialidad();

        public int InsertarEspecialidad(Especialidad es)
        {
            return ES.InsertarEspecialidad(es);
        }

        public List<Especialidad> ListarEspecialidad()
        {
            return ES.ListarEspecialidad();
        }

        public int EliminarEspecialidad(int IdEspecialidad)
        {
            return ES.EliminarEspecialidad(IdEspecialidad);
        }

        public int EditarCita(Especialidad Esp)
        {
            return ES.EditarEspecialidad(Esp);
        }

        public List<Especialidad> BuscarEspecialidad(string dato)
        {
            return ES.BuscarEspecialidad(dato);
        }

        public int BuscarIdEspecialidad(string dato)
        {
            return ES.BuscarIdEspecialidad(dato);
        }

    }
}
