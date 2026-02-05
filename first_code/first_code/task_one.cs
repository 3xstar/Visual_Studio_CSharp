using System;
using System.Collections.Generic;
using System.Text;

// программа которая проверяет логин и пароль
// и не пускает пользователя,
// пока он не введет правильный пароль и логин

namespace first_code
{
    internal class task_one
    {
        void Main(string[] args)
        {
            string login = "Zahar";
            string password = "sigma";

            do
            {
                Console.Write("Enter your login: ");
                string userLogin = Console.ReadLine();

                Console.Write("Enter your password: ");
                string userPassword = Console.ReadLine();

                if (userLogin != login || userPassword != password)
                {
                    Console.WriteLine("Incorrect login or password!");
                }
                else
                {
                    Console.WriteLine("You welcome!");
                    break;
                }
            } while (true);
        }
    }
}