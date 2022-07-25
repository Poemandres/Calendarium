using Microsoft.AspNetCore.Mvc;

namespace Calendarium.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }

}
