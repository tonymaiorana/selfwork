using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
   public class StringCalculatorKata
    {
        public int Add(string numbers)
        {
            int sum = 0;

            string[] array = numbers.Split(',');

            if (numbers == "")
            {
                return sum;
            }

            else if (array.Length == 1)
            {
                sum = int.Parse(numbers);
            }

            else if (array.Length == 2)
            {
                sum = int.Parse(array[0]) + int.Parse(array[1]);
            }

            else
            {
                Console.WriteLine("You need to actually put a number in");
            }

            array.Length;


            return sum;
        }
    }
}
