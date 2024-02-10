using EnterpriseProject.Dtos.Employee.Request;
using EnterpriseProject.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace EnterpriseProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private Timer _timer;
        private readonly ILogger<EmployeeController> _logger;
        private IEmployeeService _employeeService;

        public EmployeeController(
            ILogger<EmployeeController> logger,
            IEmployeeService employeeService            )
        {
            _logger = logger;
            _employeeService = employeeService;
        }

        [HttpPost("add-employee")]
        public async Task<IActionResult> AdicionarFuncionario(EmployeeRequest request)
        {
            var response = _employeeService.AddEmployee(request);
            return Ok(response);
        }
        [HttpGet("get-all-employee")]
        public async Task<IActionResult> BuscarTodosOsFuncionarios()
        {
            var response = _employeeService.GetAllEmployees();
            return Ok(response);
        }
        [HttpPut("update-employee")]
        public async Task<IActionResult> AtualizarFuncionario(RequestUpdateEmployee request)
        {
            var response = _employeeService.UpdateEmployee(request);
            return Ok(response);
        }
        [HttpDelete("remove-employee")]
        public async Task<IActionResult> RemoverFuncionario(long? id)
        {
            var response = _employeeService.RemoveEmployee(id);
            return Ok(response);
        }
        [HttpGet("get-employee")]
        public async Task<IActionResult> BuscarFuncionario(long id)
        {
            var response = _employeeService.GetEmployee(id);
            return Ok(response);
        }
    }
}
