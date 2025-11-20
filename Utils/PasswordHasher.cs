
namespace BankSimulator.Utils
{
    internal class PasswordHasher
    {
        public string HashPassword(string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            return hashedPassword;
        }

        public bool ValidPassword(string password, string hashedPassword)
        {
            bool isValid = BCrypt.Net.BCrypt.EnhancedVerify(password, hashedPassword);
            return isValid;
        }

    }
}
