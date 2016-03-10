using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Warmups
{
    public class Arrays
    {
        /// <summary>
        /// Exercise 01 FirstLast6
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public bool FirstLast6(int[] numbers)
        {
            if (numbers[0] == 6 || numbers[numbers.Length-1] == 6)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 02 SameFirstLast
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public bool SameFirstLast(int[] numbers)
        {
            if (numbers.Length >= 1)
            {
                if (numbers[0] == numbers[numbers.Length - 1])
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Exercise 03 MakePi
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        //public int[] MakePi(int n)
        //{

        //}

        
        public bool CommonEnd(int[] a, int[] b)
        {
            if (a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1])
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 05 Sum
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int Sum(int[] numbers)
        {
            int total = 0;
            foreach(int number in numbers)
            {
              total += number;
            }
            return total;
        }

        /// <summary>
        /// Exercise 06 RotateLeft
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int[] RotateLeft(int[] numbers)
        {
            int i = numbers [0];
            for (int j = 0 ; j < numbers.Length-1; j++)
            {
                numbers[j] = numbers[j + 1];
            }
            numbers[numbers.Length - 1] = i;
            return numbers;

        }

        /// <summary>
        /// Exercise 07 Reverse
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int[] Reverse(int[] numbers)
        {
            int[] arr = new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                arr[i] = numbers [numbers.Length - 1 - i];
            }
            return arr;
        }

        /// <summary>
        /// Exercise 08 HigherWins
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int[] HigherWins(int[] numbers)
        {
            int greaterValue;
            if (numbers[0] > numbers[numbers.Length - 1])
            {
                greaterValue = numbers[0];
            }
            else
            {
                greaterValue = numbers[numbers.Length-1];
            }
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = greaterValue;
            }
            return numbers;
        }

        /// <summary>
        /// Exercise 09 GetMiddle
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] newArray = new int[2];

            newArray[0] = a[1];
            newArray[1] = b[1];
            return newArray;
        }

        /// <summary>
        /// Exercise 10 HasEven
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public bool HasEven(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Exercise 11 KeepLast
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int[] KeepLast(int[] numbers)
        {
            int[] newArray = new int[numbers.Length*2];
            newArray[newArray.Length - 1] = numbers[numbers.Length - 1];
            return newArray;

        }


        public bool Double23(int[] numbers)
        {
            int count2 = 0;
            int count3 = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == 2)
                    {
                        count2++;
                    }
                    else if (numbers[i] == 3)
                    {
                        count3++;
                    }
                }

            if (count2 == 2 || count3 == 2)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 13 Fix23
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int[] Fix23(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 2 && numbers[i + 1] == 3)
                {
                    numbers[i + 1] = 0;
                }
            }
            return numbers;
        }

        /// <summary>
        /// Exercise 14 Unlucky1
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public bool Unlucky1(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 3)
                {
                    if (i == 0 || i == 1 || i == numbers.Length - 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Exercise 15 Make2
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int[] Make2(int[] a, int[] b)
        {
            int[] newArray = new int[2];
            if (a.Length >= 2)
            {
                newArray[0] = a[0];
                newArray[1] = a[1];
                return newArray;
            }
            else if (a.Length < 2)
            {
                newArray[0] = a[0];
                newArray[1] = b[0];
                return newArray;
            }
            return newArray;
        }

    }
}
