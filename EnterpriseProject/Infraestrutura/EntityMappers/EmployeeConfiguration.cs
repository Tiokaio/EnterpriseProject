using EnterpriseProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EnterpriseProject.Infraestrutura.EntityMappers
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("employee");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.FirstName).HasColumnName("first_name");
            builder.Property(x => x.LastName).HasColumnName("last_name");
            builder.Property(x => x.Office).HasColumnName("office");
            builder.Property(x => x.Cpf).HasColumnName("cpf");
            builder.Property(x => x.RegistrationDate).HasColumnName("registration_date");
            builder.Property(x => x.Wage).HasColumnName("wage");
        }
    }
}
