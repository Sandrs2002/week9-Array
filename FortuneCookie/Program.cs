using System;

namespace FortuneCookie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fortunes = { "win a Jackpot", "fall in love", "get a love letter", "miss the bus", "see a unicorn un the street" };

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, fortunes.Length);

            Console.WriteLine($"Your fortune for today is : {fortunes[randomIndex]}");

        }
    }
}
