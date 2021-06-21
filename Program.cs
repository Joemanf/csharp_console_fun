using System;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            Console.WriteLine("Hello, what's your name?");
            Console.ReadLine();
            Console.WriteLine("My name is RX-9000.\nI am an AI sent from the future to des-... hug, mankind.");
            Console.WriteLine("What is your favorite color?");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cool! Mine is destruction.");
            Console.ReadKey();
        }
    }
}
