using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSources
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter taco1 = new Counter{};
            taco1.CountWords("taco taco burrito burrito");

            Console.WriteLine(taco1.NumberOfWords);
            Console.ReadLine();

        }
    }

    class Counter
    {
        public int NumberOfWords { get; set; }

        public int CountWords(string x)
        {
            int y = 0;
            for (int i = 1; i < x.Length; i++)
            {
                if (char.IsWhiteSpace(x[i - 1]) == true)
                {
                    if (char.IsLetterOrDigit(x[i]) == true || char.IsPunctuation(x[i]))
                    {
                        y++;
                    }
                }
            }
            if (x.Length > 2)
            {
                y++;
            }
            return NumberOfWords = y;
        }
    }
}
