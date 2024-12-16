using EmploymentMonitoringSystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace EmploymentMonitoringSystem.Controllers
{
    public class RecordsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecordsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
