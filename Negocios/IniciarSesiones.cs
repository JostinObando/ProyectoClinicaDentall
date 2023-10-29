using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class IniciarSesiones
    {
        //Inicio de get y set

        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }


        //Parametros del get y set
        public IniciarSesiones(string nombreUsuario, string contrasenia)
        {
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;

        }
    }
}
