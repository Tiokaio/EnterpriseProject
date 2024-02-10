using EnterpriseProject.Contexts;
using EnterpriseProject.Entities;
using EnterpriseProject.Interfaces.Repository;

namespace EnterpriseProject.Infraestrutura.Repository
{
    public class AccountsPayableRepository : IAccountsPayableRepository
    {
        private readonly AccountsPayableDbContext _accountRepository;
        public AccountsPayableRepository(AccountsPayableDbContext employeeDbContext)
        {
            _accountRepository = employeeDbContext;
        }

        public AccountsPayable AddAccount(AccountsPayable employee)
        {
            _accountRepository.AccountsPayables.Add(employee);
            _accountRepository.SaveChanges();
            return employee;
        }

        public IEnumerable<AccountsPayable> GetAll()
        {
            return _accountRepository.AccountsPayables.ToList();
           
        }

        public AccountsPayable GetById(long id)
        {
            return _accountRepository.AccountsPayables.Find(id);
        }

        public AccountsPayable RemoveAccount(long id)
        {
            var employee = _accountRepository.AccountsPayables.Find(id);
            if (employee != null)
            {
                _accountRepository.AccountsPayables.Remove(employee);
                _accountRepository.SaveChanges();
            }
            return employee;
        }

        public AccountsPayable UpdateAccount(AccountsPayable employee)
        {
            _accountRepository.AccountsPayables.Update(employee);
            _accountRepository.SaveChanges();
            return employee;
        }
    }
}
