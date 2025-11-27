using BankSimulator.Models;

namespace BankSimulator.Repositories.Interfaces
{
    internal interface IClientRepository : IRepository<Client>
    {
        Client GetClientById(int clientId);
        Client GetClientByDNI(int dni);
    }
}
