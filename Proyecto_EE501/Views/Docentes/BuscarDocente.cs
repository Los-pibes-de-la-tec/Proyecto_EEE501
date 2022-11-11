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
using EjemploLibreriaForms.para_BD;

namespace EjemploLibreriaForms.Docentes
{
    public partial class BuscarDocente : MaterialForm
    {
        public bool isEditing = false;
        public BuscarDocente()
        {
            InitializeComponent();
            Skin.CargarSkin(this);
            tabControl1.TabPages.Remove(tabPageDetalleDocente);
            this.CargarGrilla();
        }

        private void BuscarDocente_Load(object sender, EventArgs e)
        {
            this.CargarGrilla();
        }

        private void CargarGrilla()
        {
            string Docentes = "Select * From Docentes";
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = BD.CargarGrilla(Docentes);
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, tabPageListaDocentes, tabPageDetalleDocente);
            isEditing = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CargarDatosDocenteParaEditar();
            Metodos.CambiarTAb(tabControl1, tabPageListaDocentes, tabPageDetalleDocente);
            tabPageDetalleDocente.Text = "Editar Docente";
            isEditing = true;

        }

        private void CargarDatosDocenteParaEditar()
        {
            txt_dNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            txt_dApellido.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Apellido"].Value.ToString();
            txt_dCuit.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Cuit"].Value.ToString();
            txt_dEmail.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Email"].Value.ToString();
            txt_dTelefono.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Telefono"].Value.ToString();
        }


        private void BorrarDatosDocente()
        {
            txt_dNombre.Text = "";
            txt_dApellido.Text = "";
            txt_dCuit.Text = "";
            txt_dEmail.Text = "";
            txt_dTelefono.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro que quieres eliminar este DOCENTE?", "Advertencia",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string consulta = "delete from Docentes where Id = (" + GetDocenteId() + ");";
                para_BD.BD.CargarDB(consulta);
                MessageBox.Show("Docente eliminado correctamente!");
                CargarGrilla();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1,tabPageDetalleDocente,tabPageListaDocentes);
            BorrarDatosDocente();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txt_dNombre.Text != "" & txt_dApellido.Text != "" & txt_dCuit.Text != "" & txt_dEmail.Text != "" & txt_dTelefono.Text != "")
            {
                if (!isEditing)
                {
                    string AltaDoc = "INSERT INTO Docentes(Apellido, Nombre, Email, Cuit,Telefono) VALUES (' " +
                    txt_dApellido.Text + " ' , ' " + txt_dNombre.Text + " ' , ' " + txt_dEmail.Text + " ' , '" + txt_dCuit.Text + "','" + txt_dTelefono.Text + "') ; ";
                    para_BD.BD.CargarDB(AltaDoc);
                    MessageBox.Show("Docente registrado exitosamente!");
                    Metodos.CambiarTAb(tabControl1, tabPageDetalleDocente, tabPageListaDocentes);
                    CargarGrilla();
                    BorrarDatosDocente();
                }
                else
                {
                    string AltaAlum = "UPDATE [Docentes] SET Apellido=?, Nombre=?, Email=?, Cuit=?,Telefono=? WHERE Id=?";
                    var parametros = new Dictionary<string, string>();
                    parametros.Add("@Apellido", txt_dApellido.Text);
                    parametros.Add("@Nombre", txt_dNombre.Text);
                    parametros.Add("@Email", txt_dEmail.Text);
                    parametros.Add("@Cuit", txt_dCuit.Text);
                    parametros.Add("@Telefono", txt_dTelefono.Text);
                    parametros.Add("@Id", GetDocenteId().ToString());
                    para_BD.BD.CargarDB(AltaAlum, parametros);
                    CargarGrilla();
                    MessageBox.Show("Datos editados exitosamente!");
                    Metodos.CambiarTAb(tabControl1, tabPageDetalleDocente, tabPageListaDocentes);
                    BorrarDatosDocente();
                }
            }
          

        }

        private int GetDocenteId()
        {
            return Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Id"].Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDocenteId();
        }

        private void txt_IDNI_TextChanged(object sender, EventArgs e)
        {
            if (txt_IDNI.Text != "")
            {
                string FiltroCuit = "Select * From Docentes where Cuit like'%" + txt_IDNI.Text + "%'";
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.DataSource = BD.CargarGrilla(FiltroCuit);
            }
            else
            {
                this.CargarGrilla();
            }
        }

        private void txt_dCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten Numeros");
                e.Handled = true;

            }
        }

    }
}
