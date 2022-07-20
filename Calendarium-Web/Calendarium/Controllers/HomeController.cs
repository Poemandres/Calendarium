using Calendarium.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Calendarium.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        var db = new UserContext();
        var usuarios = db.User.ToList();
        ViewBag.Usuarios = usuarios;
        <div>Usuarios ! </div>
        @for( int i = 0; i < ViewBag.Usuarios.Count; i++){
        <span>@ViewBag.Usuarios[i].userEMAIL -- @ViewBag.Personas[i].userNAME 
        </span>
}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}