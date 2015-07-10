using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Project
{
    class Program
    {
        static void Main(string[] args)
        { 
            string y = "5";
            string x = "Battleship";

            int? result1 = y.TryParseToInt();
            int? result2 = x.TryParseToInt();

            if (result1 != null)
                Console.WriteLine("Successfully parsed " + result1);

            else
                Console.WriteLine("Unable to parse " + y);

            if (result2 != null)
                Console.WriteLine("Successfully parsed " + result2);

            else
                Console.WriteLine("Unable to parse " + x);

            Console.ReadLine();

            //int number = 0;
            //if (int.TryParse(value, out number1))
            //{
            //    return number1;
            //}
            //else
            //{
            //    return null;
            //}

            //return int.TryParse(value, out number) ? number : default
        }
    }
    public static class StringExtension
    {
        public static int? TryParseToInt(this string value)
        {
            int number = 0;
            return int.TryParse(value, out number) ? number : default(int?);
        }
    }
}