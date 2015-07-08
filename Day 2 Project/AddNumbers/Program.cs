using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNumbers
{
    class Program
    {
    class Math
    {
        public int DoSomething (int num1, int num2)
        {
            return num1 / num2;
        }
        public int DoSomething (int num1, int num2, int num3)
        {
            return num1 - num2 - num3;
        }
        public int DoSomething (int num1, int num2, int num3, int num4)
        {
            return num1 * num2 * num3 * num4;
        }
        public int DoSomething (int num1, int num2, int num3, int num4, int num5)
        {
            return num1 + num2 + num3 + num4 + num5;
        }
    }
        static void Main(string[] args)
        {
            Math x = new Math();

            int result1 = x.DoSomething(3, 3, 3, 3, 3);
            Debug.Assert(result1 == 15, "Result is 15");

            int result2 = x.DoSomething(5, 2, 1);
            Debug.Assert(result2 == 2, "Result is 2");

            int result3 = x.DoSomething(3, 5, 1, 2);
            Debug.Assert(result3 == 30, "Result is 30");

            int result4 = x.DoSomething(49, 7);
            Debug.Assert(result4 == 7, "Result is 7");

            int result5 = x.DoSomething(181, 9);
            Debug.Assert(result5 == 9, "Result is 9");


            Console.ReadLine();
        }
    }
}
