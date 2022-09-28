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

namespace EjemploLibreriaForms.Views.Docentes
{
    public partial class BuscarDocente : MaterialForm
    {
        private DocenteModel DocenteToEdit;
        private List<DocenteModel> Docentes = new List<DocenteModel>();
        public bool isSuccessful { get; set; }
        public BuscarDocente()
        {
            InitializeComponent();
            Skin.CargarSkin(tabControl1, tabPageDetalleDocente, this);
            dataGridView1.DataSource = Docentes;
        }

        private void BuscarDocente_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageListaDocentes);
            tabControl1.TabPages.Add(tabPageDetalleDocente);
            tabPageDetalleDocente.Text = "Agregar Nuevo";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CargarDatosDocenteParaEditar(GetSelectedRowAsDocente());
            tabControl1.TabPages.Remove(tabPageListaDocentes);
            tabControl1.TabPages.Add(tabPageDetalleDocente);
            tabPageDetalleDocente.Text = "Editar Alumno";
        }

        private void CargarDatosDocenteParaEditar(DocenteModel DocenteToEdit)
        {
            txt_dNombre.Text = DocenteToEdit.Nombre;
            txt_dApellido.Text = DocenteToEdit.Apellido;
            txt_dDni.Text = DocenteToEdit.DNI;
            txt_dGrupo.Text = DocenteToEdit.Grupo;
            txt_dEmail.Text = DocenteToEdit.Email;

        }

        private DocenteModel GetSelectedRowAsDocente()
        {
            List<int> indexes = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();

            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                DocenteToEdit = row.DataBoundItem as DocenteModel;
                if (DocenteToEdit != null)
                {
                    return DocenteToEdit;
                }
            }
            return null;
        }

        private void BorrarDatosDocente()
        {
            txt_dNombre.Text = "";
            txt_dApellido.Text = "";
            txt_dDni.Text = "";
            txt_dEmail.Text = "";
            txt_dGrupo.Text = "";
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // obtiene el indice de la fila seleccionada en el GridView
            //int selectedRowCount =
            //    dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            var DocenteToDelete = GetSelectedRowAsDocente();

            var result = MessageBox.Show("¿Estás seguro que quieres eliminar este ALUMNO?", "Advertencia",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //dataGridView1.Rows.RemoveAt(selectedRowCount);
                Docentes = Docentes.Where(x => x.DNI != DocenteToDelete.DNI).ToList();
                dataGridView1.DataSource = Docentes;
                MessageBox.Show("Alumno eliminado correctamente!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var docenteTosave = new DocenteModel(txt_dNombre.Text,txt_dApellido.Text,txt_dDni.Text,txt_dTelefono.Text,txt_dGrupo.Text,txt_dEmail.Text);

            Docentes.Add(docenteTosave);

            isSuccessful = true;
            if (isSuccessful)
            {
                tabControl1.TabPages.Remove(tabPageDetalleDocente);
                tabControl1.TabPages.Add(tabPageListaDocentes);
            }
            MessageBox.Show("Alumno registrado exitosamente!");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageDetalleDocente);
            tabControl1.TabPages.Add(tabPageListaDocentes);
            BorrarDatosDocente();
        }

        private void txt_lNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
