using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Warmups
{
    public class Loops
    {
        /// <summary>
        /// Exercise 01 StringTimes
        /// </summary>
        /// <param name="str"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public string StringTimes(string str, int n)
        {
            string newstring = "";
            for (int i = 0; i < n; i++)
            {
                newstring += str;
            }
            return newstring;
        }

        public string FrontTimes(string str, int n)
        {
            string newstring = "";
            for (int i = 0; i < n; i++)
            {
                newstring += str.Substring(0, 3);
            }
            return newstring;
        }

        /// <summary>
        /// Exercise 03 CountXX
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int CountXX(string str)
        {
            int count = 0;
            string xCheck = "xx";
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str.Substring(i, 2) == xCheck)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Exercise 04 DoubleX
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool DoubleX(string str)
        {
            if (str.Contains("x"))
            {
                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str.Substring(i, 1).Equals("x"))
                    {
                        if (str.Substring(i, 2).Equals("xx"))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return false;
        }


        /// <summary>
        /// Exercise 05 EveryOther
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string EveryOther(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i+=2)
            {
                result += str.Substring(i,1);
            }
            return result;
        }

        /// <summary>
        /// Exercise 06 StringSplosion
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string StringSplosion(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result = result + str.Substring(0, i + 1);
            }
            return result;
        }

        /// <summary>
        /// Exercise 07 CountLast2
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int CountLast2(string str)
        {
            int count = 0;
            string result = str.Substring(str.Length - 2);

            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 2).Equals(result))
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Exercise 08
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int Count9(int[] numbers)
        {
            int count = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 9)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Exercise 09 ArrayFront9
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public bool ArrayFront9(int[] numbers)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                if (numbers[count] == 9)
                {
                    return true;
                }
                count++;
                if (count >= 4)
                {
                    break;
                }
            }
            return false;

        }

        /// <summary>
        /// Exercise 10 Array123
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public bool Array123(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-2; i++)
            {
                if (numbers[i] == 1 && numbers [i+1] == 2 && numbers [i+2] == 3)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Exercise 11 SubStringMatch
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int SubStringMatch(string a, string b)
        {
            int count = 0;
            int lengthOfString = 0;
            if (a.Length > b.Length)
            {
                lengthOfString = b.Length;
            }
            else lengthOfString = a.Length;

            for (int i = 0; i < lengthOfString-1; i++)
            {
                if(a.Substring(i,2)==b.Substring(i,2))
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Exercise 12 StringX
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string StringX(string str)
        {
            string newString = str.Substring(0,1);
            for (int i = 1; i < str.Length-1; i++)
            {
                if (str.Substring(i,1) != "x")
                {
                   newString += str.Substring(i,1);
                }
            }
            return newString + str.Substring(str.Length - 1);
        }

        /// <summary>
        /// Exercise 13 AltPairs
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string AltPairs(string str)
        {
            string newString = "";
            for (int i = 0; i < str.Length; i+=4)
            {
                if (i + 1 >= str.Length)
                {
                    newString += str.Substring(i, 1);
                }
               else newString += str.Substring(i, 2);
            }
            return newString;
        }

        /// <summary>
        /// Exercise 14 DoNotYak
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string DoNotYak(string str)
        {
            string newString = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i >= str.Length - 2)
                {
                    newString += str.Substring(i, 1);
                }
                else if (str.Substring(i, 1) == "y" && str.Substring(i + 2, 1) == "k")
                {
                    i += 2;
                }
                else
                {
                    newString += str.Substring(i, 1);
                }
            }
            return newString;
        }

        /// <summary>
        /// Exercise 15 Array667
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int Array667(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 6)
                {
                    if (numbers[i+1] == 6 || numbers[i+1] == 7)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        /// <summary>
        /// Exercise 16 NoTriples
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public bool NoTriples(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-2; i++)
            {
                if (numbers[i] == numbers[i + 1] && numbers[i] == numbers[i + 2])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Exercise 17 Pattern51
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public bool Pattern51(int[] numbers)
        {
            int startingValue = 2;
            int secondValue = startingValue + 5;
            int thirdValue = startingValue - 1;

            for(int i = 0; i < numbers.Length - 2; i++)
                if (numbers[i] == 2)
                {
                    if (numbers[i + 1] == 7 && numbers[i + 2] == 1)
                    {
                        return true;
                    }
                }
            return false;
        }
    }
}
