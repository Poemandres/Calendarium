using Microsoft.AspNetCore.Mvc;

namespace Calendarium.Controllers
{
    public class MyCalendars : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
