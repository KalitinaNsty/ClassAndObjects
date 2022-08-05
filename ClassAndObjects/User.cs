using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndObjects
{
    class User
    {
        private string login;
        private string password;
        private int age;
        public User(string login, string password, int age) 
        {
            this.login = login;
            this.password = password;
            this.age = age;
        }
        public User()
        {

        }
        public void SetAge(int age)
        {
            if (age < 0)
            {
                return;
            }
            this.age = age;
        }
        public void Print()
        {
            Console.WriteLine($"{login}, {password}, {age}");
        }
        public void SetLogin(string login)
        {
            if (login == "" || login == null)
            {
                return;
            }
            this.login = login;
        }
        public void SetPassword(string password)
        {
            if (password == null || password == "")
            {
                return;
            }
            this.password = password;
        }
        public int GetAge()
        {
            return age;
        }
        public string GetLogin()
        {
            return login;
        }
        public string GetPassword()
        {
            return password;
        }
    }
}
