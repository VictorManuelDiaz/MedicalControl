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

        public int InsertarPaciente(Paciente pac)
        {
            return Pac.InsertarPaciente(pac);
        }

        public List<Paciente> ListarPaciente()
        {
            return Pac.ListarPaciente();
        }

        public int EliminarPaciente(int NumeroExpediente)
        {
            return Pac.EliminarPaciente(NumeroExpediente);
        }

        public int EditarPaciente(Paciente Pac)
        {
            return this.Pac.EditarPaciente(Pac);
        }

        public List<Paciente> BuscarPaciente(string dato)
        {
            return Pac.BuscarPaciente(dato);
        }

        public List<Paciente> PacienteMedico(int dato)
        {
            return Pac.ListarPacienteMedico(dato);
        }
        public List<Paciente> BuscarPacienteMedico(int dato,string dato2)
        {
            return Pac.BuscarPacienteMedico(dato,dato2);
        }

    }
}
