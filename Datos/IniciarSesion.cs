using System;
using System.Security.Cryptography.X509Certificates;

namespace Datos
{
    public class IniciarSesion
    {
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }


        public IniciarSesion(string nombreUsuario, string contrasenia)
        {
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;

        }

    }
}