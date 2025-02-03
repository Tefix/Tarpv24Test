using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a color:");
            string colour = Console.ReadLine();

          
            if (colour == "red" || colour == "blue" || colour == "green" || colour == "white")
            {
                Console.WriteLine("Your color is " + colour);
            }
            else
            {
                Console.WriteLine("You don't have this option.");
            }
        }
    }
}