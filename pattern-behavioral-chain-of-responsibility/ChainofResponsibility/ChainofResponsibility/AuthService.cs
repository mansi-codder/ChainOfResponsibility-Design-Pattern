using System;

namespace ChainofResponsibility.handlers
{
    public class AuthService
    {

        private  Handler handler;

    public AuthService(Handler handler)
        {
            this.handler = handler;
        }

        public bool logIn(string email, string password)
        {
            if (handler.handle(email, password))
            {
                Console.WriteLine("Authorization was successful!");
                // Do stuff for authorized users
                return true;
            }
            return false;
        }

    }
}
