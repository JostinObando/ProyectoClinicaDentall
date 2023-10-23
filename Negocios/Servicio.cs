using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Servicio
    {
        public string Nombre { get; set; }
        public double CostonSinIva { get; set; }

        public Servicio(string nombre, double costosSinIva)
        {

            Nombre = nombre;
            CostonSinIva = costosSinIva;


        }
    }
}