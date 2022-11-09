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
            Metodos.CambiarTAb(tabControl1, tabPageListaGrupos, tabPageDetalleGrupo);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, tabPageDetalleGrupo, tabPageListaGrupos);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, tabPageDetalleGrupo, tabPageListaGrupos);
        }

        private void btnAddAlumnoToGroup_Click(object sender, EventArgs e)
        {;
            Metodos.CambiarTAb(tabControl1, tabPageListaGrupos, tabPageGrupoNuevoAlumno);
        }

        private void btnAddAlumnoToList_Click(object sender, EventArgs e)
        {
            var alumno = this.GetSelectedRowAsAlumno();
            string alumnoStringToAdd = string.Format("{0} {1} {2}", alumno.Cuit, alumno.Nombre, alumno.Apellido);
            if (!listBox1.Items.Contains(alumnoStringToAdd)) 
            {
                listBox1.Items.Add(alumnoStringToAdd);
            }
            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, tabPageGrupoNuevoAlumno, tabPageListaGrupos);
        }
 
    }
}
