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
    public partial class DocumentosHome : MaterialForm
    {
        public DocumentosHome()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPageAgregarDocumento);
            Skin.CargarSkin(this);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageListaDocumentos);
            tabControl1.TabPages.Add(tabPageAgregarDocumento);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPageAgregarDocumento);
            tabControl1.TabPages.Add(tabPageListaDocumentos);
        }
    }
}
