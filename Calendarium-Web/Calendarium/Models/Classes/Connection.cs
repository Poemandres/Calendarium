using System;
using MySql.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace Calendarium.Models
{
    public class Connection
    {
        public static MySqlConnection Conexion()
        {
            String bd = "calendarium";
            String servidor = "localhost";
            String puerto = "3306";
            String usuario = "root";
            String password = "";

            String cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; port=" + puerto + "; User Id=" + usuario + "; Password=" + password;

            try
            {
                MySqlConnection conexionBD = new(cadenaConexion);
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error:" + ex.Message);
                return null;
            }

        }

    }
}