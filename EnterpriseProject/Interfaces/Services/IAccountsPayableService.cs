using EnterpriseProject.Dtos.Accounts.Request;
using EnterpriseProject.Entities;

namespace EnterpriseProject.Interfaces.Services
{
    public interface IAccountsPayableService
    {
        AccountsPayable AddAccount(RequestAddAccount account);
        AccountsPayable UpdateAccount(RequestUpdateAccount account);
        AccountsPayable RemoveAccount(long? Id);
        AccountsPayable GetAccount(long AccountId);
        List<AccountsPayable> GetAllAccounts();
    }
}
