using EmploymentMonitoringSystem.Data;
using EmploymentMonitoringSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;

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
            List<Graduate> model = _context.Graduates.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Graduate model)
        {
            if (model == null)
            {
                return NotFound();
            }
            else
            {
                CheckExistingName(model);

                if (!ModelState.IsValid)
                    return View(model);

                _context.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id == null || Id == 0) return NotFound();

            Graduate? model = _context.Graduates.Find(Id);

            if (model == null)
                return NotFound();
            else
                return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null || Id == 0) return NotFound();

            Graduate? model = _context.Graduates.Find(Id);

            if (model == null)
            {
                return NotFound();
            }
            else
            {
                if (model.invalid_contact == "Yes")
                    model.invalid_contact = "true";
                else
                    model.invalid_contact = "false";

                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Graduate model)
        {
            if (model == null)
            {
                return NotFound();
            }
            else
            {
                if (!ModelState.IsValid)
                    return View(model);

                if (model == null)
                    return NotFound();
                else
                {

                    if (model.invalid_contact == "true")
                        model.invalid_contact = "Yes";
                    else
                        model.invalid_contact = "No";

                    _context.Graduates.Update(model);
                    _context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int Id)
        {
            Graduate? model = await _context.Graduates.FindAsync(Id);

            if (model == null)
                return NotFound();
            else
            {
                _context.Remove(model);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAll()
        {
            // ClearAllRecords();
            List<Graduate> model = await _context.Graduates.ToListAsync();

            if (model == null)
                return NotFound();
            else
            {
                _context.RemoveRange(model);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

        #region Functions

        private void CheckExistingName(Graduate model)
        {
            string last_name = model.last_name ?? string.Empty;
            string first_name = model.first_name ?? string.Empty;
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

                    int result = 0;
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result++;
                        }
                    }

                    if (result > 0)
                        ModelState.AddModelError("Full Name", "This name already exists. Please enter another name.");
                    else model.full_name = full_name;

                    connection.Close();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("MySQL Exception 1", $"Error: {ex.Message}");
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

        private void ClearAllRecords()
        {
            using (MySqlConnection connection = new MySqlConnection(Utilities.MySqlConnectionString))
            {
                try
                {
                    connection.Open();

                    string sql = $"CALL clear_all_records();";
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

        #endregion
    }
}
