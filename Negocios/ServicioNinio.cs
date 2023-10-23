using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class ServicioNinio
    {
        public int Id { get; set; }
        public int NiñoId { get; set; }
        public string Nombre { get; set; }

        public string descripciion { get; set; }
        public double Costo { get; set; }
        public DateTime Fecha { get; set; }

    }
}
