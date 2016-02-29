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

                for (int i = num; i > 0; i--)
                {
                    if (num % i == 0)
                    {
                        //make a list or array of all the factors "i"
                    }

                }
                    
                    if //(list or array of i, has 2 element then its prime)

                    )
                Console.WriteLine("The factors of " + num + " are: ");

            }

            else
            {
                Console.Write("Please make sure you enter a valid number");
            }

        }
    }
}