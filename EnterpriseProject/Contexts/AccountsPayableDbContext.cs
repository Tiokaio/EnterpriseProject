using EnterpriseProject.Entities;
using EnterpriseProject.Infraestrutura.EntityMappers;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseProject.Contexts
{

    public class AccountsPayableDbContext : DbContext
    {
        public DbSet<AccountsPayable> AccountsPayables { get; set; }
        public AccountsPayableDbContext(DbContextOptions<AccountsPayableDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AccountsPayableConfiguration());
            
        }
    }
    
}
