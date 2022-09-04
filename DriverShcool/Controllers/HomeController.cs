using Microsoft.AspNetCore.Mvc;

namespace DriverShcool.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
