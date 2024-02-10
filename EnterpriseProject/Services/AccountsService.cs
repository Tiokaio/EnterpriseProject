using EnterpriseProject.Dtos.Accounts.Request;
using EnterpriseProject.Entities;
using EnterpriseProject.Interfaces.Repository;
using EnterpriseProject.Interfaces.Services;

namespace EnterpriseProject.Services
{
    public class AccountsService : IAccountsPayableService
    {
        private IAccountsPayableRepository _accountRepository;

        public AccountsService
            (
            IAccountsPayableRepository accountsPayableRepository
            )
        {
            _accountRepository = accountsPayableRepository;
        }
        public AccountsPayable AddAccount(RequestAddAccount account)
        {
            var newAccount = new AccountsPayable();
            newAccount.IsPaid = account.IsPaid;
            newAccount.Description = account.Description;
            newAccount.AccountValue = account.AccountValue;
            newAccount.DueDate = account.DueDate;
            var add = _accountRepository.AddAccount( newAccount );
            return add;
        }

        public AccountsPayable GetAccount(long AccountId)
        {
            return _accountRepository.GetById( AccountId );
        }

        public List<AccountsPayable> GetAllAccounts()
        {
            return _accountRepository.GetAll().ToList();
        }

        public AccountsPayable RemoveAccount(long? Id)
        {
            var deleted = _accountRepository.GetById((long)Id);
            if (deleted == null) throw new ApplicationException("Conta não encontrada");
            return _accountRepository.RemoveAccount((long)Id);
        }

        public AccountsPayable UpdateAccount(RequestUpdateAccount account)
        {
            var deleted = _accountRepository.GetById(account.Id);
            if (deleted == null) throw new ApplicationException("Conta não encontrada");
            deleted.UpdateAt = DateTime.Now;
            deleted.Description = account.Description;
            deleted.AccountValue = account.AccountValue;
            deleted.DueDate = account.DueDate;
            deleted.IsPaid = account.IsPaid;
            var update = _accountRepository.UpdateAccount( deleted ); 
            return update;
        }
    }
}
