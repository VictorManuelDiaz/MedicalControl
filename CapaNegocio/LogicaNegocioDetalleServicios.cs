using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    class LogicaNegocioDetalleServicios
    {

        AccesoDatosDetalleServicios DESER = new AccesoDatosDetalleServicios();

        public int InsertarDetalleServicios(DetalleServicios des)
        {
            return DESER.InsertarDetServicios(des);
        }

        public List<DetalleServicios> ListarDetServicios()
        {
            return DESER.ListarDetServicios();
        }

        public int EliminarDetServicios(int IdDetServi)
        {
            return DESER.EliminarDetServicios(IdDetServi);
        }

        public int EditarDetServicios(DetalleServicios DES)
        {
            return DESER.EditarDetServicios(DES);
        }

        public List<DetalleServicios> BuscarDetServicios(string dato)
        {
            return DESER.BuscarDetServicios(dato);
        } 

    }
}
