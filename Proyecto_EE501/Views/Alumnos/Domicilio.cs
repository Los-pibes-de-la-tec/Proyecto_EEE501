﻿using System;
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
        }

    }
}