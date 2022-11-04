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
using EjemploLibreriaForms.para_BD;
using System.Collections;

namespace EjemploLibreriaForms.Alumnos
{
    public partial class BuscarAlumno : MaterialForm
    {
        private List<AlumnoModel> alumnos = new List<AlumnoModel>();
        int Cud = 0;

        public bool isEditing = false;

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
            BD.AbrirDB();
            CargarGrilla();
            BD.CerrarDB();
            chkb_CudNo.Checked = true;
        }

        private void CargarGrilla()
        {

            string Alumnos = "Select * From Alumnos";
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = BD.CargarGrilla(Alumnos);
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void CargarDatosAlumnoParaEditar()
        {
            //var id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Id"].Value;
            string cud = dataGridView1.CurrentRow.Cells["Cud"].Value.ToString();
            if (cud == "True")
            {
                chkb_CudSi.Checked = true;
                chkb_CudNo.Checked = false;
            }
            else 
            {
                chkb_CudSi.Checked = false;
                chkb_CudNo.Checked = true;
            }

            txt_dNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            txt_dApellido.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Apellido"].Value.ToString();
            txt_dCuit.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Cuit"].Value.ToString();
            dtp_dFechaNacimiento.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Fecha_Nacimi"].Value.ToString();
            txt_dDomicilio.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Domicilio"].Value.ToString();
            txt_dLocalidad.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Localidad"].Value.ToString();
            txt_DOS.Text = dataGridView1.CurrentRow.Cells["Obra_Social"].Value.ToString();
            //txt_dAlumnoTel1.Text = alumnoToEdit.Telefono1;
            //txt_dAlumnoTel2.Text = alumnoToEdit.Telefono2;

            //txt_dNivel.Text = alumnoToEdit.Nivel;
            //txt_dFormacion.Text = alumnoToEdit.Formacion;
            //txt_dCiclo.Text = alumnoToEdit.Ciclo;
            //txt_dCaracterizacion.Text = alumnoToEdit.Caracterizacion;
        }

        private void BorrarDatosAlumno()
        {
            txt_dNombre.Text = "";
            txt_dApellido.Text = "";
            chkb_CudNo.Checked = false;
            chkb_CudSi.Checked = false;
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
            isEditing = false;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CargarDatosAlumnoParaEditar();
            tabControl1.TabPages.Remove(tabPageListaAlumnos);
            tabControl1.TabPages.Add(tabPageDetalleAlumno);
            tabPageDetalleAlumno.Text = "Editar Alumno";
            isEditing = true;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageDetalleAlumno);
            tabControl1.TabPages.Add(tabPageListaAlumnos);
            checkBox1.Checked = false;

            if (!isEditing)
            {
                /************  Insert de Alumno *************/
                BD.AbrirDB();
                string Legajo = "SELECT TOP 1 * FROM Alumnos ORDER BY Id DESC";
                BD.LecturaDB(Legajo);
                int ult_leg = 0;
                while (BD.lector.Read())
                    ult_leg = Convert.ToInt32(BD.lector["Num_Legajo"]) + 1;
                string AltaAlum = "INSERT INTO Alumnos(Apellido, Nombre, Domicilio, Localidad,Cud,Fecha_Nacimi,Cuit,Obra_Social,Num_Legajo) VALUES (' " +
                txt_dApellido.Text + " ' , ' " + txt_dNombre.Text + " ' , ' " + txt_dDomicilio.Text + " ' , ' " + txt_dLocalidad.Text + "'," + Cud + ",'" + dtp_dFechaNacimiento.Value.ToString("dd/MM/yyyy") + "','" + txt_dCuit.Text + "','" + txt_DOS.Text + "'," + ult_leg + ") ; ";
                BD.CargarDB(AltaAlum);

                /************  Insert de Telefono 1 *************/
                //uint tel1 = unchecked((uint)Convert.ToInt32(txt_dAlumnoTel1.Text));
                //InsertarTelefono(tel1);
                InsertarTelefono(txt_dAlumnoTel1.Text);

                /************  Insert de Telefono 2 *************/
                if (txt_dAlumnoTel2.Text != "") 
                {
                    InsertarTelefono(txt_dAlumnoTel2.Text);
                }
                /************ Actualizar Grilla *************/
                CargarGrilla();
                BD.CerrarDB();
                MessageBox.Show("Alumno registrado exitosamente!");
                BorrarDatosAlumno();

            }
            else
            {
                BD.AbrirDB();
                string AltaAlum = "UPDATE [Alumnos] SET Apellido=?, Nombre=?, Domicilio=?, Localidad=?,Cud=?,Fecha_Nacimi=?,Cuit=?,Obra_Social=? WHERE Id=?";
                var parametros = new Dictionary<string, string>();
                parametros.Add("@Apellido", txt_dApellido.Text);
                parametros.Add("@Nombre", txt_dNombre.Text);
                parametros.Add("@Domicilio", txt_dDomicilio.Text);
                parametros.Add("@Localidad", txt_dLocalidad.Text);
                parametros.Add("@Cud", CheckCudChecked().ToString());
                parametros.Add("@FechaNacimiento", DateTime.Parse((dtp_dFechaNacimiento.Text)).ToString("dd/MM/yyyy"));
                parametros.Add("@Cuit", txt_dCuit.Text);
                parametros.Add("@Obra", txt_DOS.Text);
                parametros.Add("@Id", GetAlumnoId().ToString());
                BD.CargarDB(AltaAlum, parametros);
                CargarGrilla();
                BD.CerrarDB();
                MessageBox.Show("Datos editados exitosamente!");
                BorrarDatosAlumno();
            }

        }

        private void InsertarTelefono(string numTelefono)
        {
            string insertTel = "INSERT INTO Telefonos (Num_Tel) VALUES ('" + numTelefono + "');";
            BD.CargarDB(insertTel);

            string getAlumnoLastId = "SELECT TOP 1 * FROM Alumnos ORDER BY Id DESC";
            BD.LecturaDB(getAlumnoLastId);
            int alumnoLastId = 0;
            while (BD.lector.Read())
                alumnoLastId = Convert.ToInt32(BD.lector["Id"]);

            string getTelLastId = "SELECT TOP 1 * FROM Telefonos ORDER BY Id DESC";
            BD.LecturaDB(getTelLastId);
            int TelLastId = 0;
            while (BD.lector.Read())
                TelLastId = Convert.ToInt32(BD.lector["Id"]);

            string insertTel_Alumno_Tel = "INSERT INTO Alum_Tel (Id_Alum, Id_Tel) VALUES (" + alumnoLastId + "," + TelLastId + ");";
            BD.CargarDB(insertTel_Alumno_Tel);
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
                BD.AbrirDB();
                string consulta = "delete from Alumnos where Id = (" + GetAlumnoId() + ");";
                BD.CargarDB(consulta);
                MessageBox.Show("Alumno eliminado correctamente!");
                CargarGrilla();
                BD.CerrarDB();
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
            GetAlumnoId();
        }

        private int GetAlumnoId()
        {
            return Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Id"].Value);
        
        }

        private int CheckCudChecked()
        {
            if (chkb_CudSi.Checked)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        private void chkb_CuitSi_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkb_CudSi.Checked)
            {
                chkb_CudNo.Checked = false;
                Cud = -1;
            }
            else
            {
                chkb_CudNo.Checked = true;
                Cud = 0;
            }
        }

        private void chkb_CuitNo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkb_CudNo.Checked)
            {
                chkb_CudSi.Checked = false;
                Cud = 0;
            }
            else
            {
                chkb_CudSi.Checked = true;
                Cud = -1;
            }
        }
    }
}
