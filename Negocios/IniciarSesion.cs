using System.Globalization;
using System.Windows;
using Datos;

namespace Negocios
{
    public class IniciarSesion
    {
        private const string UsuarioCorrecto = "Admin";
        private const string ContraseñaCorrecta = "Admin";

        string usuarioIngresado = "";
        string contraseñaIngresada = "";

        public bool Registro(string usuarioIngresado, string contraseñaIngresada)
        {


            return usuarioIngresado == UsuarioCorrecto && contraseñaIngresada == ContraseñaCorrecta;
        }
    }
}