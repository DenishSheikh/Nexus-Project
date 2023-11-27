using Microsoft.AspNetCore.Mvc;

namespace Nexus_Project.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
