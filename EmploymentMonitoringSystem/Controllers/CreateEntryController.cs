using EmploymentMonitoringSystem.Data;
using EmploymentMonitoringSystem.Data_Access_Layers;
using EmploymentMonitoringSystem.Models;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;

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

        public IActionResult CheckFullName(InitialRecord initialRecord)
        {
            // database migration muna
            DropProcedure();
            return RedirectToAction("Index", "Records");
        }

        private void DropProcedure()
        {
            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    string sql = "DROP PROCEDURE testprocedure;";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
