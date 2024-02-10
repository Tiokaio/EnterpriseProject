using EnterpriseProject.Entities;

namespace EnterpriseProject.Interfaces.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();

        Employee GetById(long id);

        Employee AddEmployee (Employee employee);
        Employee UpdateEmployee (Employee employee);
        Employee RemoveEmployee (long id);
    }
}
