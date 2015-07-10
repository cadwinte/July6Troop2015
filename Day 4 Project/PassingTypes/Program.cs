using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingTypes
{
    class Program
    {
        static void Increment(ref int num)
        {
            num++;
        }

        static void Main(string[] args)
        {
                int num = 10;
                Increment(ref num);
                Console.WriteLine(num);
                Console.ReadLine();   
        }
    }
}
