using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    public class EnvController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}