using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class LogicaNegocioConsulta
    {

        AccesoDatosConsulta CON = new AccesoDatosConsulta();

        public int InsertarConsulta(Consulta co)
        {
            return CON.InsertarConsulta(co);
        }

        public List<Consulta> ListarConsulta()
        {
            return CON.ListarConsulta();
        }

        public int EliminarConsulta(int IdConsulta)
        {
            return CON.EliminarConsulta(IdConsulta);
        }

        public int EditarConsulta(Consulta Con)
        {
            return CON.EditarConsulta(Con);
        }

        public List<Consulta> BuscarConsulta(string dato)
        {
            return CON.BuscarConsulta(dato);
        }

        public List<Consulta> ListarConsultaMedico(int Medico)
        {
            return CON.ListarConsultaMedico(Medico);
        }

    }
}
