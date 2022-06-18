using Microsoft.AspNetCore.Mvc;

namespace Calendarium.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
