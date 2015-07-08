using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            NewCar tesla = new NewCar();
            tesla.Model = "Model S";
            tesla.Price = 90000m;
            tesla.VIN = "SC54SD5F4SDF5S5SD";

            UsedCar usedToyota = new UsedCar();
            usedToyota.Price = 20000m;
            usedToyota.CalculateTax();

            CertifiedUsedCar cuLexus = new CertifiedUsedCar();

            NewCar[] newCars = new NewCar[] { tesla, /*usedToyota,*/ }; //No no bc the toyota isn't a NewCar
            Car[] newerCars = new Car[] { tesla, usedToyota, cuLexus }; //sisisi bc they're all cars

            Car[] inventory = new Car[]
            {
                new UsedCar { VIN = "65465AS4D6F5AS4FD", Price = 17000m },
                new CertifiedUsedCar { VIN = "52152452152452451", Price = 17000m },
                new NewCar { VIN = "22452145259554525", Price = 44000m },
                new UsedCar { VIN = "s98sdf8ds9f89s9d6", Price = 12000m },
                new UsedCar { VIN = "asdfasd2342342345", Price = 11000m }
            };

            decimal total = 0;
            foreach(Car car in inventory)
            {
                if (car is UsedCar)
                {
                    total += car.Price;
                }
            }

            Console.WriteLine("Total inventory value: " + total.ToString("c"));
            Console.ReadLine();
        }
    }

    abstract class Car
    {
        public string VIN { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public decimal CalculateTax()
        {
            return this.Price * 0.08m;
        }
    }

    class NewCar : Car
    {
    }

    class UsedCar : Car
    {
        public int Miles { get; set; }
    }

    class CertifiedUsedCar : UsedCar
    {
        public int WarrantyMonths { get; set; }
    }
}
