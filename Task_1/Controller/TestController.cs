using Microsoft.AspNetCore.Mvc;

namespace Task_1
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
