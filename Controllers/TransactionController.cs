using BankSimulator.Models;
using BankSimulator.Repositories;
using BankSimulator.Repositories.Interfaces;

namespace BankSimulator.Controllers
{
    internal sealed class TransactionController
    {

        private readonly ITransactionRepository transactionRepository = new TransactionRepository();

        public void WithDraw(Client clientLoged)
        {
            Transaction transaction = new();
            transaction.originAccountId = clientLoged.clientId;
            Console.WriteLine($"Saldo disponible: \nIngrese la cantidad a retirar:");
            transaction.ammount = decimal.Parse(Console.ReadLine());
            transaction.transactionType = TransactionType.Retiro;
            transaction.dateTimeOfTransaction = DateTime.UtcNow;
            transactionRepository.SaveData(transaction);
        }

        public void Deposit(Client clientLoged)
        {

        }

        public void Transfer(Client clientLoged)
        {

        }

    }
}
