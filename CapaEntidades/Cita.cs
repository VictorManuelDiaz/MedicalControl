using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cita
    {

        public int IdCita { get; set; }
        public string FechaConsul { get; set; }
        public string FechaRealCita { get; set; }
        public string HoraC { get; set; }
        public int NumeroExpediente { get; set; }
        public int IdMedico { get; set; }

    }
}
