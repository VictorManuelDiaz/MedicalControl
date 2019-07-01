using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    class LogicaNegocioMedicamentos
    {

        AccesoDatosMedicamentos MED = new AccesoDatosMedicamentos();

        public int InsertarMedicamentos(Medicamento me)
        {
            return MED.InsertarMedicamentos(me);
        }

        public List<Medicamento> ListarMedicamentos()
        {
            return MED.ListarMedicamentos();
        }

        public int EliminarMedicamentos(int IdMedica)
        {
            return MED.EliminarMedicamentos(IdMedica);
        }

        public int EditarMedicamento(Medicamento Med)
        {
            return MED.EditarMedicamento(Med);
        }

        public List<Medicamento> BuscarMedicamento(string dato)
        {
            return MED.BuscarMedicamento(dato);
        } 

    }
}
