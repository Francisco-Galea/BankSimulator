using BankSimulator.DTOs.Request;
using BankSimulator.Models;
using BankSimulator.Repositories;
using BankSimulator.Repositories.Interfaces;
using BankSimulator.Utils;

namespace BankSimulator.Controllers
{
    internal sealed class ClientController
    {

        private readonly IClientRepository clientRepository = new ClientRepository();
        private readonly AccountController accountController = new AccountController();
        private readonly TransactionController transactionController = new TransactionController();
        private readonly List<Client> clients;
        private Client clientLoged = new();

        public ClientController()
        {
            this.clients = clientRepository.LoadAllData();
        }

        public void Register()
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
            Console.WriteLine("Ingrese una contraseña: ");
            client.password = PasswordHasher.HashPassword(Console.ReadLine());
            accountController.CreateAccount(client);
        }

        public void Login()
        {
            UserLoginRequest userLogin = new();
            Console.WriteLine("Ingrese su dni: ");
            userLogin.dni = int.Parse(Console.ReadLine());
            Client clientFounded = clientRepository.GetClientByDNI(userLogin.dni);
            Console.WriteLine("Ingrese su contraseña: ");
            userLogin.password = Console.ReadLine();
            PasswordHasher.ValidPassword(userLogin.password, clientFounded.password);
            this.clientLoged = clientFounded;
            ClientLogedMenu();
        }

        public void ClientLogedMenu()
        {
            Console.Clear();
            int optionSelected = 0;
            do
            {
                Console.WriteLine($"Bienvenido {clientLoged.name} {clientLoged.lastName}");
                Console.WriteLine("¿Que operacion desea realizar?" +
                    "\n1- Retirar dinero" +
                    "\n2- Transferir" +
                    "\n3- Ingresar dinero" +
                    "\n4- Cerrar sesion" +
                    "\n5- Salir de la aplicacion");
                optionSelected = int.Parse(Console.ReadLine());
                ClientLogedMenuOptions(optionSelected);
            }
            while (true);
        }

        public void ClientLogedMenuOptions(int optionSelected)
        {
            switch (optionSelected)
            {
                case 1:
                    transactionController.WithDraw(clientLoged);
                    break;

                case 2:
                    transactionController.Transfer(clientLoged);
                    break;

                case 3:
                    transactionController.Deposit(clientLoged);
                    break;

                case 4:
                    //Un singletoon para gestionar sesiones?
                    break;

                case 5:
                    //cerrar aplicacion
                    break;

                default:
                    Console.WriteLine("Opcion ingresada no valida, ingrese una nuevamente");
                    break;
            }
        }

    }
}
