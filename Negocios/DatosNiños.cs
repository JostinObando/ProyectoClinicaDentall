using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocios
{
    public class DatosNiños

    {
        string nombre = "";
        string apellido = "";
        string identificacion = "";
        DateTime fechaNacimiento;
        string identificacionPadre = "";
        string sexo = "";
        private List<Niño> listaNiño = new List<Niño>();
        Niño niño;

        /// <summary>
        /// Metodo registro Ninno
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="identificacion"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="sexo"></param>
        /// <param name="identificacionPadre"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public string RegistroNinio(string nombre, string apellido, string identificacion, string fechaNacimiento, string sexo, string identificacionPadre)
        {
            if (string.IsNullOrEmpty(sexo))
            {
                throw new ArgumentException("Por favor seleccione el sexo");
            }

            DateTime unAñoAtras = DateTime.Now.AddYears(-1);
            DateTime fechaNacimientos;




            if (IdentificacionExistente(identificacion))
            {
                throw new ArgumentException("Identificación ya registrada en el sistema");
            }

            // Si todas las validaciones pasan, continuar con el registro
            Niño nuevo = new Niño(nombre, apellido, identificacion, Convert.ToDateTime(fechaNacimiento), sexo, identificacionPadre);
            listaNiño.Add(nuevo);
            return "";
        }

        private bool IdentificacionExistente(string identificacion)
        {
            foreach (Niño niño in listaNiño)
            {
                if
                    (niño.Identificacion == identificacion)
                {
                    return true;

                }

            }
            return false;


        }
    }
}
