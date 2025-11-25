
namespace BankSimulator.Models
{
    internal sealed class Account
    {
        public int accountId {  get; set; }
        public int clientId { get; set; }
        public decimal balance { get; set; }
        public List<AccountType> accountType { get; set; }
        public DateOnly accountCreation { get; set; }
    }

    internal enum AccountType
    {
        Ahorro,
        Corriente
    }

}
