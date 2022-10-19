﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace EjemploLibreriaForms.para_BD
{
    class BD
    {
        public static OleDbConnection ConexionConBD;
        public static string strConexión = "Provider=Microsoft.Jet.OLEDB.4.0;" +
        "Data SOURCE= Proyecto 501.mdb";
        public static OleDbCommand Orden;
        public static OleDbDataReader lector;

        public static void AbrirDB()
        {
            ConexionConBD = new OleDbConnection(strConexión);
            ConexionConBD.Open();
        }

        public static OleDbDataReader LecturaDB(string mi_consulta)
        {
            Orden = new OleDbCommand(mi_consulta, ConexionConBD);
            lector = Orden.ExecuteReader();
            return lector;
        }

        public static void CerrarDB()
        {
            ConexionConBD.Close();
        }

        public static void CargarDB(string consulta)
        {
            Orden = new OleDbCommand(consulta, ConexionConBD);
            Orden.ExecuteNonQuery();
        }
    }
}
