using System;

namespace MatterOfTaste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite color:");

            string userInput = Console.ReadLine().ToLower();
            string[] colors = { "red", "green", "blue" };


            if (userInput == "red" || userInput == "green" || userInput == "blue")
            {
                Console.WriteLine("We are perfect together!");
                Console.WriteLine("Thats also my favourite color!");
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("Not my favourite color honestly, but you do you.");
                Console.WriteLine("Every man to his taste");
                Console.WriteLine();
            }

            Console.WriteLine("Have a nice day!");

        }
    }
}