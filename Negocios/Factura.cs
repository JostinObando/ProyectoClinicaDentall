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
        public DateTime FechaFactura { get; set; }
        public string costoTotal { get; set; }
        public string NumeroFactura { get; set; }
    }
    public class xmlFacturaNueva
    {
        public Factura Facturaxml;

        public List<Servicio> servicios;
        public xmlFacturaNueva()
        {
            Facturaxml = new Factura();
            servicios = new List<Servicio>();
        }
    }

    public class XmlFactura
    {
        public List<xmlFacturaNueva> Facturaxml;

        public XmlFactura()
        {
            Facturaxml = new List<xmlFacturaNueva>();
        }

    }
}
