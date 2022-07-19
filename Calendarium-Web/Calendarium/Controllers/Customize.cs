using Microsoft.AspNetCore.Mvc;

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
