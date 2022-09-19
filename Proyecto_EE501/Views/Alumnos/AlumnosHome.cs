using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EjemploLibreriaForms.Alumnos;
using MaterialSkin.Controls;
using MaterialSkin;

namespace EjemploLibreriaForms
{
    public partial class AlumnosHome : MaterialForm
    {
        public AlumnosHome()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new BuscarAlumno().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AgregarAlumno().Show();
        }
    }
}
