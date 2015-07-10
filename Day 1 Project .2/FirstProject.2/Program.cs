using FirstProject._2.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (File.Exists(@"HelloWorld.txt"))
            //{
            //    Console.WriteLine("It Exists!");
            //}

            //String name = "Cade";
            //Int32 number = 12;
            //Boolean isTodayMonday = true;

            //string name2 = "Cade";
            //int number2 = 12;
            //bool isTodayFriday = false;


            //Console.WriteLine("Enter the first number:");
            //int firstNum = 0;
            //bool firstNumIsNumber = int.TryParse(Console.ReadLine(), out firstNum);

            //Console.WriteLine("Enter the second number:");
            //int secondNum = 0;
            //bool secondNumisNumber = int.TryParse(Console.ReadLine(), out secondNum);

            //if (firstNumIsNumber && secondNumisNumber)
            //{
            //    int result = firstNum + secondNum;
            //    Console.WriteLine("The result is " + result.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("You did not enter valid numbers!");
            //}

            //DayOfWeek dayOfWeek = DateTime.Now.DayOfWeek;

            //string dinner = "";

            //switch (dayOfWeek)
            //{
            //    case DayOfWeek.Monday:
            //        dinner = "Steak";
            //        break;
            //    case DayOfWeek.Tuesday:
            //        dinner = "Chicken";
            //        break;
            //    case DayOfWeek.Wednesday:
            //        dinner = "Pizza";
            //        break;
            //    case DayOfWeek.Thursday:
            //        dinner = "Salad";
            //        break;
            //    case DayOfWeek.Friday:
            //        dinner = "Fish";
            //        break;
            //    default:
            //        dinner = "Pasta";
            //        break;
            //}

            //Console.WriteLine("Today, we are eating " + dinner);

            //Console.ReadLine();

            //DateTime date1 = DateTime.Now;
            //Console.WriteLine(date1);
            //Console.ReadLine();


            //string date = "09/20/2005";
            //Console.WriteLine("Enter your date:");
            //date = (Console.ReadLine());
            //DateTime dt = Convert.ToDateTime(date);
            //Console.WriteLine("Year: {0}, Month {1}, Day: {2}", dt.Year, dt.Month, dt.Day);
            //Console.ReadLine();

            Console.WriteLine("Enter a date: ");
            string dateString = (Console.ReadLine());
            DateTime myDate = DateTime.Parse(dateString);
            Console.WriteLine("The date you ented is " + myDate.ToLongDateString());
            Console.ReadLine();
        }
    }
}
