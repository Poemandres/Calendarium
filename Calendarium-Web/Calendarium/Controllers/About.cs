using Microsoft.AspNetCore.Mvc;
using Calendarium.Models;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Calendarium.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            var db = new UserContext();
            var users = db.User.ToList();
            ViewBag.Users = users;

            return View();
        }


    }

}
