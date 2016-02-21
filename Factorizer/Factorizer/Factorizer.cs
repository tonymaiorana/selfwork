using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer
{
    public class Factorizer
    {
        public void Run ()
        {
            
            Console.Write("Please input a number to get it's factors: ");

            string input = Console.ReadLine();

            int num;

            if (int.TryParse(input, out num))
            {
                Console.WriteLine("The factors of " + num + " are: ");
            }

            else
            {
                Console.Write("Please make sure you enter a valid number");
            }

        }
    }
}