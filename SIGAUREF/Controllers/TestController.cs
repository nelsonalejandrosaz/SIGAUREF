using Microsoft.AspNetCore.Mvc;

namespace SIGAUREF.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
