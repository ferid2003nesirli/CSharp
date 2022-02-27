using System;

namespace DotNet1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = "ZXCzxc123";
            Console.WriteLine("Hello Farid!");
            Console.Write("Please enter password for start ");
            string command  = Console.ReadLine();

            if (command == pass)
            {
                Console.WriteLine("Program started successfully");
            }
            else
            {
                Console.WriteLine("Password is incorrect. Please reenter password again.");
            }



        }
    }
}
