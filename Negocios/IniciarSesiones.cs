using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    internal class IniciarSesiones
    {

        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }


        public IniciarSesiones(string nombreUsuario, string contrasenia)
        {
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;

        }
    }
}
