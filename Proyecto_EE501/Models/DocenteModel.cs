using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploLibreriaForms.Models
{
    class DocenteModel
    {
         public DocenteModel(string Nombre, string Apellido, string DNI,string Telefono,string Grupo,string Email)
         {
             this.Nombre = Nombre;
             this.Apellido = Apellido;
             this.DNI = DNI;
             this.Telefono = Telefono;
             this.Grupo = Grupo;
             this.Email = Email;

         }
         public string Nombre { get; set; }
         public string Apellido { get; set; }
         public string DNI { get; set; }
         public string Telefono { get; set; }
         public string Grupo { get; set; }
         public string Email { get; set; }

    }
}
