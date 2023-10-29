using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Factura
    {
        //get y set de Factura
        public string NombreNinio { get; set; }
        public string ApellidoNinio { get; set; }
        public string Identificacion { get; set; }
        public DateTime FechaFactura { get; set; }
        public string costoTotal { get; set; }
        public string NumeroFactura { get; set; }
    }
    //Inicio xml Factura
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
