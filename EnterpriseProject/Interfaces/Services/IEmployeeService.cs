using EnterpriseProject.Dtos.Employee.Request;
using EnterpriseProject.Entities;

namespace EnterpriseProject.Interfaces.Services
{
    public interface IEmployeeService
    {
        Employee AddEmployee(EmployeeRequest employee);    
        Employee UpdateEmployee (RequestUpdateEmployee employee);
        Employee RemoveEmployee(long? Id);
        Employee GetEmployee(long employeeId);
        List<Employee> GetAllEmployees();   
    }
}
