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
            /* band-aid solution to display exception message: 
             * use last_name as key
             * use asp-validation-summary="All" only */

            if (model == null) 
                return BadRequest();
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
                return BadRequest();
            else 
                return View(records);
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null || Id == 0) return NotFound();

            InitialRecord? initial = _context.Initial_Records.Find(Id);
            VerificationRecord? verification = _context.Verification_Records.Find(Id);
            EmploymentRecord? employment = _context.Employment_Records.Find(Id);

            Utilities.Records details = new Utilities.Records()
            {
                Initial = initial,
                Verification = verification,
                Employment = employment,
            };
            if (details.Initial == null || details.Verification == null || details.Employment == null) 
                return BadRequest();
            else 
                return View(details);
        }

        [HttpPost]
        public IActionResult Edit(Utilities.Records model)
        {
            // Kailangan ma-POST ang 2 model, hindi pwede ang Utilities.Records
            if (model == null)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (!ModelState.IsValid)
                    return View(model);

                if (model.Verification == null)
                    return BadRequest(model);
                else
                {
                    _context.Verification_Records.Update(model.Verification);
                    _context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
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
                        ModelState.AddModelError("last_name", "This name already exists. Please enter another name.");
                    else model.full_name = full_name;

                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
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

        #endregion
    }
}
