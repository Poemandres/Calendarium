using Microsoft.AspNetCore.Mvc;

namespace Calendarium.Controllers
{
    public class Community : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
