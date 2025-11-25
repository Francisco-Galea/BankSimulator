using BankSimulator.Models;
using BankSimulator.Repositories;

namespace BankSimulator.UnitOfWorks
{
    internal class UnitOfWork
    {
        private readonly IRepository<Account> accountRepository = new AccountRepository();
        private readonly IRepository<Client> clientRepository = new ClientRepository();

        public void SaveAccountAndClient(Account account, Client client)
        {
            accountRepository.SaveData(account);
            clientRepository.SaveData(client);
        }


    }
}
