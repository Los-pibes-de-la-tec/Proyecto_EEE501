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

namespace EjemploLibreriaForms.Domicilio
{
    public partial class Domicilio : MaterialForm
    {
        public Domicilio()
        {
            InitializeComponent();
            Skin.CargarSkin(this);
            tabControl1.TabPages.Remove(TabPag_Detalle_Alum);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1,TabPag_Domi_Alum,TabPag_Detalle_Alum);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, TabPag_Domi_Alum, TabPag_Detalle_Alum);
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            Metodos.CambiarTAb(tabControl1, TabPag_Detalle_Alum, TabPag_Domi_Alum);
        }

    }
}
