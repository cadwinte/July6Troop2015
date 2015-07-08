using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play2
{
    static class StringExtensions
    {
        public static void WriteColor(this string stringToExtand, ConsoleColor backgroundColor, ConsoleColor foregroundColor)
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(stringToExtand);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            "Everything is Awesome!".WriteColor(ConsoleColor.Yellow, ConsoleColor.Red);
            "When you go to Coder Camps!".WriteColor(ConsoleColor.DarkBlue, ConsoleColor.Green);

            string[] headlines = new string[] {
                "Tacos for free!", "Tacos Yoda likes!", "Why do you keep talking about tacos?"
            };

            Random rando = new Random();
            int taco = rando.Next(3);

            if (taco == 0)
            {
                Console.WriteLine(headlines[0]);
            }
            else if (taco == 1)
            {
                Console.WriteLine(headlines[1]);
            }
            else
            {
                Console.WriteLine(headlines[2]);
            }

            Console.ReadLine();
        }
    }
}
