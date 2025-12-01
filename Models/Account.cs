
namespace BankSimulator.Models
{
    internal sealed class Account
    {
        private int accountId;
        private int clientId;
        private decimal balance;
        private List<AccountType> accountType;
        private DateOnly accountCreation;

        public int ACCOUNTID
        {
            get => this.accountId;
            set => this.accountId = value;
        }

        public int CLIENTID
        {
            get => this.clientId;
            set => this.clientId = value;
        }

        public decimal BALANCE
        {
            get => this.balance;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El balance no puede ser menos de $1.-");
                }
                this.balance = value;
            }
        }

        public List<AccountType> ACCOUNTTYPE
        {
            get => this.accountType;
            set => this.accountType = value;
        }

        public DateOnly ACCOUNTCREATION
        {
            get => this.accountCreation;
            set => this.accountCreation = value;
        }

    }

    internal enum AccountType
    {
        Ahorro,
        Corriente
    }

 

}
