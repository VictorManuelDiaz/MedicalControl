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
        public DateTime FechaConsul { get; set; }
        public DateTime FechaRealCita { get; set; }
        public string HoraC { get; set; }
        public int IdExpediente { get; set; }
        public int IdMedico { get; set; }

    }
}
