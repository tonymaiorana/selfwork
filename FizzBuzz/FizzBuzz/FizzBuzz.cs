using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
   public class FizzBuzz
    {
        public void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz: ");
                    
                }

                else if (i % 3 == 0)
                {
                    Console.Write("Fizz: ");
                }

                else if (i % 5 == 0)
                {
                    Console.Write("Buzz: ");
                }
                Console.WriteLine(i);
            }


        }


    }
}
