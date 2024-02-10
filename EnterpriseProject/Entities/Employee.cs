using Microsoft.Identity.Client;

namespace EnterpriseProject.Entities
{
    public class Employee 
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Office { get; set; }
        public string Cpf {  get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public DateTime? UpdateAt { get; set;}
        public decimal Wage { get; set; }
        public bool? Status { get; set; }
        public Employee() 
        {
            Status = true;
        }
    }
}
