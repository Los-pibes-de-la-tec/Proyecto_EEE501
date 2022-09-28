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
namespace EjemploLibreriaForms
{
    class Skin
    {
        public static void CargarSkin(TabControl Tabcontrol, TabPage Page, MaterialForm XD)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(XD);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            Tabcontrol.TabPages.Remove(Page);
        }
    }
}
