using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups
{
    public class Conditionals
    {
        /// <summary>
        /// Exercise 1 - MischeviousChildren
        /// </summary>
        /// <param name="ASmile"></param>
        /// <param name="bSmile"></param>
        /// <returns></returns>
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if (aSmile == bSmile)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        /// <summary>
        /// Exercise 2 SleepingIn
        /// </summary>
        /// <param name="isWeekday"></param>
        /// <param name="isVacation"></param>
        /// <returns></returns>
        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            if (isWeekday && !isVacation)
            {
                return false;
            }

            return true;
        }
        /// <summary>
        /// Exercise 3 SumDouble
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int SumDouble(int a, int b)
        {
            if (a == b)
            {
                return (a + b)*2;

            }
  
                return a + b;
        }
        /// <summary>
        /// Exercise 4 Diff21
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Diff21(int n)
        {
            if (n <= 21)
            {
              return Math.Abs(n - 21);
            }

            return Math.Abs(n - 21)*2;
        }
        /// <summary>
        /// Exercise 5 ParrotTrouble
        /// </summary>
        /// <param name="isTalking"></param>
        /// <param name="hour"></param>
        /// <returns></returns>
        public bool ParrotTrouble(bool isTalking, int hour)
        {
            if(isTalking && (hour < 7 || hour >= 20))
            {
                return true;
            }

            return false;
        }
    }
}
