using BankSimulator.Controllers;
using BankSimulator.Models;

List<Client> clients = new List<Client>();

Console.WriteLine("Hello world!");
ClientController controller = new ClientController(clients);
controller.CreateClient();
