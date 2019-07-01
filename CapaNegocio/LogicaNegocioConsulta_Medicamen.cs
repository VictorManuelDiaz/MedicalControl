using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    class LogicaNegocioConsulta_Medicamen
    {

        AccesoDatosConsulta_Medicamen CONMED = new AccesoDatosConsulta_Medicamen();

        public int InsertarConsulta_Medicamen(ConsultaMedicamento come)
        {
            return CONMED.InsertarConsultMedicamen(come);
        }

        public List<ConsultaMedicamento> ListarConsultaMedicamen()
        {
            return CONMED.ListarConsultMedicamen();
        }

        public int EliminarConsultaMedicamen(int IdConsultaMedicamen)
        {
            return CONMED.EliminarConsultMedicamen(IdConsultaMedicamen);
        }

        public int EditarConsultaMedicamen(ConsultaMedicamento CM)
        {
            return CONMED.EditarConsultMedicamen(CM);
        }


        // este no poseemos un metodo en la capa de datos del metodo buscar
        public List<ConsultaMedicamento> BuscarConsultaMedicamen(string dato)
        {
            return CONMED.BuscarConsultMedicamen(dato);
        } 

    }
}
