using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            "Everything is Awesome!".WriteColor(ConsoleColor.Yellow, ConsoleColor.Red);
            "When you go to Coder Camps!".WriteColor(ConsoleColor.DarkBlue, ConsoleColor.Green);

            Random myRand = new Random();
            int length = 10;
            string[] headlines = new string[3] { "Tacos for free!", "Tacos Yoda likes!", "Why do you keep talking about tacos?" };

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(headlines.GetRandom(myRand));
            }

            Console.ReadLine();
        }
    }

    static class ArrayExtensions
    {
        public static string GetRandom(this string[] x, Random y)
        {
            return x[y.Next(3)];
        }
    }

    static class StringExtensions
    {
        public static void WriteColor(this string stringToExtand, ConsoleColor backgroundColor, ConsoleColor foregroundColor)
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(stringToExtand);
        }
    }
}
