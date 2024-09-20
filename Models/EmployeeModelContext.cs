using Microsoft.EntityFrameworkCore;

namespace USANotary.Models
{
    public class EmployeeModelContext : DbContext
    {
            public EmployeeModelContext(DbContextOptions<EmployeeModelContext> options) : base(options)
            {
            }
            public DbSet<JobData> JobData { get; set; } 
        public DbSet<Employee> Employees { get; set; }
      
    }
}
