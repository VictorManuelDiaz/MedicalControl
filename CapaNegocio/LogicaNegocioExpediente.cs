using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class LogicaNegocioExpediente
    {

        AccesoDatosExpediente EXP = new AccesoDatosExpediente();

        public int InsertarExpediente(Expediente ex)
        {
            return EXP.InsertarExpediente(ex);
        }

        public List<Expediente> ListarExpediente()
        {
            return EXP.ListarExpediente();
        }

      public int EliminarExpediente(int NumeroExpediente)
        {
            return EXP.EliminarExpediente(NumeroExpediente);
        }

        public int EditarExpediente(Expediente exp)
        {
            return EXP.EditarExpediente(exp);
        }

        public List<Expediente> BuscarExpediente(string dato)
        {
            return EXP.BuscarExpediente(dato);
        }

        public List<Expediente> ListarExpedienteId(int dato)
        {
            return EXP.ListarExpedienteId(dato);
        }
        public List<Expediente> ListarExpedienteMed(int dato)
        {
            return EXP.ListarExpedienteMed(dato);
        }

    }
}
