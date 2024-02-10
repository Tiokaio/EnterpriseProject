using EnterpriseProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EnterpriseProject.Infraestrutura.EntityMappers
{
    internal class AccountsPayableConfiguration : IEntityTypeConfiguration<AccountsPayable>
    {
        public void Configure(EntityTypeBuilder<AccountsPayable> builder) 
        {
            builder.ToTable("accounts_payable");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Description).HasColumnName("description");
            builder.Property(x => x.AccountValue).HasColumnName("account_value").HasColumnType("decimal(28,2)");
            builder.Property(x => x.DueDate).HasColumnName("due_date");
            builder.Property(x => x.IsPaid).HasColumnName("ispaid");
        }
    }
}
