using Microsoft.AspNetCore.Mvc;
using Calendarium.Models;
using MySql.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;

namespace Calendarium.Controllers
{
    public class Insert : Controller
    {
        [HttpPost]
        public IActionResult InsertBD(String interfazBirthdayNAME, DateTime interfazBirthdayBIRTHDATE, int interfazBirthdayBIRTHYEAR)
        {
            String sql = "INSERT INTO dbbirthdays VALUES ('" + interfazBirthdayNAME + "', '" + interfazBirthdayBIRTHDATE + "', '" + interfazBirthdayBIRTHYEAR + "'";

            MySqlConnection conexionDB = Connection.Conexion();
            conexionDB.Open();
            try
            {
                MySqlCommand cmd = new(sql, conexionDB);
                cmd.ExecuteNonQuery();


            }
            catch (Exception exe)
            {
                Console.WriteLine("Ha ocurrido un error. Revise el formato de fecha ingresada!" + exe.Message);
            }
            finally
            {
                conexionDB.Close();
            }

            return RedirectToAction("Index", "Customize");
        }
    }
}
