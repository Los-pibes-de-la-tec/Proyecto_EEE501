using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using EjemploLibreriaForms.Alumnos;
using EjemploLibreriaForms.Docentes;
using EjemploLibreriaForms.Grupos;
using EjemploLibreriaForms.Domicilio;

namespace EjemploLibreriaForms.Views
{
    public partial class MainView : Form
    {

        public MainView()
        {
            InitializeComponent();
        }

        

        //Singleton pattern (Open a single form instance)
        private static Form instance;
        public Form GetInstace(Form parentContainer,Form childrenForm)
        {
            instance = null;
            if (instance == null || instance.IsDisposed)
            {

                instance = childrenForm;
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

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            var AlumnoForm = new BuscarAlumno();

            this.GetInstace(this, AlumnoForm);
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            BuscarDocente DocenteForm = new BuscarDocente();

            var view = this.GetInstace(this, DocenteForm);
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            var GrupoForm = new BuscarGrupo();

            this.GetInstace(this, GrupoForm);
        }

        private void btn_domicilio_Click(object sender, EventArgs e)
        {
            var Domicilio = new Domicilio.Domicilio();

            var view = this.GetInstace(this, Domicilio);
        }

        private void btn_docs_Click(object sender, EventArgs e)
        {
            var Documentos = new DocumentosHome();

            var view = this.GetInstace(this, Documentos);
        }
    }
}
