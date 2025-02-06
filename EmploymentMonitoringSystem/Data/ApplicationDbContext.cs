using EmploymentMonitoringSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmploymentMonitoringSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Graduate> Graduates { get; set; }
    }
}
