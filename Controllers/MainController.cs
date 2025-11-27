namespace BankSimulator.Controllers
{
    internal sealed class MainController
    {

        private readonly ClientController clientController = new ClientController();

        public void MainMenu()
        {
            int option = 0;
            Console.WriteLine("Bienvenidos al sistema GARCArio!");
            do
            {
                Console.WriteLine("Ingrese el número indicado para empezar a operar: ");
                Console.WriteLine("1- Registrarse \n2- Iniciar sesion \n3- Cerrar programa");
                option = int.Parse(Console.ReadLine());
                Console.Clear();
                InitialMenu(option);
            }
            while (option != 3);
        }

        public void InitialMenu(int option)
        {
            switch(option)
            {
                case 1:
                    clientController.CreateClient();
                    break;
                case 2:
                    clientController.Login();
                    break;
                case 3:
                    Console.WriteLine("\n\nGracias por consumir la aplicacion! Hasta luego");
                    break;
                default:
                    Console.WriteLine("Opcion ingresada no valida, ingrese una nuevamente");
                    break;
            }
        }

    }
}
