using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConexionDB
{
    class Function
    {
        public static int agregar(Patient add)
        {
            //Realizamos la consulta a la base de datos para ingresar los registros
            int retorno = 0;
            MySqlCommand commando = new MySqlCommand(String.Format("insert into municipio(nombre, poblacion, latitud, longitud)values('{0}','{1}','{2}','{3}')", add.nombre, add.poblacion, add.latitud, add.longitud), Conexion.obtenerConexion());
            retorno = commando.ExecuteNonQuery();
            return retorno;


        }
        public static List<Patient> mostrar()
        {
            List<Patient> Lista = new List<Patient>();
            MySqlCommand comando = new MySqlCommand(string.Format("select * from paciente"),Conexion.obtenerConexion()); 
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Patient mun = new Patient();
                mun.names = reader.GetString(30);
                mun.Years = reader.GetString(2);
                mun.NumberPhone = reader.GetString(8);
                mun.sickNess = reader.GetString(30);
            }
            return Lista;      
        }

    }
}
