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
        int Cud = 0;

        public bool isSuccessful { get; set; }

        public BuscarAlumno()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPageDetalleAlumno);
            tabControl1.TabPages.Remove(tabPageNuevoAdulto);
            tabControl1.TabPages.Remove(tabPageLegajo);
            tabControl1.TabPages.Remove(tabPageDetalleLegajo);
            tabControl1.TabPages.Remove(tabPageObservaciones);
            tabControl1.TabPages.Remove(tabPageIngresarACurso);
            Skin.CargarSkin(this);
            this.CargarGrillaObservaciones();
            this.CargarGrillaActasAdjuntas();
        }

        private void BuscarAlumno_Load(object sender, EventArgs e)
        {

            CargarGrilla();
            chkb_CuitNo.Checked = true;

        }

        private void CargarGrilla()
        {

            string Alumnos = "Select Id,Cuit,Apellido,Nombre,Localidad,Domicilio From Alumnos";
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = para_BD.BD.CargarGrilla(Alumnos);
            dataGridView1.Columns["Id"].Visible = false;
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
            //txt_dCuit.Text = alumnoToEdit.CUIT;
            dtp_dFechaNacimiento.Text = alumnoToEdit.FechaNacimiento;
            txt_dDomicilio.Text = alumnoToEdit.Domicilio;
            txt_dLocalidad.Text = alumnoToEdit.Localidad;
            txt_dAlumnoTel1.Text = alumnoToEdit.Telefono1;
            txt_dAlumnoTel2.Text = alumnoToEdit.Telefono2;
            //txt_dNivel.Text = alumnoToEdit.Nivel;
            //txt_dFormacion.Text = alumnoToEdit.Formacion;
            //txt_dCiclo.Text = alumnoToEdit.Ciclo;
            //txt_dCaracterizacion.Text = alumnoToEdit.Caracterizacion;
        }

        private void BorrarDatosAlumno()
        {
            txt_dNombre.Text = "";
            txt_dApellido.Text = "";
            chkb_CuitNo.Checked = false;
            chkb_CuitSi.Checked = false;
            txt_dCuit.Text = "";
            dtp_dFechaNacimiento.Text = DateTime.Now.ToShortDateString();
            txt_dDomicilio.Text = "";
            txt_dLocalidad.Text = "";
            txt_dAlumnoTel1.Text = "";
            txt_dAlumnoTel2.Text = "";
            txt_DOS.Text = "";
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
            isSuccessful = true;
            if (isSuccessful)
            {
                tabControl1.TabPages.Remove(tabPageDetalleAlumno);
                tabControl1.TabPages.Add(tabPageListaAlumnos);
            }
            checkBox1.Checked = false;

            string Legajo = "SELECT TOP 1 * FROM Alumnos ORDER BY Id DESC";
            para_BD.BD.LecturaDB(Legajo);
            int ult_leg = 0;
            while (para_BD.BD.lector.Read())
                ult_leg = Convert.ToInt32(para_BD.BD.lector["Num_Legajo"]) + 1;
            string AltaAlum = "INSERT INTO Alumnos(Apellido, Nombre, Domicilio, Localidad,Cud,Fecha_Nacimi,Cuit,Obra_Social,Num_Legajo) VALUES (' " +
            txt_dApellido.Text + " ' , ' " + txt_dNombre.Text + " ' , ' " + txt_dDomicilio.Text + " ' , ' " + txt_dLocalidad.Text + "'," + Cud + ",'" + dtp_dFechaNacimiento.Value.ToString("dd/MM/yyyy") + "'," + txt_dCuit.Text + ",'" + txt_DOS.Text + "'," + ult_leg + ") ; ";
            para_BD.BD.CargarDB(AltaAlum);
            CargarGrilla();
            MessageBox.Show("Alumno registrado exitosamente!");
            BorrarDatosAlumno();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageDetalleAlumno);
            tabControl1.TabPages.Add(tabPageListaAlumnos);
            BorrarDatosAlumno();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro que quieres eliminar este ALUMNO?", "Advertencia",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string consulta = "delete from Alumnos where Id = (" + getid() + ");";
                para_BD.BD.CargarDB(consulta);
                MessageBox.Show("Alumno eliminado correctamente!");
                CargarGrilla();
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
                    tabControl1.SelectedTab = tabControl1.TabPages["tabPageNuevoAdulto"];
                }
            }

        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageNuevoAdulto);
        }




        /* ----------------------------- Legajo -------------------------------------*/

        private void CargarGrillaObservaciones()
        {
            dataGridView2.Rows.Add(new string[] { "2020", "3", "Herreria", "8", "SAFI", "Aguante Bokita", "Buenas asistencias" });
        }

        private void CargarGrillaActasAdjuntas()
        {
            dataGridView3.Rows.Add(new string[] { "201", DateTime.Now.ToShortDateString(), "Informe inicial", "Aguante bokita" });
            dataGridView3.Rows.Add(new string[] { "202", DateTime.Now.ToShortDateString(), "Certificacion SAFI", "lorem ipsum bla bla..." });
        }

        private void btnLegajo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageListaAlumnos);
            tabControl1.TabPages.Add(tabPageLegajo);
        }

        private void btnObservaciones_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPageObservaciones);
            tabControl1.SelectedTab = tabControl1.TabPages["tabPageObservaciones"];
        }

        private void btnLegajoDetalle_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPageDetalleLegajo);
            tabControl1.SelectedTab = tabControl1.TabPages["tabPageDetalleLegajo"];
            richTextBox1.Text = dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[3].Value.ToString();
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[3].Value != null)
            {
                richTextBox1.Text = dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[3].Value.ToString();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPageIngresarACurso);
            tabControl1.SelectedTab = tabControl1.TabPages["tabPageIngresarACurso"];
        }

        private void txt_dCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&&!(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("pedazo de boludo ingresa un cuit numerico");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getid();
        }

        private int getid()
        {
            return Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Id"].Value);
        
        }

        private void chkb_CuitSi_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkb_CuitSi.Checked)
            {
                chkb_CuitNo.Checked = false;
                Cud = -1;
            }
            else
            {
                chkb_CuitNo.Checked = true;
                Cud = 0;
            }
        }

        private void chkb_CuitNo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkb_CuitNo.Checked)
            {
                chkb_CuitSi.Checked = false;
                Cud = 0;
            }
            else
            {
                chkb_CuitSi.Checked = true;
                Cud = -1;
            }
        }
    }
}
