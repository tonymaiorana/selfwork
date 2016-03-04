using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata2
{
    public class KataMathMaker
    {
        public int Add(string numbers)
        {
            int sum = 0;

            if (String.IsNullOrEmpty(numbers))
            {
                return sum;
            }

            string[] del;
            if (numbers.StartsWith("//"))
            {
                string[] parts = numbers.Split('\n');

                if (parts[0].Length == 3)
                {
                    del = new string[] {parts[0].Remove(0,2)};
                }

                else
                {
                    List<string> delims = new List<string>();
                    foreach (char c in parts[0])
                    {
                        if (c != '/' && c != '[' && c != ']')
                        {
                            delims.Add(c.ToString());
                        }
                    }
                    //del = new string[] {parts[0].Substring(3,
                    //parts[0].Length - 4)
                    //};
                }

                numbers = parts[1];
            }

            else
            {
                del = new string[] {",", "\n"};
            }

            string[] arrNums = numbers.Split(del, StringSplitOptions.RemoveEmptyEntries);

            if (arrNums.Length == 1)
            {
                sum = int.Parse(numbers);
            }
            else
            {
                int number = 0;
                bool isNegativeFound = false;
                for (int i = 0; i < arrNums.Length; i++)
                {
                    number = int.Parse(arrNums[i]);
                    if (number > 0 && !isNegativeFound)
                    {
                        if (number < 1000)
                        {
                            sum += number;
                        }
                    }
                    else
                    {
                        if (!isNegativeFound)
                        {
                            Console.Write("Negatives not allowed: {0}", number);
                        }
                        else
                        {
                            Console.Write(",{0}", number);
                        }

                        isNegativeFound = true;
                        sum = -1;
                    }

                }
            }

            return sum;

        }
    }
}
