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
            Orden = new OleDbCommand(mi_consulta, ConexionConBD);
            lector = Orden.ExecuteReader();
            return lector;
        }

        public static void CargarDB(string consulta)
        {
            Orden = new OleDbCommand(consulta, ConexionConBD);
            Orden.ExecuteNonQuery();
        }

        public static void CargarDB(string consulta, Dictionary<string, string> parametros)
        {
            Orden = ConexionConBD.CreateCommand();
            Orden.CommandText = consulta;

            int valorNumerico;

            foreach (var param in parametros)
            {
                //bool isNumerical = int.TryParse(param.Value, out valorNumerico);
                //if (isNumerical)
                //{
                //    Orden.Parameters.Add(new OleDbParameter(param.Key, Int32.Parse(param.Value)));
                //}
                //else
                //{
                //    Orden.Parameters.Add(new OleDbParameter(param.Key, param.Value));
                //}
                Orden.Parameters.Add(new OleDbParameter(param.Key, param.Value));
            }

            Orden.ExecuteNonQuery();
        }

        public static DataTable CargarGrilla(string Consulta)
        {
            Orden = new OleDbCommand(Consulta, ConexionConBD);
            OleDbDataAdapter adapter = new OleDbDataAdapter(Orden);
            DataTable D = new DataTable();
            adapter.Fill(D);
            return D;
        }
       
    }
}
