using System;

namespace TP4.Models
{
    public class User
    {
        private String login;
        private String pass;

        public string Login { get => login; set => login = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}