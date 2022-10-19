using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Proyecto501
{
    class ConectaDB
    {
        public static void AbrirDB()
        {
            DB.ConexionConBD = new OleDbConnection(DB.strConexión);
            DB.ConexionConBD.Open();
        }

        public static OleDbDataReader LecturaDB(string mi_consulta)
        {
            DB.Orden = new OleDbCommand(mi_consulta, DB.ConexionConBD);
            DB.lector = DB.Orden.ExecuteReader();
            return DB.lector;
        }
      
        public static void CerrarDB()
        {
            DB.ConexionConBD.Close();
        }

        public static void CargarDB(string consulta)
        {
            DB.Orden = new OleDbCommand(consulta, DB.ConexionConBD);
            DB.Orden.ExecuteNonQuery();
        }
    }
}
