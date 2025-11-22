using BankSimulator.Models;
using BankSimulator.Repositories;
using BankSimulator.Utils;

namespace BankSimulator.Controllers
{
    internal class ClientController
    {

        private readonly IRepository<Client> clientRepository = new ClientRepository();
        private readonly List<Client> clients;

        public ClientController(List<Client> clients)
        {
            this.clients = clientRepository.LoadAllData();
        }

        public void CreateClient()
        {
            Client client = new();
            client.clientId = clients.Count + 1;
            Console.WriteLine("Ingrese su dni: ");
            client.dni = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nombre: ");
            client.name = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            client.lastName = Console.ReadLine();
            Console.WriteLine("Ingrese su email: ");
            client.email = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña: ");
            client.password = PasswordHasher.HashPassword(Console.ReadLine());
            clientRepository.SaveData(client);
            GetClients();
        }

        public void GetClients()
        {
            //return clientRepository.LoadAllData();
            foreach (var item in clients)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }
}
