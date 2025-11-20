
namespace BankSimulator.Models
{
    internal sealed class Transaction
    {
        public int transactionId {  get; set; }
        public int originAccountId { get; set; }
        //public Account originAccount { get; set; }
        public int destinationAccountId { get; set; }
        //public Account destinationAccount { get; set; }
        public decimal ammount { get; set; }
        public TransactionType transactionType { get; set; }
        public DateTime dateTimeOfTransaction { get; set; }
    }

    internal enum TransactionType
    {
        Depósito,
        Retiro,
        Transferencia
    }

}
