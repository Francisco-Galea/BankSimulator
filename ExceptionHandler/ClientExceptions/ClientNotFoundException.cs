
namespace BankSimulator.ExceptionHandler.ClientExceptions
{
    internal class ClientNotFoundException : Exception
    {
        public ClientNotFoundException()
        {
            Console.WriteLine("Cliente no encontrado");
        }
    }
}
