using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class LogicaNegocioCuentas
    {

        AccesoDatosCuenta AC = new AccesoDatosCuenta();

        public int InsertarCuenta(Cuenta cu)
        {
            return AC.InsertarCuenta(cu);
        }

        public List<Cuenta> ListarCuenta()
        {
            return AC.ListarCuenta();
        }

        public int EliminarCuenta(int IdCuenta)
        {
            return AC.EliminarCuenta(IdCuenta);
        }

        public int EditarCuenta(Cuenta cu)
        {
            return AC.EditarCuenta(cu);
        }

        public List<Cuenta> ValidarCuenta(string nom, string contra)
        {
            return AC.ValidarCuenta(nom, contra);
        }
        public string ObtenerTipoUsuario(string nom, string contra)
        {
            return AC.ObtenerTipoUsuario(nom, contra);
        }
        public List<Cuenta> BuscarCuenta(string nom)
        {
            return AC.BuscarCuenta(nom);
        }
        public List<Cuenta> ListarCuentaUsuario()
        {
            return AC.ListarCuentaUsuario();
        }

        public int BuscarIdCuenta(string nom)
        {
            return AC.BuscarIdCuenta(nom);
        }
    }
}
