using System;

namespace ChainofResponsibility.handlers
{
    public class ValidPasswordHandler : Handler
    {

    private  Database database;

    public ValidPasswordHandler(Database database)
    {
        this.database = database;
    }
    
    public override bool handle(string username, string password)
    {
        if (!database.isValidPassword(username, password))
        {
            Console.WriteLine("Wrong Password!");
            return false;
        }
        return handleNext(username, password);
    }

}

}
