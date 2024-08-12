using Microsoft.AspNetCore.Mvc;

namespace testweb2.Controllers
{
    public class TestPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
