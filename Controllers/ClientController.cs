using BankSimulator.Models;

namespace BankSimulator.Controllers
{
    internal class ClientController
    {
        public void CreateClient()
        {
            Client client = new();
            Console.WriteLine("Ingrese su dni: ");
            client.dni = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nombre: ");
            client.name = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            client.lastName = Console.ReadLine();
            Console.WriteLine("Ingrese su email: ");
            client.email = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña: ");
        }
    }
}
