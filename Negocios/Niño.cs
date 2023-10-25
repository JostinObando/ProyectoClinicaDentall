using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Negocios
{
    public class Ninno
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string IdentificacionPadre { get; set; }
        public string costoTotal { get; set; }




    }

    public class xmlNinno
    {
        public Ninno ninno;
        public List<Servicio> servicios;
    }

    public class NinnoXML
    {
        public List<xmlNinno> ninnoxml;

        public NinnoXML()
        {
            ninnoxml = new List<xmlNinno>();
        }
    }
}
