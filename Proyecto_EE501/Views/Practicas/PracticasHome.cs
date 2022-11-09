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

namespace EjemploLibreriaForms
{
    public partial class PracticasHome : MaterialForm
    {
        public PracticasHome()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPageDetallePractica);
            Skin.CargarSkin(this);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, tabPageListaPracticas, tabPageDetallePractica);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, tabPageListaPracticas, tabPageDetallePractica);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, tabPageDetallePractica, tabPageListaPracticas);
        }
    }
}
