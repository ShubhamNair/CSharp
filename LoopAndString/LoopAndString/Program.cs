using System;

namespace Loops
{
    internal class Login
    {
        static void Main(string[] args)
        {
            string UserName, password, checkUser, checkPassword;
            int count = 1;
            Console.WriteLine("Register\n");
            Console.WriteLine("Enter The UserName:");
            UserName = Console.ReadLine();
            Console.WriteLine("\nEnter The Password:");
            password = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter your Login ID and Password");

            while (count <= 3)
            {
                Console.WriteLine("Enter The UserName:");
                checkUser = Console.ReadLine();
                Console.WriteLine("\nEnter The Password:");
                checkPassword = Console.ReadLine();

                if (checkUser == UserName && checkPassword == password)
                {
                    Console.WriteLine("Login Successful");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Credentials");
                    count++;
                }
            }
            if (count == 4)
            {
                Console.WriteLine("Your Account is blocked");
            }
        }
    }
}
