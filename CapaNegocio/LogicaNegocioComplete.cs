﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
   
    public class LogicaNegocioComplete
    {
        AccesoDatosComplete Com = new AccesoDatosComplete();
        public int buscarMedicoPorId(string dato)
        {
            return Com.BuscarMedicoPorId(dato);
        }

    }
}
