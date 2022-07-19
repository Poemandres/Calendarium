using Microsoft.AspNetCore.Mvc;

namespace Calendarium.Controllers
{
    public class Configure : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
