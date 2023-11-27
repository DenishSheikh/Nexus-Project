using Microsoft.AspNetCore.Mvc;

namespace Nexus_Project.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
