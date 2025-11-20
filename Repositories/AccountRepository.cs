using System.Text.Json;
using BankSimulator.Models;

namespace BankSimulator.Repositories
{
    internal class AccountRepository : IRepository<Account>
    {
        public List<Account> LoadAllData()
        {
            List<Account> accounts = new List<Account>();
            if (File.Exists("account.json"))
            {
                string json = File.ReadAllText("account.json");
                if (!string.IsNullOrWhiteSpace(json))
                    accounts = JsonSerializer.Deserialize<List<Account>>(json);
            }
            return accounts;
        }

        public Account LoadDataByIdentifier(int identifier)
        {
            throw new NotImplementedException();
        }

        

        public void SaveData(Account account)
        {
            List<Account> accounts = LoadAllData();
            accounts.Add(account);
            string jsonSerialize = JsonSerializer.Serialize(accounts);
            File.WriteAllText("account.json", jsonSerialize);
        }

        
    }
}


/*
  byte[] jsonSerialize = JsonSerializer.SerializeToUtf8Bytes(genericClass);
  Es una forma mas eficiente de serializar una clase
 */