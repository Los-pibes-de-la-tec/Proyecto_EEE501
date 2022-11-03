using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploLibreriaForms.Models
{
    class AlumnoModel
    {

        public AlumnoModel(int Id, string Nombre, string Apellido, string CUIT, DateTime FechaNacimiento,
            string Domicilio, string Localidad, string Telefono1, string Telefono2, int Num_Legajo)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Cuit = CUIT;
            this.Fecha_Nacimiento = FechaNacimiento.ToShortDateString();
            this.Num_Legajo = Num_Legajo;
            this.Domicilio = Domicilio;
            this.Localidad = Localidad;
            //this.Telefono1 = Telefono1;
            //this.Telefono2 = Telefono2;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cuit { get; set; }
        public int Num_Legajo { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public string Domicilio { get; set; }
        public string Localidad { get; set; }
        public int Cud { get; set; }
        //public string Telefono1 { get; set; }
        //public string Telefono2 { get; set; }
        //public 

        //public string Nivel { get; set; }
        //public string Formacion { get; set; }
        //public string Ciclo { get; set; }
        //public string Caracterizacion { get; set; }
    }
}
