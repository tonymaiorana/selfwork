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

        /// <summary>
        /// Exercise 06 Makes10
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool Makes10(int a, int b)
        {
            if ((a == 10) || (b == 10) || (a + b == 10))
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// Exercise 07 NearHundred
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool NearHundred(int n)
        {
            if(Math.Abs(100-n)<=10 || (Math.Abs(200-n)<=10))
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// Exercise 08 PosNeg
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="negative"></param>
        /// <returns></returns>
        /// 
        public bool PosNeg(int a, int b, bool negative)
        {
            if(negative &&(a  < 0 && b < 0))
            {
                return true;
            }
            else if (!negative && (a < 0) ^ (b < 0))
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// Exercise 09 NotString
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string NotString(string s)
        {
            if(s.StartsWith("not"))
            {
                return s;
            }

            else
            {
                return  "not "+ s;
            }
        }
    }
}
