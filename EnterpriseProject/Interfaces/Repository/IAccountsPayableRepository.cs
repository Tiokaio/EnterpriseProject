using EnterpriseProject.Entities;

namespace EnterpriseProject.Interfaces.Repository
{
    public interface IAccountsPayableRepository
    {
        IEnumerable<AccountsPayable> GetAll();

        AccountsPayable GetById(long id);
        AccountsPayable AddAccount(AccountsPayable employee);
        AccountsPayable UpdateAccount(AccountsPayable employee);
        AccountsPayable RemoveAccount(long id);
    }
}
