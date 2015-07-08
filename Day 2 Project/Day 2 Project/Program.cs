using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Project
{
    class Customer
    {


        //    public string FirstName { get; set; } //property

        //    public string LastName { get; set; } //property

        //    public int Age { get; set; }

        //    public DateTime Birthdate { get; set; }

        //    public string Display() //method (verb)
        //    {
        //        return string.Format("Name:{0} {1}, Age: {2}, Birth Date: {3}", this.FirstName, this.LastName, this.Age, this,Birthdate);
        //    }
        //}


        //    //Create a new instance of customer named sally using the property initializer syntax
        //    Customer sally = new Customer
        //    {
        //        Age = 23,
        //        Birthdate = DateTime.Parse("2028-01-01"),
        //        FirstName = "Sally",
        //        LastName = "Williams"
        //    };

        //    Customer mike = new Customer
        //    {
        //        Age = 10,
        //        Birthdate = DateTime.Parse("2019-01-01"),
        //        FirstName = "Mike",
        //        LastName = "Harrison"
        //    };

        //    Debug.Assert(sally.Age == 23, "Sally is 23");
        //    Debug.Assert(mike.Age == 10, "Mike is 10");


        //Console.ReadLine();



        //private string _name;
        //public string Name
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //    set
        //    {
        //        _name = value;
        //    }
        //}

        //private decimal _price;
        //public decimal Price
        //{
        //    get { return _price; }

        //    set 
        //    {
        //        if (value < 0)
        //        {
        //            throw new ArgumentException("value", "Price cannot be less than zero");
        //        }

        //        _price = value;
        //    }
        //}






        class Product
        {

            public string Name { get; set; }
            public decimal Price { get; set; }

            public decimal CalculateTax()
            {
                return this.CalculateTax(0, 0);
            }

            public decimal CalculateTax(decimal taxRate)
            {
                return this.CalculateTax(taxRate, 0);
            }

            public decimal CalculateTax(decimal taxRate, decimal discount)
            {
                return this.Price + (this.Price + taxRate) - (this.Price * discount);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {

                Product product1 = new Product
                {
                    Name = "Milk",
                    Price = 5.43m
                };

                Product product2 = new Product
                {
                    Name = "Eggs",
                    Price = 1.33m
                };
                //Console.WriteLine(string.Format("{0}: {1:c} + {2:c} tax", product1.Name, product1.Price, product1.CalculateTax)));
                product1.CalculateTax();
                product1.CalculateTax(0.08m);
                product1.CalculateTax(0.08m, 1.0m);

                Console.ReadLine();

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
                //string[] headlines = new string[] {
                //    "Tacos for free!", "Tacos Yoda likes!", "Why do you keep talking about tacos?"
                //};

                //Random rando = new Random();
                //int taco = rando.Next(3);

                //if (taco == 0)
                //{
                //    Console.WriteLine(headlines[0]);
                //}
                //else if (taco == 1)
                //{
                //    Console.WriteLine(headlines[1]);
                //}
                //else
                //{
                //    Console.WriteLine(headlines[2]);
                //}

                //var movies = new string[] 
                //{
                //"Star Wars", "King Kong", "Memento"
                //};

                //foreach (var movie in movies)
                //{
                //    Console.WriteLine(movie);
                //}

                //Console.ReadLine();

            }
        }
    }
}
