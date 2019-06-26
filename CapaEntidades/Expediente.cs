﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Expediente
    {
        public int NumeroExpediente { get; set; }
        public string MotivoConsulta { get; set; }
        public string TratamientoIndicado { get; set; }
        public string CedulaPac { get; set; }
        public string NombrePac { get; set; }
        public string ApellidosPac { get; set; }
        public string FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public string SexoPac { get; set; }
        public int EdadPac { get; set; }
        public int GrupoEtnico { get; set; }
        public string DireccionHabitualPac { get; set; }
        public string NombrePadre { get; set; }
        public string NombreMadre { get; set; }
        public string ReligionPac { get; set; }
        public string ProcedenciaPac { get; set; }
        public string TelefonoPac { get; set; }
        public string EstadoCivilPac { get; set; }

    }
}
