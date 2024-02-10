using EnterpriseProject.Dtos.Accounts.Request;
using EnterpriseProject.Dtos.Employee.Request;
using EnterpriseProject.Interfaces.Services;
using EnterpriseProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace EnterpriseProject.Controllers
{
    public class AccountsPayableController : ControllerBase
    {
        private IAccountsPayableService _accountsService;
        public AccountsPayableController(IAccountsPayableService accountsService)
        {
            _accountsService = accountsService;
        }
        [HttpPost("add-account")]
        public async Task<IActionResult> AdicionarConta(RequestAddAccount request)
        {
            var response = _accountsService.AddAccount(request);
            return Ok(response);
        }
        [HttpGet("get-all-account")]
        public async Task<IActionResult> BuscarTodasAsContas()
        {
            var response = _accountsService.GetAllAccounts();
            return Ok(response);
        }
        [HttpPut("update-account")]
        public async Task<IActionResult> AtualizarConta(RequestUpdateAccount request)
        {
            var response = _accountsService.UpdateAccount(request);
            return Ok(response);
        }
        [HttpDelete("remove-account")]
        public async Task<IActionResult> RemoverConta(long? id)
        {
            var response = _accountsService.RemoveAccount(id);
            return Ok(response);
        }
        [HttpGet("get-account")]
        public async Task<IActionResult> BuscarConta(long id)
        {
            var response = _accountsService.GetAccount(id);
            return Ok(response);
        }
    }
}
