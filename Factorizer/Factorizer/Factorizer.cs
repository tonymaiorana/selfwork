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
                for(int factor = 1; factor * factor <= num; factor++) 
                {
                    if (num % factor == 0)
                    {
                        Console.WriteLine(factor);
                    }

                    if (factor*factor != num)
                    {
                        Console.WriteLine(num / factor);
                    } 
                }

            }

            else
            {
                Console.Write("Please make sure you enter a valid number");
            }

        }
    }
}