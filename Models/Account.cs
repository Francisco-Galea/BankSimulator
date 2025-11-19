
namespace BankSimulator.Models
{
    internal class Account
    {
        public int accountId {  get; set; }
        public Client client { get; set; }
        public decimal balance { get; set; }
        public AccountType accountType { get; set; }
        public DateOnly accountCreation { get; set; }
    }

    internal enum AccountType
    {
        Ahorro,
        Corriente
    }

}
