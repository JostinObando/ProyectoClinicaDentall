using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class DatosPadre
    {
        //Se registra los datos brindados por el cliente
        string nombre = "";
        string identificacionPadre = "";
        string direccion = "";
        string correoPadre = "";
        string tel = "";
        private List<Padre> listaPadre = new List<Padre> { };

        public string RegistroPadre(string nombre, string identificacion, string direccion, string correo, string telefono)
        {


            //Aqui se ve si ya la identificacion ya ha sido registrada
            if (identificacionExistente(identificacionPadre))
            {
                

            }
            else
            {
                Padre nuevo = new Padre(nombre, identificacionPadre, direccion, correoPadre, tel);
                listaPadre.Add(nuevo);


            }


            return "";
        }

        private bool identificacionExistente(string identificacion)
        {
            //Validacion de identificaiones existentes
            foreach (Padre padre in listaPadre)
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
   

