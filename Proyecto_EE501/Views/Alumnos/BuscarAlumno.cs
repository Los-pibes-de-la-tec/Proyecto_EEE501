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

namespace EjemploLibreriaForms.Alumnos
{
    public partial class BuscarAlumno : MaterialForm
    {
        private AlumnoModel alumnoToEdit;
        private List<AlumnoModel> alumnos = new List<AlumnoModel>();

        public bool isSuccessful { get; set; }

        public BuscarAlumno()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPageDetalleAlumno);
            tabControl1.TabPages.Remove(tabPageNuevoAdulto);
            Skin.CargarSkin(this);
            this.CargarGrilla();
        }

        private void BuscarAlumno_Load(object sender, EventArgs e) {  }

        private void CargarGrilla() 
        {

            alumnos.Add(new AlumnoModel("Pepito", "Ramirez", "51453546", new DateTime(2014, 12, 31), "Belgrano 268", "San Vicente", "11111111", "222222222", "Primario", "SEDE", "1° Ciclo", "SV"));
            alumnos.Add(new AlumnoModel("Juanito", "Perez", "44566768", new DateTime(2004, 8, 23), "Av. Pres. Perón 6550", "Alejandro Korn", "11111111", "222222222", "SAFI", "SEDE", "2° Ciclo", "DV"));
            alumnos.Add(new AlumnoModel("Ramon", "Lopez", "43656765", new DateTime(2003, 4, 7), "Calle falsa 123", "Springfield", "11111111", "222222222", "Secundario", "INCLUSION", "2° Ciclo", "TEL"));
          
            dataGridView1.DataSource = alumnos;
        }

        private AlumnoModel GetSelectedRowAsAlumno() 
        {
            //List<int> indexes = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();

            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                alumnoToEdit = row.DataBoundItem as AlumnoModel;
                if (alumnoToEdit != null)
                {
                    return alumnoToEdit;
                }
            }
            return null;
        }

        private void CargarDatosAlumnoParaEditar(AlumnoModel alumnoToEdit)
        {
            txt_dNombre.Text = alumnoToEdit.Nombre;
            txt_dApellido.Text = alumnoToEdit.Apellido;
            txt_dCuit.Text = alumnoToEdit.CUIT;
            dtp_dFechaNacimiento.Text = alumnoToEdit.FechaNacimiento;
            txt_dDomicilio.Text = alumnoToEdit.Domicilio;
            txt_dLocalidad.Text = alumnoToEdit.Localidad;
            txt_dAlumnoTel1.Text = alumnoToEdit.Telefono1;
            txt_dAlumnoTel2.Text = alumnoToEdit.Telefono2;
            txt_dNivel.Text = alumnoToEdit.Nivel;
            txt_dFormacion.Text = alumnoToEdit.Formacion;
            txt_dCiclo.Text = alumnoToEdit.Ciclo;
            txt_dCaracterizacion.Text = alumnoToEdit.Caracterizacion;
        }

        private void BorrarDatosAlumno()
        {
            txt_dNombre.Text = "";
            txt_dApellido.Text = "";
            txt_dCuit.Text = "";
            dtp_dFechaNacimiento.Text = DateTime.Now.ToShortDateString();
            txt_dDomicilio.Text = "";
            txt_dLocalidad.Text = "";
            txt_dAlumnoTel1.Text = "";
            txt_dAlumnoTel2.Text = "";
            txt_dNivel.Text = "";
            txt_dFormacion.Text = "";
            txt_dCiclo.Text = "";
            txt_dCaracterizacion.Text = "";
            checkBox1.Checked = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageListaAlumnos);
            tabControl1.TabPages.Add(tabPageDetalleAlumno);
            tabPageDetalleAlumno.Text = "Agregar Nuevo";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CargarDatosAlumnoParaEditar(GetSelectedRowAsAlumno());
            tabControl1.TabPages.Remove(tabPageListaAlumnos);
            tabControl1.TabPages.Add(tabPageDetalleAlumno);
            tabPageDetalleAlumno.Text = "Editar Alumno";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var alumnoToSave = new AlumnoModel(txt_dNombre.Text, txt_dApellido.Text, txt_dCuit.Text,
                dtp_dFechaNacimiento.Value, txt_dDomicilio.Text, txt_dLocalidad.Text,
                txt_dAlumnoTel1.Text, txt_dAlumnoTel2.Text, txt_dNivel.Text,
                txt_dFormacion.Text, txt_dCiclo.Text, txt_dCaracterizacion.Text);
            
            alumnos.Add(alumnoToSave);

            isSuccessful = true;
            if (isSuccessful)
            {
                tabControl1.TabPages.Remove(tabPageDetalleAlumno);
                tabControl1.TabPages.Add(tabPageListaAlumnos);
            }
            checkBox1.Checked = false;
            MessageBox.Show("Alumno registrado exitosamente!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageDetalleAlumno);
            tabControl1.TabPages.Add(tabPageListaAlumnos);
            BorrarDatosAlumno();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // obtiene el indice de la fila seleccionada en el GridView
            //int selectedRowCount =
            //    dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            var alumnoToDelete = GetSelectedRowAsAlumno();

            var result = MessageBox.Show("¿Estás seguro que quieres eliminar este ALUMNO?", "Advertencia",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //dataGridView1.Rows.RemoveAt(selectedRowCount);
                    alumnos = alumnos.Where(x => x.CUIT != alumnoToDelete.CUIT).ToList();
                    dataGridView1.DataSource = alumnos;
                    MessageBox.Show("Alumno eliminado correctamente!");
                }
        }

        private void txt_lNombre_TextChanged(object sender, EventArgs e)
        {
            if (txt_lNombre.Text != "")
            {
                var alumnosFiltrados = alumnos.Where(x => x.Nombre.Contains(txt_lNombre.Text)).ToList();
                dataGridView1.DataSource = alumnosFiltrados;
            }
            else
            {
                dataGridView1.DataSource = alumnos;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Visible = false;
                label8.Visible = true;
                txt_dAlumnoTel2.Visible = true;
            }
            else
            {
                checkBox1.Visible = true;
                label8.Visible = false;
                txt_dAlumnoTel2.Visible = false;
            }
        }


        /* ----------------------------- Adulto a cargo -------------------------------------*/

        private void chxAddNewAdulto1_CheckedChanged(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabPageNuevoAdulto)) 
            {
                if (chxAddNewAdulto1.Checked)
                {
                    tabControl1.TabPages.Add(tabPageNuevoAdulto);
                    tabControl1.SelectedTab = tabControl1.TabPages[1];
                }
            } 
            
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageNuevoAdulto);
        }

    }
}
