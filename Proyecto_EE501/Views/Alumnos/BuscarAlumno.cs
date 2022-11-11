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
            CargarGrilla();
            chkb_CudNo.Checked = true;
        }

        private void CargarGrilla()
        {
            string Alumnos = "Select Apellido,Nombre,Cuit,Cud,Id From Alumnos";
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = BD.CargarGrilla(Alumnos);
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Cud"].Visible = false;
        }

        private void CargarDatosAlumnoParaEditar(TextBox Apellido, TextBox Nombre, TextBox Cuit, DateTimePicker Fecha, TextBox Domicilio, TextBox Localidad, TextBox OS)
        {
            string cud = dataGridView1.CurrentRow.Cells["Cud"].Value.ToString();
            string ConsAlumno = "Select * from Alumnos Where Id =" + GetAlumnoId() + "";
            BD.LecturaDB(ConsAlumno);
            while (BD.lector.Read())
            {
                Apellido.Text = BD.lector["Apellido"].ToString();
                Nombre.Text = BD.lector["Nombre"].ToString();
                Cuit.Text = BD.lector["Cuit"].ToString();
                Fecha.Text = BD.lector["Fecha_Nacimi"].ToString();
                Domicilio.Text = BD.lector["Domicilio"].ToString();
                Localidad.Text = BD.lector["Localidad"].ToString();
                OS.Text = BD.lector["Obra_Social"].ToString();
            }
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

            //txt_dNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            //txt_dApellido.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Apellido"].Value.ToString();
            //txt_dCuit.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Cuit"].Value.ToString();
            //dtp_dFechaNacimiento.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Fecha_Nacimi"].Value.ToString();
            //txt_dDomicilio.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Domicilio"].Value.ToString();
            //txt_dLocalidad.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Localidad"].Value.ToString();
            //txt_DOS.Text = dataGridView1.CurrentRow.Cells["Obra_Social"].Value.ToString();
        }

        private void ObtenerNumTel(TextBox Tel1, TextBox Tel2)
        {
            string Numtels = "Select Num_Tel From Telefonos Inner Join Alum_Tel on Telefonos.Id = Alum_Tel.Id_Tel where Alum_Tel.Id_Alum =" + GetAlumnoId() + "";
            BD.LecturaDB(Numtels);
            int ContadorDetels = 0;
            while (BD.lector.Read())
            {
                if (ContadorDetels == 0)
                {
                    Tel1.Text = Convert.ToString(BD.lector["Num_Tel"]);
                }
                else
                {
                    Tel2.Text = Convert.ToString(BD.lector["Num_Tel"]);
                }
                ContadorDetels++;

            }
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
            Metodos.CambiarTAb(tabControl1, tabPageListaAlumnos, tabPageDetalleAlumno);
            checkBox1.Checked = false;
            tabPageDetalleAlumno.Text = "Agregar Nuevo";
            isEditing = false;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CargarDatosAlumnoParaEditar(txt_dApellido, txt_dNombre, txt_dCuit, dtp_dFechaNacimiento, txt_dDomicilio, txt_dLocalidad, txt_DOS);
            ObtenerNumTel(txt_dAlumnoTel1, txt_dAlumnoTel2);
            checkBox1.Checked = true;
            Metodos.CambiarTAb(tabControl1, tabPageListaAlumnos, tabPageDetalleAlumno);
            tabPageDetalleAlumno.Text = "Editar Alumno";
            isEditing = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            if (txt_dNombre.Text != "" & txt_dApellido.Text != "" & txt_dLocalidad.Text != "" & txt_dCuit.Text != "" & txt_DOS.Text != "" & txt_dDomicilio.Text != "")
            {
                if (!isEditing)
                {
                    /************  Insert de Alumno *************/
                    string Legajo = "SELECT TOP 1 * FROM Alumnos ORDER BY Id DESC";
                    BD.LecturaDB(Legajo);
                    int ult_leg = 0;
                    while (BD.lector.Read())
                        ult_leg = Convert.ToInt32(BD.lector["Num_Legajo"]) + 1;
                    string AltaAlum = "INSERT INTO Alumnos(Apellido, Nombre, Domicilio, Localidad,Cud,Fecha_Nacimi,Cuit,Obra_Social,Num_Legajo) VALUES (' " +
                    txt_dApellido.Text + " ' , ' " + txt_dNombre.Text + " ' , ' " + txt_dDomicilio.Text + " ' , ' " + txt_dLocalidad.Text + "'," + Cud + ",'" + dtp_dFechaNacimiento.Value.ToString("dd/MM/yyyy") + "','" + txt_dCuit.Text + "','" + txt_DOS.Text + "'," + ult_leg + ") ; ";
                    BD.CargarDB(AltaAlum);
                    /************  Insert de Telefono 1 *************/
                    InsertarTelefono(txt_dAlumnoTel1.Text);
                    /************  Insert de Telefono 2 *************/
                    if (txt_dAlumnoTel2.Text != "")
                    {
                        InsertarTelefono(txt_dAlumnoTel2.Text);
                    }
                    else
                    {
                        InsertarTelefono("0000000000");
                    }
                    /************ Actualizar Grilla *************/
                    CargarGrilla();
                    Metodos.CambiarTAb(tabControl1, tabPageDetalleAlumno, tabPageListaAlumnos);
                    MessageBox.Show("Alumno registrado exitosamente!");
                    BorrarDatosAlumno();

                }
                else
                {
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
                    string Numtels = "Select T.Id, T.Num_Tel From Telefonos AS T Inner Join Alum_Tel AS Alum on T.Id = Alum.Id_Tel where Alum.Id_Alum =" + GetAlumnoId() + "";
                    BD.LecturaDB(Numtels);
                    string telId1 = "";
                    string telId2 = "";
                    int rowsCounter = 0;
                    while (BD.lector.Read())
                    {

                        if (rowsCounter == 0)
                        {
                            telId1 = BD.lector["Id"].ToString();
                        }
                        else
                        {
                            telId2 = BD.lector["Id"].ToString();
                        }
                        rowsCounter++;
                    }

                    UpdateTelefono(txt_dAlumnoTel1.Text, telId1);
                    if (txt_dAlumnoTel2.Text != "")
                    {
                        UpdateTelefono(txt_dAlumnoTel2.Text, telId2);
                    }

                    CargarGrilla();
                    MessageBox.Show("Datos editados exitosamente!");
                    Metodos.CambiarTAb(tabControl1, tabPageDetalleAlumno, tabPageListaAlumnos);
                    BorrarDatosAlumno();
                }
            }
            else
            {
                MessageBox.Show("Faltan llenar datos");
            }

        }

        private void UpdateTelefono(string numTelefenoToUpdate, string telId)
        {
            string updateTelNumber = "UPDATE [Telefonos] SET Num_Tel=? WHERE Id=?";
            var telParam = new Dictionary<string, string>();
            telParam.Add("@Telefono", numTelefenoToUpdate);
            telParam.Add("@Id", telId);
            BD.CargarDB(updateTelNumber, telParam);
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
            Metodos.CambiarTAb(tabControl1, tabPageDetalleAlumno, tabPageListaAlumnos);
            BorrarDatosAlumno();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro que quieres eliminar este ALUMNO?", "Advertencia",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string consulta = "delete from Alumnos where Id = (" + GetAlumnoId() + ");";
                BD.CargarDB(consulta);
                MessageBox.Show("Alumno eliminado correctamente!");
                CargarGrilla();
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
                    Metodos.CambiarTAb(tabControl1, tabPageListaAlumnos, tabPageNuevoAdulto);
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
            Metodos.CambiarTAb(tabControl1, tabPageListaAlumnos, tabPageLegajo);
            string legajo = "Select * from Alumnos where Id= (" + GetAlumnoId() + ");";
            BD.LecturaDB(legajo);
            while (BD.lector.Read())
            {
                textBox15.Text = Convert.ToString(BD.lector["Num_Legajo"]);
                Txt_LLugar.Text = Convert.ToString(BD.lector["Lugar"]);
                txt_Lpens.Text = Convert.ToString(BD.lector["Pension"]);
                CargarDatosAlumnoParaEditar(Txt_Lape, Txt_Lnom, Txt_LCui, dateTimePicker3, Txt_Ldomi, Txt_LLOC, Txt_Los);
                ObtenerNumTel(textBox22, textBox23);

            }
        }


        private void btnObservaciones_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, tabPageLegajo, tabPageObservaciones);
        }

        private void btnLegajoDetalle_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, tabPageLegajo, tabPageDetalleLegajo);
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
            ;
            Metodos.CambiarTAb(tabControl1, tabPageListaAlumnos, tabPageIngresarACurso);
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

        private void Btn_Atras_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, tabPageLegajo, tabPageListaAlumnos);
        }

        private void btnCancel2_Click_1(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageNuevoAdulto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, tabPageIngresarACurso, tabPageListaAlumnos);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, tabPageObservaciones, tabPageLegajo);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, tabPageDetalleLegajo, tabPageLegajo);
        }

        private void txt_lCuit_TextChanged(object sender, EventArgs e)
        {
            if (txt_lCuit.Text != "")
            {
                string FiltroCuit = "Select * From Alumnos where Cuit like'%" + txt_lCuit.Text + "%'";
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.DataSource = BD.CargarGrilla(FiltroCuit);
            }
            else
            {
                this.CargarGrilla();
            }
        }

        private void txt_dAlumnoTel2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten Numeros");
                e.Handled = true;

            }
        }
    }
}
