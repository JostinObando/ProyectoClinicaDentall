using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ListaServicio
    {
        public string Nombre { get; set; }
        public double Costo { get; set; }
        public ListaServicio(string nombre, double costo) 
        {
            Nombre = nombre;
            Costo = costo;
        
        
        }
    }
}
