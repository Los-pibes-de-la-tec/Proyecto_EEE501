using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace EjemploLibreriaForms.para_BD
{
    class BD
    {
        public static OleDbConnection ConexionConBD;

        static string DBPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Proyecto_501.mdb");
        public static string strConexión = "Provider=Microsoft.Jet.OLEDB.4.0;" +
        "Data SOURCE=" + DBPath + ";";
        public static OleDbCommand Orden;
        public static OleDbDataReader lector;

        public static void AbrirDB()
        {
            ConexionConBD = new OleDbConnection(strConexión);
            ConexionConBD.Open();
        }

        public static void CerrarDB()
        {
            ConexionConBD.Close();
        }

        public static OleDbDataReader LecturaDB(string mi_consulta)
        {
            AbrirDB();
            Orden = new OleDbCommand(mi_consulta, ConexionConBD);
            lector = Orden.ExecuteReader();
            return lector;
        }

        public static void CargarDB(string consulta)
        {
            AbrirDB();
            Orden = new OleDbCommand(consulta, ConexionConBD);
            Orden.ExecuteNonQuery();
            CerrarDB();
        }

        public static void CargarDB(string consulta, Dictionary<string, string> parametros)
        {
            AbrirDB();
            Orden = ConexionConBD.CreateCommand();
            Orden.CommandText = consulta;
            foreach (var param in parametros)
            {
                Orden.Parameters.Add(new OleDbParameter(param.Key, param.Value));
            }

            Orden.ExecuteNonQuery();
            CerrarDB();
        }

        public static DataTable CargarGrilla(string Consulta)
        {
            AbrirDB();
            Orden = new OleDbCommand(Consulta, ConexionConBD);
            OleDbDataAdapter adapter = new OleDbDataAdapter(Orden);
            DataTable D = new DataTable();
            adapter.Fill(D);
            CerrarDB();
            return D;
        }

        public static DataTable GetData(string Consulta)
        {
            AbrirDB();
            OleDbDataAdapter da = new OleDbDataAdapter(Consulta, ConexionConBD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }


    }
}
