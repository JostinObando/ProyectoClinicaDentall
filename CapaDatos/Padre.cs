﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Padre
    {
        public string Nombre { get; set; }
        public string Identicacion { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Padre(string nombre, string identificacion, string direccion, string correo, string telefono)
        {
            Nombre = nombre;
            Identicacion = identificacion;
            Direccion = direccion;
            Correo = correo;
            Telefono = telefono;

        }
    }
}
