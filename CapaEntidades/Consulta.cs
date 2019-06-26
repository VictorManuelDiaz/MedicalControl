using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Consulta
    {

        public int IdConsulta { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Costo { get; set; }
        public string Sintomas { get; set; }
        public string Diagnostico { get; set; }
        public int NumeroExpediente { get; set; }
        public int IdMedico { get; set; }

    }
}
