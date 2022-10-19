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
            tabControl1.TabPages.Remove(TabPag_Domi_Alum);
            tabControl1.TabPages.Add(TabPag_Detalle_Alum);

        }

    }
}
