﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class LogicaNegocioUsuario
    {
        AccesoDatosUsuario USU = new AccesoDatosUsuario();

        public int InsertarUsuario(Usuario Usu)
        {
            return USU.InsertarUsuario(Usu);
        }

        public List<Usuario> ListarUsuario()
        {
            return USU.ListarUsuario();
        }

        public int EliminarUsuario(int IdMed)
        {
            return USU.EliminarUsuario(IdMed);
        }

        public int EditarUsuario(Usuario Usu)
        {
            return USU.EditarUsuario(Usu);
        }
        public int ListarIdMedico(int IdCuenta)
        {
            return USU.ListarIdMedico(IdCuenta);
        }
    }
}

