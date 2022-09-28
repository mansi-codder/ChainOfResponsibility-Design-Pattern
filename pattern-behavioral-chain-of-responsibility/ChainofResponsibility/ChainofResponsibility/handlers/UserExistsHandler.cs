using System;

namespace ChainofResponsibility.handlers
{
    public class UserExistsHandler : Handler
    {

        private Database database;

        public UserExistsHandler(Database database)
        {
            this.database = database;
        }


        public override bool handle(string username, string password)
        {
            if (!database.isValidUser(username))
            {
                Console.WriteLine("This username is not registered!");
                Console.WriteLine("Sign Up to our app now!");
                return false;
            }
            return handleNext(username, password);
        }

    }
}
