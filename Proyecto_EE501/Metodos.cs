using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemploLibreriaForms
{
    class Metodos
    {
        public static void CambiarTAb(TabControl TabC,TabPage Actual,TabPage Destino)
        {
            TabC.TabPages.Remove(Actual);
            TabC.TabPages.Add(Destino);
        }
    }
}
