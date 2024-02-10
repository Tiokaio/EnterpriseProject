namespace EnterpriseProject.Entities
{
    public class AccountsPayable 
    {
        public long Id { get; set; }
        public bool IsPaid { get; set; }
        public string Description { get; set; }
        public decimal AccountValue { get; set; }
        public DateTime DueDate { get; set; }
        public bool? Status { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime? UpdateAt { get; set; }
        public AccountsPayable()
        {
            Status = true;
        }
    }
}
