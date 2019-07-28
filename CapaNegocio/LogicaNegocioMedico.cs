using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class LogicaNegocioMedico
    {

        AccesoDatosMedico MED = new AccesoDatosMedico();

        public int insertarMedico(Medico Me)
        {
            return MED.InsertarMedico(Me);
        }

        public List<Medico> listarMedico()
        {
            return MED.ListarMedico();
        }

        public int eliminarMedico(int IdMedico)
        {
            return MED.EliminarMedico(IdMedico);
        }

        public int editarMedico(Medico Me)
        {
            return MED.EditarMedico(Me);
        }

        public List<Medico> buscarMedico(string dato)
        {
            return MED.BuscarMedico(dato);
        }
        
    }
}
