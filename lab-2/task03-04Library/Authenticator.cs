namespace task03Library
{
    public interface IAuthenticator
    {
        void AuthenticateUser(string username, string password);
    }

    public sealed class Authenticator : IAuthenticator
    {
        private static readonly Authenticator instance = new Authenticator();

        private Authenticator() { }

        public static Authenticator Instance
        {
            get
            {
                return instance;
            }
        }

        public void AuthenticateUser(string username, string password)
        {
            // Логування може бути додано тут

            Console.WriteLine($"Authenticating user: {username} with password: {password}");

            // Обробка помилок може бути додана тут
        }
    }
    
}
