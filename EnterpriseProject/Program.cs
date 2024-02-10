using EnterpriseProject.Contexts;
using EnterpriseProject.Infraestrutura.Repository;
using EnterpriseProject.Interfaces.Repository;
using EnterpriseProject.Interfaces.Services;
using EnterpriseProject.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var EmployeeDbContextConnectionString = builder.Configuration.GetConnectionString("EmployeeConnection");
var AccountsPayableDbContextConnectionString = builder.Configuration.GetConnectionString("AccountToPaidConnection");
builder.Services.AddDbContext<EmployeeDbContext>(options => options.UseSqlServer(EmployeeDbContextConnectionString));
builder.Services.AddDbContext<AccountsPayableDbContext>(options => options.UseSqlServer(AccountsPayableDbContextConnectionString));

//Come�o das dep�ndencias de Repositorios
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IAccountsPayableRepository, AccountsPayableRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IEmployeeService, EmployeeService>();
builder.Services.AddTransient<IAccountsPayableService, AccountsService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
