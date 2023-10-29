using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class DatosServe
    {
        //Get y set
        public string Nombre { get; set; }
        public double Costo { get; set; }
        public DatosServe(string nombre, double costo)
        {
            Nombre = nombre;
            Costo = costo;


        }


    }
}
