namespace BankSimulator.DTOs.Request
{
    internal sealed class UserLoginRequest
    {
        public int dni {  get; set; }
        public string password { get; set; } = string.Empty;
    }
}
