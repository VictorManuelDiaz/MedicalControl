using System;
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
        public string GrupoEtnico { get; set; }
        public string DireccionHabitualPac { get; set; }
        public string NombrePadre { get; set; }
        public string NombreMadre { get; set; }
        public string ReligionPac { get; set; }
        public string ProcedenciaPac { get; set; }
        public string TelefonoPac { get; set; }
        public string EstadoCivilPac { get; set; }
        public char EnferICHepatitis { get; set; }
        public char EnferICSifilis { get; set; }
        public char EnferICColera { get; set; }
        public char EnferICTosferina { get; set; }
        public char EnferICSarampion { get; set; }
        public char EnferICVaricela { get; set; }
        public char EnferICRubeola { get; set; }
        public char EnferICPariotiditis { get; set; }
        public char EnferICMeningitis { get; set; }
        public char EnferICImpetigo { get; set; }
        public char EnferICTifoidea { get; set; }
        public char EnferICMalaria { get; set; }
        public char EnferICEscabiasis { get; set; }
        public char EnferICTina { get; set; }
        public char EnferHAlergias { get; set; }
        public char EnferHDiabetes { get; set; }
        public char EnferHHipertension { get; set; }
        public char EnferHReumatica { get; set; }
        public char EnferHRenales { get; set; }
        public char EnferHOculares { get; set; }
        public char EnferHCardiacas { get; set; }
        public char EnferHHepatica { get; set; }
        public char EnferHMusculares { get; set; }
        public char EnferHMalCongenitas { get; set; }
        public char EnferHDesorMentales { get; set; }
    }
}
