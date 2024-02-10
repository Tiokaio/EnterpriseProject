using EnterpriseProject.Dtos.Employee.Request;
using EnterpriseProject.Entities;
using EnterpriseProject.Interfaces.Repository;
using EnterpriseProject.Interfaces.Services;

namespace EnterpriseProject.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeService(
            IEmployeeRepository employeeRepository
            )
        { _employeeRepository = employeeRepository;  }
        public  Employee AddEmployee(EmployeeRequest employee)
        {
            
            var newEmployee = new Employee();
            newEmployee.Cpf = employee.Cpf;
            newEmployee.Office = employee.Office;
            newEmployee.FirstName = employee.FirstName;
            newEmployee.LastName = employee.LastName;   
            newEmployee.Wage = employee.Wage;
            var add = _employeeRepository.AddEmployee( newEmployee );
            return add;

        }

        public List<Employee> GetAllEmployees()
        {
            var response = _employeeRepository.GetAll();
            return response.ToList();
        }

        public Employee GetEmployee(long employeeId)
        {
            var response = _employeeRepository.GetById(employeeId);
            return response;
        }

        public Employee RemoveEmployee(long? Id)
        {
            var response = _employeeRepository.RemoveEmployee((int)Id);
            return response;
        }

        public Employee UpdateEmployee(RequestUpdateEmployee employee)
        {
            var updated = _employeeRepository.GetById(employee.Id);
            if (updated == null) throw new ApplicationException("Funcionario não encontrado");
            updated.Cpf = employee.Cpf;
            updated.Office = employee.Office;
            updated.FirstName = employee.FirstName;
            updated.LastName = employee.LastName;
            updated.Wage = employee.Wage;
            updated.UpdateAt = DateTime.Now;
            var commit = _employeeRepository.UpdateEmployee(updated);
            return commit;
        }
    }
}
