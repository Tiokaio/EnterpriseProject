using EnterpriseProject.Contexts;
using EnterpriseProject.Entities;
using EnterpriseProject.Interfaces.Repository;

namespace EnterpriseProject.Infraestrutura.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _employeeDbcontext;
        public EmployeeRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbcontext = employeeDbContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            _employeeDbcontext.Employee.Add(employee);
            _employeeDbcontext.SaveChanges();
            return employee;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeDbcontext.Employee.ToList();
        }

        public Employee GetById(long id)
        {
            return _employeeDbcontext.Employee.Find(id);
        }

        public Employee RemoveEmployee(long id)
        {
            var employee = _employeeDbcontext.Employee.Find(id);
            if (employee != null)
            {
                _employeeDbcontext.Employee.Remove(employee);
                _employeeDbcontext.SaveChanges();
            }
            return employee;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            _employeeDbcontext.Employee.Update(employee);
            _employeeDbcontext.SaveChanges();
            return employee;
        }
    }
}
