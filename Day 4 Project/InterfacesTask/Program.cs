using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear oso = new Bear
            {
                AnimalName = "Grizzly Bear",
            };

            Chicken pollo = new Chicken
            {
                AnimalName = "El Macho Burracho",
            };

            Eagle aguila = new Eagle
            {
                AnimalName = "Bald Eagle",
            };

            AnimalUtility.DoSomething(oso);
            AnimalUtility.DoSomething(pollo);
            AnimalUtility.DoSomething(aguila);

            Console.ReadLine();
        }
    }

    interface IAnimal
    {
        string AnimalName { get; set; }
        string MakeSound();
    }

    class Bear : IAnimal 
    {
        public string AnimalName { get; set; }
        public string MakeSound()
        {
            return "Roooaaarrrrrrrrrrr";
        }
    }

    class Chicken : IAnimal, IBird
    {
        public string AnimalName { get; set; }
        public string MakeSound()
        {
            return "cock-a-doodle-doo";
        }
    }

    class Eagle : IAnimal, IBird
    {
        public string AnimalName { get; set; }
        public string MakeSound()
        {
            return "Freedom";
        }
    }

    class AnimalUtility
    {
        public static void DoSomething(IAnimal animal)
        {
            Console.WriteLine(animal.AnimalName);
            Console.WriteLine(animal.MakeSound());

            if (animal is IBird)
            {
                Console.WriteLine("Flap Flap Flap!!!");
            }
        }
    }
}
