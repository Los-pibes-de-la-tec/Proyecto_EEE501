using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploLibreriaForms.Models
{
    class AlumnoModel
    {

        public AlumnoModel(string Nombre, string Apellido, string CUIT, DateTime FechaNacimiento,
            string Domicilio, string Localidad, string Telefono1, string Telefono2,
            string Nivel, string Formacion, string Ciclo, string Caracterizacion)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.CUIT = CUIT;
            this.FechaNacimiento = FechaNacimiento.ToShortDateString();
            this.Domicilio = Domicilio;
            this.Localidad = Localidad;
            this.Telefono1 = Telefono1;
            this.Telefono2 = Telefono2;
            this.Nivel = Nivel;
            this.Formacion = Formacion;
            this.Ciclo = Ciclo;
            this.Caracterizacion = Caracterizacion;
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CUIT { get; set; }
        public string FechaNacimiento { get; set; }
        public string Domicilio { get; set; }
        public string Localidad { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }

        public string Nivel { get; set; }
        public string Formacion { get; set; }
        public string Ciclo { get; set; }
        public string Caracterizacion { get; set; }
    }
}
