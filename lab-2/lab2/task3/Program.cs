using task03Library;
namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Authenticator authenticator = Authenticator.Instance;
            Console.WriteLine("Enter your login:");
            string login = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Your authentication process:");
            authenticator.AuthenticateUser(login, password);
        }
    }
}