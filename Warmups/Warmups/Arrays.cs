using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// Exercise 02 MakePi
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

        //public int Sum(int[] numbers)
        //{
        //    var sum = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        sum = numbers[i];
        //    }
        //    return;
        //}

    }
}
