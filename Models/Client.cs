namespace BankSimulator.Models
{
    internal class Client
    {
        public int clientId {  get; set; }
        public int dni { get; set; }
        public string name { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string email {  get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
    }
}
