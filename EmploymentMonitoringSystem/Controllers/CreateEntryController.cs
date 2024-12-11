using EmploymentMonitoringSystem.Data_Access_Layers;
using EmploymentMonitoringSystem.Models;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;

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
