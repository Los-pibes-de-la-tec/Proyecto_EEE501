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
using EjemploLibreriaForms.para_BD;
using EjemploLibreriaForms.Models;
using System.Collections;

namespace EjemploLibreriaForms.Grupos
{
    public partial class BuscarGrupo : MaterialForm
    {

        public BuscarGrupo()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPageDetalleGrupo);
            tabControl1.TabPages.Remove(tabPageGrupoNuevoAlumno);
            Skin.CargarSkin(this);
            this.CargarGrilla(dataGridView1);
        }
        private bool isEditing = false;
        private void CargarGrilla(DataGridView Grilla)
        {
            string Grupo = "Select * From Grupo";
            Grilla.AutoGenerateColumns = true;
            Grilla.AllowUserToAddRows = false;
            Grilla.DataSource = BD.CargarGrilla(Grupo);
            Grilla.Columns["Id"].Visible = false;
            Grilla.Columns["Id_Docente"].Visible = false;
        }
        private void CargarGrillaGrupAlum()
        {
            string GrupAlum = "Select Alumnos.Nombre,Alumnos.Apellido,Alumnos.Cuit, GrupoAlumno.Id_Grupo,GrupoAlumno.Id_Alumno,GrupoAlumno.Id From Alumnos inner join GrupoAlumno on Alumnos.Id = GrupoAlumno.Id_Alumno where GrupoAlumno.Id_Grupo= (" + GetGrupoId(dataGridView2) + ");";
            dataGridView3.AutoGenerateColumns = true;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.DataSource = BD.CargarGrilla(GrupAlum);
            dataGridView3.Columns["Id_Alumno"].Visible = false;
            dataGridView3.Columns["Id"].Visible = false;
            dataGridView3.Columns["Id_Grupo"].Visible = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, tabPageListaGrupos, tabPageDetalleGrupo);
            isEditing = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, tabPageDetalleGrupo, tabPageListaGrupos);
            BorrarDatosGrupo();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Txt_Nombre.Text != "" & Txt_Formacion.Text != "" & Txt_Nivel.Text != "" & Txt_Turno.Text != "" & Txt_Ciclo.Text != "" & Txt_Caract.Text != "" & cmb_docente.SelectedIndex != -1)
            {
                if (!isEditing)
                {
                    string AltaGrup = "INSERT INTO Grupo(Cuit_Docente, Nivel, Formacion, Ciclo,Caracterizacion,Nombre,Turno) VALUES (' " +
                    Convert.ToInt32(cmb_docente.SelectedValue) + " ' , ' " + Txt_Nivel.Text + " ' , ' " + Txt_Formacion.Text + " ' , ' " + Txt_Ciclo.Text + " ' , '" + Txt_Caract.Text + "','" + Txt_Nombre.Text + " ' , '" + Txt_Turno.Text + "') ; ";
                    para_BD.BD.CargarDB(AltaGrup);
                    Metodos.CambiarTAb(tabControl1, tabPageDetalleGrupo, tabPageListaGrupos);
                    MessageBox.Show("Grupo registrado exitosamente!");
                    LlenarCombo();
                    CargarGrilla(dataGridView1);
                    BorrarDatosGrupo();
                }
                else
                {
                    string ModGrup = "UPDATE [Grupo] SET Id_Docente=?, Nivel=?, Formacion=?, Ciclo=?,Caracterizacion=?, Nombre=?, Turno=?  WHERE Id=?";
                    var parametros = new Dictionary<string, string>();
                    parametros.Add("@Id_Docente", cmb_docente.SelectedValue.ToString());
                    parametros.Add("@Nivel", Txt_Nivel.Text);
                    parametros.Add("@Formacion", Txt_Formacion.Text);
                    parametros.Add("@Ciclo", Txt_Ciclo.Text);
                    parametros.Add("@Caracterizacion", Txt_Caract.Text);
                    parametros.Add("@Nombre", Txt_Nombre.Text);
                    parametros.Add("@Turno", Txt_Turno.Text);
                    parametros.Add("@Id", GetGrupoId(dataGridView1).ToString());
                    para_BD.BD.CargarDB(ModGrup, parametros);
                    LlenarCombo();
                    CargarGrilla(dataGridView1);
                    MessageBox.Show("Datos editados exitosamente!");
                    Metodos.CambiarTAb(tabControl1, tabPageDetalleGrupo, tabPageListaGrupos);
                    BorrarDatosGrupo();
                }
            }

        }

        private void BorrarDatosGrupo()
        {
            Txt_Nombre.Text = "";
            Txt_Ciclo.Text = "";
            Txt_Formacion.Text = "";
            Txt_Nivel.Text = "";
            Txt_Caract.Text = "";
            Txt_Turno.Text = "";
            cmb_docente.SelectedIndex = -1;
        }

        private void btnAddAlumnoToGroup_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, tabPageListaGrupos, tabPageGrupoNuevoAlumno);
            CargarGrilla(dataGridView2);
            string Alumnos = "Select Apellido,Nombre,Cuit,Cud,Id From Alumnos";
            dataGridView4.AutoGenerateColumns = true;
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.DataSource = BD.CargarGrilla(Alumnos);
            dataGridView4.Columns["Id"].Visible = false;
            dataGridView4.Columns["Cud"].Visible = false;
        }
        private void btnAddAlumnoToList_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BringToFront();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, tabPageGrupoNuevoAlumno, tabPageListaGrupos);
            OcultarPanel();
        }

        private void BuscarGrupo_Load(object sender, EventArgs e)
        {
            CargarGrilla(dataGridView1);
            LlenarCombo();
        }

        private void LlenarCombo()
        {
            string nombyape = "Select Nombre+''+Apellido AS Fullname, Id From Docentes ";
            cmb_docente.ValueMember = "Id";
            cmb_docente.DisplayMember = "Fullname";
            cmb_docente.DataSource = BD.GetData(nombyape);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro que quieres eliminar este Grupo?", "Advertencia",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string consulta = "delete from Grupo where Id = (" + GetGrupoId(dataGridView1) + ");";
                para_BD.BD.CargarDB(consulta);
                MessageBox.Show("Docente eliminado correctamente!");
                CargarGrilla(dataGridView1);
            }
        }
        private int GetGrupoId(DataGridView Grilla)
        {
            return Convert.ToInt32(Grilla.Rows[Grilla.CurrentRow.Index].Cells["Id"].Value);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, tabPageListaGrupos, tabPageDetalleGrupo);
            CargarDatosGrupoParaEditar();
            isEditing = true;
        }
        private void CargarDatosGrupoParaEditar()
        {
            Txt_Nombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            Txt_Ciclo.Text = dataGridView1.CurrentRow.Cells["Ciclo"].Value.ToString();
            Txt_Formacion.Text = dataGridView1.CurrentRow.Cells["Formacion"].Value.ToString();
            Txt_Nivel.Text = dataGridView1.CurrentRow.Cells["Nivel"].Value.ToString();
            Txt_Caract.Text = dataGridView1.CurrentRow.Cells["Caracterizacion"].Value.ToString();
            Txt_Turno.Text = dataGridView1.CurrentRow.Cells["Turno"].Value.ToString();
            cmb_docente.SelectedValue = dataGridView1.CurrentRow.Cells["Id_Docente"].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetGrupoId(dataGridView1);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarGrillaGrupAlum();

        }

        private void txt_lNombreGrupo_TextChanged(object sender, EventArgs e)
        {
            if (txt_lNombreGrupo.Text != "")
            {
                string FiltroCuit = "Select * From Grupo where Nombre like'%" + txt_lNombreGrupo.Text + "%'";
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.DataSource = BD.CargarGrilla(FiltroCuit);
            }
            else
            {
                this.CargarGrilla(dataGridView1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro que quieres eliminar este Grupo?", "Advertencia",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string consulta = "delete from GrupoAlumno where Id = (" + GetGrupoId(dataGridView3) + ");";
                para_BD.BD.CargarDB(consulta);
                MessageBox.Show("Alumno eliminado del grupo correctamente!");
                CargarGrillaGrupAlum();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OcultarPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string InsertGrupAlum = "INSERT INTO GrupoAlumno(Id_Alumno, Id_Grupo) VALUES (' " + dataGridView4.CurrentRow.Cells["Id"].Value + " ' , ' " + dataGridView2.CurrentRow.Cells["Id"].Value + "') ; ";
            BD.CargarDB(InsertGrupAlum);
            MessageBox.Show("Alumno Agregado al Grupo exitosamente!");
            CargarGrillaGrupAlum();
            OcultarPanel();
           
        }
        private void OcultarPanel()
        {
            panel1.Visible = false;
            panel1.SendToBack();
        }

    }
}
