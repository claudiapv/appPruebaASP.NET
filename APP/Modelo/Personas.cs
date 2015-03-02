using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APP.Modelo
{
    public class Personas
    {

        private string id;

        private string nombre;

        private string direccion;

        private string telefonos;

        private string email;

     
        
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Telefonos
        {
            get { return telefonos; }
            set { telefonos = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}