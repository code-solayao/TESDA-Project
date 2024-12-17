using EmploymentMonitoringSystem.Data;
using EmploymentMonitoringSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmploymentMonitoringSystem.Controllers
{
    public class CreateEntryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CreateEntryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SubmitFullName(InitialRecord model)
        {
            CheckExistingName(model);

            return RedirectToAction("Index", "Records");
        }

        private void CheckExistingName(InitialRecord model)
        {
            // call stored procedure
            // alter table (another migration?)
            // change nullable/modify variables
            if (model.middle_name == null && model.extension_name == "None")
            {
                model.full_name = $"{model.last_name}, {model.first_name}";
            }
            else if (model.extension_name == "None")
            {
                model.full_name = $"{model.last_name}, {model.first_name} {model.middle_name}";
            }
            else if (model.middle_name == null)
            {
                model.full_name = $"{model.last_name} {model.extension_name}, {model.first_name}";
            }
            else
                model.full_name = $"{model.last_name} {model.extension_name}, {model.first_name} {model.middle_name}";
        }
    }
}
