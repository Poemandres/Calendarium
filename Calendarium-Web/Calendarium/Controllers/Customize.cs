using Microsoft.AspNetCore.Mvc;
using Calendarium.Models;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Calendarium.Controllers
{
    public class Customize : Controller
    {
        public IActionResult Index()
        {
            var db = new BirthdayContext();
            var birthdays = db.dbbirthdays.ToList();
            ViewBag.Birthdays = birthdays;

            return View();
        }
    }
}
