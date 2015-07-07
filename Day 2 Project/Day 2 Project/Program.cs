using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //string productName = "laptop";
            //decimal price = 344.55m;

            ////concatenation
            //string message = "The " + productName + " costs " + price.ToString() + " dollars.";
            //Console.WriteLine(message);

            ////string format - interpolation - better for performance and  memory
            //string message2 = string.Format("The {0} costs {1:c} dollars.", productName, price);
            //Console.WriteLine(message2);


            //Arrays 
            //string[] colors = new string[] {
            //    "Blue", "Red", "Green"
            //};

            //int[] numbers = new int[] { 2, 27, 84, 1584 };

            //Array.Sort(colors);
            //Console.WriteLine(colors[1]);


            //Individual array task
            string[] headlines = new string[] {
                "Tacos for free!", "Yoda likes tacos!", "Why do you keep talking about tacos?"
            };

            Random rando = new Random();
            int taco = rando.Next(3);

            if (taco == 0)
            {
                Console.WriteLine(headlines[0]);
            }
            else if (taco == 1)
            {
                Console.WriteLine(headlines[1]);
            }
            else
            {
                Console.WriteLine(headlines[2]);
            }

            var movies = new string[] 
            {
            "Star Wars", "King Kong", "Memento"
            };

            foreach (var movie in movies)
            {
                Console.WriteLine(movie);
            }

            Console.ReadLine();


        }
    }
}
