using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Utility.CleanUserInput(" asdfadfSADFADSF  ");
        }
    }

    class Utility
    {
        public static string CleanUserInput(string input)
        {
            return input.ToLower().Trim();
        }
    }
}
