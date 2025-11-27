using BankSimulator.Models;
using BankSimulator.Repositories;
using BankSimulator.Repositories.Interfaces;

namespace BankSimulator.UnitOfWorks
{
    internal sealed class UnitOfWork
    {
        private static readonly IClientRepository clientRepository = new ClientRepository();
        private static readonly IAccountRepository accountRepository = new AccountRepository();

        public void SaveAccountAndClient(Account account, Client client)
        {
            accountRepository.SaveData(account);
            clientRepository.SaveData(client);
        }



    }
}
