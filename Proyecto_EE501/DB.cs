using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Proyecto501
{
    class DB
    {
        public static OleDbConnection ConexionConBD;
        public static string strConexión = "Provider=Microsoft.Jet.OLEDB.4.0;" +
        "Data SOURCE= Esc501.mdb";
        //Para que todos lo puedan abris (y no tener que cambiar la ruta por cada pc) 
        //hay que crear una carpeta en C:\501\501.mdb
        //osea, la ruta y la base deberian ser la misma para todos (sin espacios ni simbolos raros)
        public static OleDbCommand Orden;
        public static OleDbDataReader lector;
    }
}
