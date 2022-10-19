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
using EjemploLibreriaForms.Models;
using System.Collections;

namespace EjemploLibreriaForms.Grupos
{
    public partial class BuscarGrupo : MaterialForm
    {
        private AlumnoModel alumnoToEdit;
        private List<AlumnoModel> alumnos = new List<AlumnoModel>();

        public bool isSuccessful { get; set; }

        public BuscarGrupo()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPageDetalleGrupo);
            tabControl1.TabPages.Remove(tabPageGrupoNuevoAlumno);
            Skin.CargarSkin(this);
            this.CargarGrilla();
        }

        private void BuscarAlumno_Load(object sender, EventArgs e) {  }

        private void CargarGrilla()
        {

            alumnos.Add(new AlumnoModel("Pepito", "Ramirez", "51453546", new DateTime(2014, 12, 31), "Belgrano 268", "San Vicente", "11111111", "222222222", "Primario", "SEDE", "1° Ciclo", "SV"));
            alumnos.Add(new AlumnoModel("Juanito", "Perez", "44566768", new DateTime(2004, 8, 23), "Av. Pres. Perón 6550", "Alejandro Korn", "11111111", "222222222", "SAFI", "SEDE", "2° Ciclo", "DV"));
            alumnos.Add(new AlumnoModel("Ramon", "Lopez", "43656765", new DateTime(2003, 4, 7), "Calle falsa 123", "Springfield", "11111111", "222222222", "Secundario", "INCLUSION", "2° Ciclo", "TEL"));

            dataGridView2.DataSource = alumnos;
        }

        private AlumnoModel GetSelectedRowAsAlumno()
        {
            foreach (DataGridViewRow row in this.dataGridView2.SelectedRows)
            {
                var alumnoToEdit = row.DataBoundItem as AlumnoModel;
                if (alumnoToEdit != null)
                {
                    return alumnoToEdit;
                }
            }
            return null;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageListaGrupos);
            tabControl1.TabPages.Add(tabPageDetalleGrupo);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPageListaGrupos);
            tabControl1.TabPages.Remove(tabPageDetalleGrupo);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageDetalleGrupo);
            tabControl1.TabPages.Add(tabPageListaGrupos);
        }

        private void btnAddAlumnoToGroup_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageListaGrupos);
            tabControl1.TabPages.Add(tabPageGrupoNuevoAlumno);
        }

        private void btnAddAlumnoToList_Click(object sender, EventArgs e)
        {
            var alumno = this.GetSelectedRowAsAlumno();
            string alumnoStringToAdd = string.Format("{0} {1} {2}", alumno.CUIT, alumno.Nombre, alumno.Apellido);
            if (!listBox1.Items.Contains(alumnoStringToAdd)) 
            {
                listBox1.Items.Add(alumnoStringToAdd);
            }
            
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
 
    }
}
