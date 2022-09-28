using EjemploLibreriaForms.Alumnos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace EjemploLibreriaForms.Views
{
    public partial class MainView : Form
    {

        public MainView()
        {
            InitializeComponent();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            BuscarAlumno Alumno = new BuscarAlumno();

            var view = this.GetInstace(this, Alumno);
        }

        //Singleton pattern (Open a single form instance)
        private static Form instance;
        public Form GetInstace(Form parentContainer,Form XD)
        {
            instance = null;
            if (instance == null || instance.IsDisposed)
            {

                instance = XD;
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
               
            }
            
            return instance;
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Seguro que quieres cerrar la aplicación?",
                    "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) { 
                this.Dispose();
                Application.Exit();
            }

            else
                e.Cancel = true;
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            Docentes.BuscarDocente Docente = new Docentes.BuscarDocente();

            var view = this.GetInstace(this, Docente);
        }
    }
}
