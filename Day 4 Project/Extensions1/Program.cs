using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Everything is Awesome!".Reverse();
            //string revMessage = StringUtility.Reverse(message);
            //Console.WriteLine(revMessage);
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }

    //class StringUtility
    //{
    //    public static string Reverse(string text)
    //    {
    //        Char[] textArray = text.ToCharArray();
    //        Array.Reverse(textArray);
    //        return new String(textArray);
    //    }
    //}

    static class StringExtensions
    {
        public static string Reverse(this string stringToExtend)
        {
            Char[] textArray = stringToExtend.ToCharArray();
            Array.Reverse(textArray);
            return new String(textArray);
        }
    }
}
