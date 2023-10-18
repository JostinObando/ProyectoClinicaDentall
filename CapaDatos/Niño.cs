namespace CapaDatos
{
    public class Niño
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string IdentificacionPadre { get; set; }

        public Niño(string nombre, string apellido, string identificacion, DateTime fechaNacimiento, string sexo, string identificacionPadre)
        {
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificacion;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
            IdentificacionPadre = identificacionPadre;


        }
    }
}