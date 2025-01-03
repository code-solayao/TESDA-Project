using EmploymentMonitoringSystem.Data;
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

        [HttpPost]
        public IActionResult Index(InitialRecord model)
        {
            /* band-aid solution to display exception message: 
             * use last_name as key
             * use asp-validation-summary="All" only */

            if (model != null)
            {
                CheckExistingName(model);
            }
            else ModelState.AddModelError("last_name", "Cannot process data to proceed.");
            
            if (ModelState.IsValid) 
                return RedirectToAction("InitialData", model);
            else return View(model);
        }

        public IActionResult InitialData(InitialRecord model)
        {
            return View(model);
        }

        private void CheckExistingName(InitialRecord model)
        {
            string last_name = model.last_name;
            string first_name = model.first_name;
            string middle_name = model.middle_name ?? string.Empty;
            string extension_name = model.extension_name ?? string.Empty;

            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    string full_name = FullNameFormat();

                    string sql = "CALL check_fullname(@name);";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@name", full_name);
                    command.ExecuteNonQuery();

                    int result = 0;
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result++;
                        }
                    }

                    if (result > 0)
                        ModelState.AddModelError("last_name", "This name already exists. Please enter another name.");
                    else model.full_name = full_name;

                    connection.Close();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("last_name", ex.Message);
                }
            }

            string FullNameFormat()
            {
                string full_name;

                if (middle_name.Equals(string.Empty) && extension_name.Equals(string.Empty))
                {
                    full_name = $"{last_name}, {first_name}";
                }
                else if (extension_name.Equals(string.Empty))
                {
                    full_name = $"{last_name}, {first_name} {middle_name}";
                }
                else if (middle_name.Equals(string.Empty))
                {
                    full_name = $"{last_name} {extension_name}, {first_name}";
                }
                else
                    full_name = $"{last_name} {extension_name}, {first_name} {middle_name}";

                return full_name;
            }
        }
    }
}
