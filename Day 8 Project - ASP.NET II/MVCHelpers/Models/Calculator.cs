using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHelpers.Models
{
    public class Calculator
    {
        public int Calc(int num1, int num2)
        {
            int total = num1 + num2;
            return total;
        }
    }
}