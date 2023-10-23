using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class ListaServicioss
    {
        public string Nombre { get; set; }
        public double Costo { get; set; }
        public ListaServicioss(string nombre, double costo)
        {
            Nombre = nombre;
            Costo = costo;


        }
    }
}
