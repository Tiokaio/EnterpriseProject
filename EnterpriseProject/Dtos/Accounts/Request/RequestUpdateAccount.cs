namespace EnterpriseProject.Dtos.Accounts.Request
{
    public class RequestUpdateAccount
    {
        public long Id { get; set; }
        public bool IsPaid { get; set; }
        public string Description { get; set; }
        public decimal AccountValue { get; set; }
        public DateTime DueDate { get; set; }
    }
}
