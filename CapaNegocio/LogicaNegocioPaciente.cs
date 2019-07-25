using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class LogicaNegocioPaciente
    {
        AccesoDatosPaciente Pac = new AccesoDatosPaciente();

        public int InsertarPaciente(Expediente ex)
        {
            return Pac.InsertarPaciente(ex);
        }

        public List<Paciente> ListarPaciente()
        {
            return Pac.ListarPaciente();
        }

        public int EliminarPaciente(int NumeroExpediente)
        {
            return Pac.EliminarPaciente(NumeroExpediente);
        }

        public int EditarExpediente(Paciente Pac)
        {
            return this.Pac.EditarPaciente(Pac);
        }

        public List<Paciente> BuscarPaciente(string dato)
        {
            return Pac.BuscarPaciente(dato);
        }

    }
}
