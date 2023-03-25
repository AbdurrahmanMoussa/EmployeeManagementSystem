using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Repository
{
    public class EmployeeRepository
    {
        private readonly DataContext _context;
        public EmployeeRepository(DataContext context)
        {
            _context = context;   
        }

        public ICollection<Employee> GetEmployees()
        {
            return _context.Employee.OrderBy(e => e.EmployeeId).ToList();
        }
        
    }
}
