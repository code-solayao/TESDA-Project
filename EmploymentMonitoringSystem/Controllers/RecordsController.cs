using EmploymentMonitoringSystem.Data;
using EmploymentMonitoringSystem.Models;
using Microsoft.AspNetCore.Mvc;
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
            Utilities.DataRecordTable table = new Utilities.DataRecordTable()
            {
                InitialRecords = _context.Initial_Records.ToList(),
                EmploymentRecords = _context.Employment_Records.ToList()
            };

            return View(table);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(InitialRecord model)
        {
            // maybe merge all 3 records
            if (model == null)
            {
                return BadRequest("ERROR 400 BAD REQUEST: Request body could not be read properly.");
            }
            else
            {
                CheckExistingName(model);

                if (!ModelState.IsValid)
                    return View(model);

                _context.Initial_Records.Add(model);
                _context.SaveChanges();

                _context.Verification_Records.Add(new VerificationRecord { Id = model.Id });
                _context.Employment_Records.Add(new EmploymentRecord { Id = model.Id });
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id == null || Id == 0) return NotFound();

            InitialRecord? initial = _context.Initial_Records.Find(Id);
            VerificationRecord? verification = _context.Verification_Records.Find(Id);
            EmploymentRecord? employment = _context.Employment_Records.Find(Id);

            Utilities.Records records = new Utilities.Records()
            {
                Initial = initial,
                Verification = verification,
                Employment = employment,
            };

            if (records.Initial == null || records.Verification == null || records.Employment == null)
            {
                return BadRequest();
            }
            else
            {
                return View(records);
            }
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null || Id == 0) return NotFound();

            InitialRecord? initial = _context.Initial_Records.Find(Id);
            VerificationRecord? verification = _context.Verification_Records.Find(Id);
            EmploymentRecord? employment = _context.Employment_Records.Find(Id);

            if (initial == null || verification == null || employment == null)
            {
                return BadRequest("ERROR 400 BAD REQUEST: Request body could not be read properly.");
            }
            else
            {
                if (verification.invalid_contact == "Yes")
                    verification.invalid_contact = "true";
                else
                    verification.invalid_contact = "false";

                Utilities.Records models = new Utilities.Records()
                {
                    Initial = initial,
                    Verification = verification,
                    Employment = employment,
                };

                return View(models);
            }
        }

        [HttpPost]
        public IActionResult Edit(Utilities.Records models)
        {
            if (models == null)
            {
                return BadRequest("ERROR 400 BAD REQUEST: Request body could not be read properly.");
            }
            else
            {
                if (!ModelState.IsValid)
                    return View(models);

                if (models.Verification == null)
                    return BadRequest("ERROR 400 BAD REQUEST: Request body could not be read properly.");
                else
                {
                    if (models.Employment == null)
                    {
                        models.Employment = new EmploymentRecord()
                        {
                            Id = models.Verification.Id
                        };
                    }

                    if (models.Verification.invalid_contact == "true")
                        models.Verification.invalid_contact = "Yes";
                    else
                        models.Verification.invalid_contact = "No";

                    _context.Verification_Records.Update(models.Verification);
                    _context.Employment_Records.Update(models.Employment);
                    _context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int Id)
        {
            InitialRecord? initial = await _context.Initial_Records.FindAsync(Id);
            VerificationRecord? verification = await _context.Verification_Records.FindAsync(Id);
            EmploymentRecord? employment = await _context.Employment_Records.FindAsync(Id);

            if (initial == null || verification == null || employment == null)
                return BadRequest("ERROR 400 BAD REQUEST: Request body could not be read properly.");
            else
            {
                _context.Initial_Records.Remove(initial);
                _context.Verification_Records.Remove(verification);
                _context.Employment_Records.Remove(employment);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAll()
        {
            // ClearAllRecords();
            List<InitialRecord> initial = _context.Initial_Records.ToList();
            List<VerificationRecord> verification = _context.Verification_Records.ToList();
            List<EmploymentRecord> employment = _context.Employment_Records.ToList();

            if (initial == null || verification == null || employment == null)
                return BadRequest("ERROR 400 BAD REQUEST: Request body could not be read properly.");
            else
            {
                _context.Initial_Records.RemoveRange(initial);
                _context.Verification_Records.RemoveRange(verification);
                _context.Employment_Records.RemoveRange(employment);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

        #region Functions

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
