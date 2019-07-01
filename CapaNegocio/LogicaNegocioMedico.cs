using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    class LogicaNegocioMedico
    {

        AccesoDatosMedico MED = new AccesoDatosMedico();

        public int InsertarMedico(Medico ME)
        {
            return MED.InsertarMedico(ME);
        }

        public List<Medico> ListarMedico()
        {
            return MED.ListarMedico();
        }

        public int EliminarMedico(int IdMedico)
        {
            return MED.EliminarMedico(IdMedico);
        }

        public int EditarMedico(Medico Me)
        {
            return MED.EditarMedico(Me);
        }

        public List<Medico> BuscarMedico(string dato)
        {
            return MED.BuscarMedico(dato);
        }

    }
}
