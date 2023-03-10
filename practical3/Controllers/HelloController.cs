using Microsoft.AspNetCore.Mvc;

namespace practical3.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
