using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace EjemploLibreriaForms.Alumnos
{
    public partial class BuscarAlumno : MaterialForm
    {
        public BuscarAlumno()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.CargarGrilla();
        }

        private void BuscarAlumno_Load(object sender, EventArgs e) {  }

        private void CargarGrilla() 
        {
            dataGridView1.Rows.Add("Pepito", "Ramirez", "Primario", "51453546", "SEDE", "1° Ciclo", "SV", "7");
            dataGridView1.Rows.Add("Juanito", "Perez", "SAFI", "44566768", "SEDE", "2° Ciclo", "DV", "5");
            dataGridView1.Rows.Add("Ramiro", "Lopez", "Secundario", "43656765", "INCLUSION", "2° Ciclo", "TEL", "10");
        }

    }
}
