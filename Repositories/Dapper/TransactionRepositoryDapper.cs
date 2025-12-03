using BankSimulator.Models;
using BankSimulator.Repositories.Interfaces;

namespace BankSimulator.Repositories.Dapper
{
    internal class TransactionRepositoryDapper : IClientRepository
    {
        public Client GetClientByDNI(int dni)
        {
            throw new NotImplementedException();
        }

        public Client GetClientById(int clientId)
        {
            throw new NotImplementedException();
        }

        public List<Client> LoadAllData()
        {
            throw new NotImplementedException();
        }

        public void SaveData(Client genericClass)
        {
            throw new NotImplementedException();
        }
    }
}
