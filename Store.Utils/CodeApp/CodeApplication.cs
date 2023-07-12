namespace Store.Utils
{
    public static class CodeApplication
    {
        private static string condeApp = "250787";
        private static string passwordUser = "123456";

        public static string EncriptarCode()
        {
            return BCrypt.Net.BCrypt.HashPassword(condeApp);
        }

        public static bool DesencriptarCode(string imput, string password)
        {
            return BCrypt.Net.BCrypt.Verify(imput, password);
        }

        public static string EncriptarUser()
        {
            return BCrypt.Net.BCrypt.HashPassword(passwordUser);
        }

        public static string EncriptarAuth(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool DesencriptarAuth(string imput, string password)
        {
            return BCrypt.Net.BCrypt.Verify(imput, password);
        }
    }
}