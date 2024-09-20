using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USANotary.Models
{
    public class Dbhandler
    {
        private readonly EmployeeModelContext _context;
        public Dbhandler(EmployeeModelContext context)
        {
            _context = context;
        }
        public async Task<List<Employee>> GetAllPeopleAsync()
        {
            return await _context.Employees.ToListAsync();
        }
        public async Task<List<JobData>> GetAllJobsAsync()
        {
            return await _context.JobData.ToListAsync();
        }
    }
}
