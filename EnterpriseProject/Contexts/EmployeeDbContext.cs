using EnterpriseProject.Entities;
using EnterpriseProject.Infraestrutura.EntityMappers;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseProject.Contexts
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EmployeeConfiguration());
           
        }

    }
    

}
