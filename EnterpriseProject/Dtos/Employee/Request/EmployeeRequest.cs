namespace EnterpriseProject.Dtos.Employee.Request
{
    public class EmployeeRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Cpf { get; set; }
        public string Office { get; set; }
        public decimal Wage { get; set; }
    }
}
