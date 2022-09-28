using ChainofResponsibility.handlers;
using System;

namespace ChainofResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Database database = new Database();

            Handler handler = new UserExistsHandler(database);
            handler.setNextHandler(new ValidPasswordHandler(database))
                .setNextHandler(new RoleCheckHandler());
            
            AuthService service = new AuthService(handler);

            Console.WriteLine("==========================================");

            Console.WriteLine(service.logIn("username", "password"));

            Console.WriteLine("==========================================");

            Console.WriteLine(service.logIn("user_username", "password"));

            Console.WriteLine("==========================================");

            Console.WriteLine(service.logIn("admin_username", "admin_password"));

            Console.WriteLine("==========================================");

        }
    }
}
