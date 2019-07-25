using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class LogicaNegocioCita
    {
        AccesoDatosCita CI = new AccesoDatosCita();

        public int InsertarCita(Cita ci)
        {
            return CI.InsertarCita(ci);
        }

        public List<Cita> ListarCita()
        {
            return CI.ListarCita();
        }

        public int EliminarCita(int IdCita)
        {
            return CI.EliminarCita(IdCita);
        }

        public int EditarCita(Cita Cit)
        {
            return CI.EditarCita(Cit);
        }

        public List<Cita> BuscarCita(string dato)
        {
            return CI.BuscarCita(dato);
        } 
    }
}
