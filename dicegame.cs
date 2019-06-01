using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Guess a number between 1 and 6");
            string guess = Console.ReadLine();
            int guessnumber = Int32.Parse(guess);
            int diceroll = rnd.Next(1,7);
            Console.WriteLine(diceroll);
            if (diceroll == guessnumber)
            {
                Console.WriteLine("You won!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You lose!");
                Console.ReadKey();
            }
        }
    }
}
