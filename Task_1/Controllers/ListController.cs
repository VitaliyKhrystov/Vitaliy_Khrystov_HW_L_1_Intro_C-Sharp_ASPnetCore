using Microsoft.AspNetCore.Mvc;

namespace Task_1
{
    public class ListController : Controller
    {
        public IActionResult Info()
        {
            return View();
        }
    }
}
