using System.Globalization;
using System.Windows;

namespace Negocios
{
    public class IniciarSesion
    {
        //Usuario y contraseña
        private const string UsuarioCorrecto = "Admin";
        private const string ContraseñaCorrecta = "Admin";

        string usuarioIngresado = "";
        string contraseñaIngresada = "";

        //Booleano de registro
        public bool Registro(string usuarioIngresado, string contraseñaIngresada)
        {


            return usuarioIngresado == UsuarioCorrecto && contraseñaIngresada == ContraseñaCorrecta;
        }
    }
}