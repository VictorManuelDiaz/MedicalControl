using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class LogicaNegocioMedicamentos
    {

        AccesoDatosMedicamentos MEDI = new AccesoDatosMedicamentos();

        public int insertarMedicamentos(Medicamento Medi)
        {
            return MEDI.InsertarMedicamentos(Medi);
        }

        public List<Medicamento> listarMedicamentos()
        {
            return MEDI.ListarMedicamentos();
        }

        public int eliminarMedicamentos(int IdMedica)
        {
            return MEDI.EliminarMedicamentos(IdMedica);
        }

        public int editarMedicamento(Medicamento Medi)
        {
            return MEDI.EditarMedicamento(Medi);
        }

        public List<Medicamento> buscarMedicamento(string dato)
        {
            return MEDI.BuscarMedicamento(dato);
        } 

    }
}
