using System;
using System.Collections.Generic;
using System.Text;

namespace appconsolearreglo.cs
{
    class persona
    {
        private string nombre;
        private String cita;
        private String edad;

        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }


        public string Cita
        {
            get { return cita; }
            set { cita = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public persona()
        {
            Nombre = "";
            Cita = null;
            edad = "";
        }
        public persona(string nombre, string edad , string cita)
        {
            this.nombre = Nombre;
            this.cita = Cita;
            this.edad = Edad;

        }
        public override string ToString()
        {
            return nombre + " " + cita + " " + edad + " ";
        }


    }
    
}
