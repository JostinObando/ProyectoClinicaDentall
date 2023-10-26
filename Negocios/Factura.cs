using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Factura
    {
        public string NombreNinio { get; set; }
        public string ApellidoNinio { get; set; }
        public string Identificacion { get; set; }

        public string servicio { get; set; }    
    }
    public class xmlFactura
    {
        public List<Factura> Facturaxml;
        public xmlFactura()
        {
            Facturaxml = new List<Factura>();
        }
    }
}
