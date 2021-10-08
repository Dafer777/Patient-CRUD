using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConexionDB
{
    class Conexion
    {
        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection(@"Server=localhost;Database=SMIS006121;
                                    Uid = root; Pwd = usbw; SSL Mode = None");
            conexion.Open();
            return conexion;
        }
    }
}
