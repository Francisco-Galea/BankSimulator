using System.Text.Json;
using BankSimulator.Models;

namespace BankSimulator.Repositories
{
    internal class ClientRepository : IRepository<Client>
    {
        public List<Client> LoadAllData()
        {
            List<Client> clients = new List<Client>();
            if (File.Exists("account.json"))
            {
                string json = File.ReadAllText("account.json");
                if (!string.IsNullOrWhiteSpace(json))
                    clients = JsonSerializer.Deserialize<List<Client>>(json);
            }
            return clients;
        }

        public Client LoadClientById(int clientId)
        {
            List<Client> clients = LoadAllData();
            Client client  = clients.Where(c => c.clientId == clientId).First();
            return client;
        }

        public void ExistDni(int dni)
        {
            List<Client> clients = LoadAllData();
            Client client = clients.Where(c => c.dni == dni).First();
            if (client == null)
            {
                Console.WriteLine("El dni ya existe");
            }
            else
            {
                Console.WriteLine("El dni no existe");
            }
        }

        public void SaveData(Client client)
        {
            List<Client> clients = LoadAllData();
            clients.Add(client);
            string jsonSerialize = JsonSerializer.Serialize(clients);
            File.WriteAllText("account.json", jsonSerialize);
        }
    }
}
