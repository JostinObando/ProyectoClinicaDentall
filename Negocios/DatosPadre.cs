using System.Globalization;
using System.Windows;


namespace Negocios
{
    public class DatosPadre
    {
        private List<Padre> listaPadre = new List<Padre>();
        private List<Ninno> listaNiño = new List<Ninno>();

        //Se registra los datos brindados por el cliente
        string nombre = "";
        string identificacionPadre = "";
        string direccion = "";
        string correoPadre = "";
        string tel = "";

        private List<Padre> istaPadre = new List<Padre> ();
        Padre padre; 


        //public bool RegistroPadre(List<Padre> listaPadre)
        //{
        //txtNombrePadre.Text, txtIdendificacion.Text, txtDireccion.Text, txtCorreoElectronico.Text, txtTelefono.Text)
        public string RegistroPadre(string nombre, string identificacionPadre, string direccion, string correoPadre, string tel)
        {


            //Aqui se ve si ya la identificacion ya ha sido registrada
            if (identificacionExistente(identificacionPadre))
            {

                return "identificacion existente";
            }
            else
            {
                Padre nuevo = new Padre();

                nuevo.Nombre = nombre;
                nuevo.Identicacion = identificacionPadre;
                nuevo.Direccion = direccion;
                nuevo.Correo = correoPadre;
                nuevo.Telefono = tel;

                istaPadre.Add(nuevo);


            }


            return "";

        }

        private bool identificacionExistente(string identificacion)
        {
            //Validacion de identificaiones existentes
            foreach (Padre padre in istaPadre)
            {
                if (padre.Identicacion == identificacion)
                {
                    return true;

                }


            }
            return false;




        }
    }
}
