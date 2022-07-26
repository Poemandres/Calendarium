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
            return View();
        }
    }
}
