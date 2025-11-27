
namespace BankSimulator.Utils
{
    internal sealed class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            return hashedPassword;
        }

        public static bool ValidPassword(string password, string hashedPassword)
        {
            bool isValid = BCrypt.Net.BCrypt.Verify(password, hashedPassword);
            return isValid;
        }

    }
}
