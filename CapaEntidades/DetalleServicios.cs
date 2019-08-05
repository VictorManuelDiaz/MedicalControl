using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DetalleServicios
    {

        public int IdDetServic { get; set; }
        public double Precio { get; set; }
        public int IdExpediente { get; set; }
        public int IdServicios { get; set; }

    }
}
