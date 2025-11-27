using BankSimulator.Repositories.Interfaces;
using System.Transactions;

namespace BankSimulator.Repositories
{
    internal class TransactionRepository : IRepository<Transaction>
    {
        public List<Transaction> LoadAllData()
        {
            throw new NotImplementedException();
        }

        public void SaveData(Transaction genericClass)
        {
            throw new NotImplementedException();
        }
    }
}
