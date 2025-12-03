using System.Text.Json;
using BankSimulator.ExceptionHandler.ClientExceptions;
using BankSimulator.Models;
using BankSimulator.Repositories.Interfaces;

namespace BankSimulator.Repositories
{
    internal class ClientRepository : IClientRepository
    {
        public List<Client> LoadAllData()
        {
            List<Client> clients = new List<Client>();
            if (File.Exists("client.json"))
            {
                string json = File.ReadAllText("client.json");
                if (!string.IsNullOrWhiteSpace(json))
                    clients = JsonSerializer.Deserialize<List<Client>>(json);
            }
            return clients;
        }

        public Client GetClientById(int clientId)
        {
            try
            {
                return LoadAllData().First(c => c.clientId == clientId);
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("No existen clientes registrados");
            }
        }

        public Client GetClientByDNI(int dni)
        {
            try
            {
                return LoadAllData().First(c => c.dni == dni);
            }
            catch (InvalidOperationException)
            {
                throw new ClientNotFoundException();
            }
        }

        public void SaveData(Client client)
        {
            List<Client> clients = LoadAllData();
            clients.Add(client);
            string jsonSerialize = JsonSerializer.Serialize(clients);
            File.WriteAllText("client.json", jsonSerialize);
        }
    }
}
