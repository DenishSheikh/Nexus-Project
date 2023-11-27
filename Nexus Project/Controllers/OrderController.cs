using Microsoft.AspNetCore.Mvc;

namespace Nexus_Project.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
