using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");
            int user1 = Convert.ToInt32(Console.ReadLine());

            Random rando = new Random();
            int player2 = rando.Next(1, 3);

            if (user1 == player2)
                Console.WriteLine("Draw");

            else if (user1 == 1 && player2 == 2)
                Console.WriteLine("Paper covers rock, the computer won :(");

            else if (user1 == 2 && player2 == 3)
                Console.WriteLine("Scissors cuts paper, the computer won :(");

            else if (user1 == 3 && player2 == 1)
                Console.WriteLine("Rock smashes scissors, the computer won :(");

            else if (user1 == 1 && player2 == 3)
                Console.WriteLine("Rock smashes scissors, You won!");

            else if (user1 == 2 && player2 == 1)
                Console.WriteLine("Paper covers rock, You won!");

            else
                Console.WriteLine("Scissors cuts paper, You won!");

            Console.ReadLine();


        }
    }
}
