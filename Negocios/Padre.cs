using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Padre
    {
        public string Nombre { get; set; }
        public string Identicacion { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

       
    }


    public class xmlPadre
    {
        public List<Padre> padreXml;
        public xmlPadre()
        {
            padreXml = new List<Padre>();
        }
    }

    
}
