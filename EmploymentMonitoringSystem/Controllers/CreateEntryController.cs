using EmploymentMonitoringSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmploymentMonitoringSystem.Controllers
{
    public class CreateEntryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CheckFullName(InitialRecord initialRecord)
        {
            return RedirectToAction("Index", "Records");
        }
    }
}
