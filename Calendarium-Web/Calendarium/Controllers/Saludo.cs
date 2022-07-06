using Microsoft.AspNetCore.Mvc;

namespace Calendarium.Controllers
{
    public class Saludo : Controller
    {
        public IActionResult Index(String name)
        {
            ViewBag.Saludo = "Buona salutatem, "+name+"!";
            return View();

        }
        public IActionResult Mensaje(int interaccion)
        {
            ViewBag.Nombre = "Viva Cristo Rey";
            return View();
        }
    }
}
