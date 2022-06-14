using System;

namespace ForEachInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apples", "bananas", "oranges", "pears", "plums", "pineapples" };

            foreach(string item in fruits)
            {
                Console.WriteLine(item);
                if(item == "plums")
                {
                    Console.WriteLine($"Ew, i dont like {item}!");
                }
            }





        }
    }
}
