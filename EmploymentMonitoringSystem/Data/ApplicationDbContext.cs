using EmploymentMonitoringSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmploymentMonitoringSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<InitialRecord> Initial_Records { get; set; }
        public DbSet<VerificationRecord> Verification_Records { get; set; }
        public DbSet<EmploymentRecord> Employment_Records { get; set; }
        public DbSet<ExternalRecord> External_Records { get; set; }
    }
}
