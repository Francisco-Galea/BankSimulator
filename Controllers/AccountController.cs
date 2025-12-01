using BankSimulator.Models;
using BankSimulator.UnitOfWorks;

namespace BankSimulator.Controllers
{
    internal sealed class AccountController
    {

        public void CreateAccount(Client client)
        {
            Account account = new Account();
            account.ACCOUNTID = client.clientId;
            account.CLIENTID = client.clientId;
            account.BALANCE = 0;
            account.ACCOUNTCREATION = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine("Que tipo de cuenta desea crear? " +
                "\n1- Corriente " +
                "\n2- Ahorro " +
                "\n3- Ambos " +
                "\n4- Cancelar operacion");
            int accountOption = int.Parse(Console.ReadLine());
            account.ACCOUNTTYPE = SelectAccountType(accountOption);
            UnitOfWork.SaveAccountAndClient(account, client);
        }

        public List<AccountType> SelectAccountType(int accountOption)
        {
            List<AccountType> accountTypes = new List<AccountType>();
            switch (accountOption)
            {
                case 1:
                    accountTypes.Add(AccountType.Corriente);
                    break;
                case 2:
                    accountTypes.Add(AccountType.Ahorro);
                    break;
                case 3:
                    accountTypes.Add(AccountType.Ahorro);
                    accountTypes.Add(AccountType.Corriente);
                    break;
                case 4:
                    Console.WriteLine("Cancelando operacion, espere");
                    break;
                default:
                    Console.WriteLine("Opcion ingresada invalida, intente nuevamente");
                    break;
            }
            return accountTypes;
        }


    }
}
