using System;

namespace ClassAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            //user1.login = "qwerty";
            //user1.password = "12345";
            //user1.age = 26;
            user1.Print();
            user1.SetAge(13);
            user1.SetLogin("qwerty");
            user1.SetPassword("234567");
            user1.Print();
            int currenAge = user1.GetAge();
            Console.WriteLine(currenAge);
            User user2 = new User("pole", "newPass", 10 );
            user2.Print();
        }
    }
}
