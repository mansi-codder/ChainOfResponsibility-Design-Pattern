using System;
using System.Collections.Generic;

namespace ChainofResponsibility.handlers
{
    public class Database
    {

        private Dictionary<string, string> users;

        public Database()
        {
            users = new Dictionary<string, string>();
            users.Add("admin_username", "admin_password");
            users.Add("user_username", "user_password");
        }

        public bool isValidUser(string username)
        {
            return users.ContainsKey(username);
        }

        public bool isValidPassword(string username, string password)
        {
            return users[username] == password;
        }

    }
}
