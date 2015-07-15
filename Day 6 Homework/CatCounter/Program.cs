using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"There once was a cat named Frank. Frank was a special cat, for Frank was a cat that was fat, thus, 
            a fat cat. But why was the cat a fat cat you ask? Well, Frank the cat got to be a fat cat by eating a lot of cat food. 
            Pretty simple, actually -- becoming a fat cat. Cat, by definition, is just a weird creature, fat cat or not.";

            string x = "cat";
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var matchingWord = from word in source
                               where word.ToLowerInvariant() == x.ToLowerInvariant()
                               select word;

            int y = matchingWord.Count();
            stopwatch.Stop();

            Console.WriteLine("There were " + y + " occurrences of " + x + " in the string.");
            Console.WriteLine("It took " + stopwatch.Elapsed.TotalMilliseconds + " milliseconds to tell you that...");

            Console.ReadLine();
        }
    }
}
