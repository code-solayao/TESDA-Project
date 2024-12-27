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

        public IActionResult Index(InitialRecord model)
        {
            return View(model);
        }

        public IActionResult SubmitFullName(InitialRecord model)
        {
            /* how to: 
             * call a stored procedure 
             * exception handling 
             * display error message */

            if (true)
            {
                ModelState.AddModelError("last_name", "error found");
            }
            
            if (ModelState.IsValid)
            {
                return RedirectToAction("InitialData", model);
            }
            else return RedirectToAction("Index", model);
        }

        public IActionResult InitialData(InitialRecord model)
        {
            return View(model);
        }

        private bool CheckExistingName(InitialRecord model)
        {
            bool nameExists = false;

            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    string sql = "CALL check_fullname(@last, @first, @middle, @extn)";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@last", model.last_name);
                    command.Parameters.AddWithValue("@first", model.first_name);
                    command.Parameters.AddWithValue("@middle", model.middle_name);
                    command.Parameters.AddWithValue("@extn", model.extension_name);
                    command.ExecuteNonQuery();

                    string last_name = string.Empty;
                    string first_name = string.Empty;
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            last_name += $"{reader.GetString(0)}";
                            first_name += $"{reader.GetString(1)}";
                        }
                    }

                    if (last_name.Equals(string.Empty) && first_name.Equals(string.Empty))
                    {
                        nameExists = true;
                    }
                    else
                    {
                        nameExists = false;
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    nameExists = true;
                }

            }

            return nameExists;
        }

        private void FullNameFormat(InitialRecord model)
        {
            if (model.middle_name == null && model.extension_name == null)
            {
                model.full_name = $"{model.last_name}, {model.first_name}";
            }
            else if (model.extension_name == null)
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
