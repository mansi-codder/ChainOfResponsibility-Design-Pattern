using System;

namespace ChainofResponsibility.handlers
{
    public class RoleCheckHandler : Handler
    {
        public override bool handle(string username, string password)
        {
            if ("admin_username" == username)
            {
                Console.WriteLine("Loading Admin Page...");
                return true;
            }
            Console.WriteLine("Loading Default Page...");
            return handleNext(username, password);
        }

    }
}
