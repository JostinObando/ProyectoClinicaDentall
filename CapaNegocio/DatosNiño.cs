using CapaDatos;
using System.Globalization;
using System.Windows;


namespace CapaNegocio
{
    public class DatosNiño
    {
        string nombre = "";
        string apellido = "";
        string identificacion = "";
        DateTime fechaNacimiento;
        string identificacionPadre = "";
        string sexo = "";
        private List<Niño> listaNiño = new List<Niño>();
        Niño niño;

        //public string RegistroNinio(string nombre, string apellido, string identificacion, DateTime fechaNacimiento, string sexo, string identificacionPadre)
        //{
        //    if (string.IsNullOrEmpty(sexo))
        //    {
        //        throw new ArgumentException("Por favor seleccione el sexo");
        //    }

        //    //DateTime unAñoAtras = DateTime.Now.AddYears(-1);
        //    //if (fechaNacimiento <= unAñoAtras)
        //    //{
        //    //    throw new ArgumentException("La fecha de nacimiento tiene que ser mayor a un año");
        //    //}
        //    DateTime unAñoAtras = DateTime.Now.AddYears(-1);
        //    DateTime FechaNacimiento;

        //    try
        //    {
        //        fechaNacimientos = DateTime.ParseExact(fechaNacimiento, "MM/dd/yyyy", CultureInfo.InvariantCulture);
        //    }
        //    catch (FormatException)
        //    {
        //        throw new ArgumentException("Formato de fecha incorrecto. Use el formato MM/dd/yyyy.");
        //    }

        //    if (fechaNacimiento <= unAñoAtras)
        //    {
        //        throw new ArgumentException("La fecha de nacimiento tiene que ser mayor a un año");
        //    }

        //    DateTime seisMesesAtras = DateTime.Now.AddMonths(-6);
        //    DateTime catorceAñosAtras = DateTime.Now.AddYears(-14);

        //    if (fechaNacimiento >= catorceAñosAtras && fechaNacimiento <= seisMesesAtras)
        //    {
        //        throw new ArgumentException("El niño debe ser menor de 6 meses o mayor de 14 años");
        //    }
        //    if (IdentificacionExistente(identificacion))
        //    {
        //        throw new ArgumentException("Identificación ya registrada en el sistema");
        //    }

        //    // Si todas las validaciones pasan, continuar con el registro
        //    Niño nuevo = new Niño(nombre, apellido, identificacion, fechaNacimiento, sexo, identificacionPadre);
        //    listaNiño.Add(nuevo);
        //    return "HOLA MUNDO";
        //}
        public string RegistroNinio(string nombre, string apellido, string identificacion, string fechaNacimiento, string sexo, string identificacionPadre)
        {
            if (string.IsNullOrEmpty(sexo))
            {
                throw new ArgumentException("Por favor seleccione el sexo");
            }

            DateTime unAñoAtras = DateTime.Now.AddYears(-1);
            DateTime fechaNacimientos;


            //if (Convert.ToDateTime(fechaNacimiento) <= unAñoAtras)
            //{
            //    throw new ArgumentException("La fecha de nacimiento tiene que ser mayor a un año");
            //}

            //DateTime seisMesesAtras = DateTime.Now.AddMonths(-6);
            //DateTime catorceAñosAtras = DateTime.Now.AddYears(-14);

            //if (Convert.ToDateTime(fechaNacimiento) >= catorceAñosAtras || Convert.ToDateTime(fechaNacimiento) <= seisMesesAtras)
            //{
            //    throw new ArgumentException("El niño debe ser menor de 6 meses o mayor de 14 años");
            //}

            if (IdentificacionExistente(identificacion))
            {
                throw new ArgumentException("Identificación ya registrada en el sistema");
            }

            // Si todas las validaciones pasan, continuar con el registro
            Niño nuevo = new Niño(nombre, apellido, identificacion, Convert.ToDateTime(fechaNacimiento), sexo, identificacionPadre);
            listaNiño.Add(nuevo);
            return "HOLA MUNDO";
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
