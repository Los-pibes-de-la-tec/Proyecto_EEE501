using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploLibreriaForms.Models
{
    class DocenteModel
    {
         public DocenteModel(string Nombre, string Apellido, string CUIT,string Telefono,string Email)
         {
             this.Nombre = Nombre;
             this.Apellido = Apellido;
             this.CUIT = CUIT;
             this.Telefono = Telefono;
             this.Email = Email;

         }
         public string Nombre { get; set; }
         public string Apellido { get; set; }
         public string CUIT { get; set; }
         public string Telefono { get; set; }
         public string Email { get; set; }

    }
}
