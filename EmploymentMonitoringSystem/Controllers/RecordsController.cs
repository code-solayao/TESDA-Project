using Microsoft.AspNetCore.Mvc;

namespace EmploymentMonitoringSystem.Controllers
{
    public class RecordsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
