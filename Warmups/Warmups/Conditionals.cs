using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
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
            if (isTalking && (hour < 7 || hour >= 20))
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
            if (Math.Abs(100 - n) <= 10 || (Math.Abs(200 - n) <= 10))
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
            if (negative && (a < 0 && b < 0))
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
            if (s.StartsWith("not"))
            {
                return s;
            }

            else
            {
                return "not " + s;
            }
        }

        /// <summary>
        /// Exercise 10 MissingChar
        /// </summary>
        /// <param name="str"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public string MissingChar(string str, int n)
        {
            if (str != "")
            {
                return str.Remove(n, 1);
            }
            else
                return str;

        }

        /// <summary>
        /// Exercise 11 FrontBack
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string FrontBack(string str)
        {
            if (str != "")
            {
                char[] a = str.ToArray();
                char test = a[0];
                a[0] = a[a.Length - 1];
                a[a.Length - 1] = test;
                string b = new string(a);
                return b;

            }
            else
            {
                return str;
            }
        }

        /// <summary>
        /// Exercise 12 Front3
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string Front3(string str)
        {
            if (str.Length < 3)
            {
                return str + str + str;
            }
            else if (str.Length > 3)
            {
                str = str.Substring(0, 3);
                return str + str + str;
            }
            else
            {
                return str;
            }
        }

        /// <summary>
        /// Exercise 13 BackAround
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string BackAround(string str)
        {
            if (str.Length >= 1)
            {
                char[] c = str.ToArray();
                c[0] = c[c.Length - 1];
                string aNewString = c[0].ToString() + str + c[0].ToString();
                return aNewString;
            }
            else
                return str;
        }

        /// <summary>
        /// Exercise 14 Multiple3or5
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool Multiple3or5(int number)
        {
            if ((number > 0) && (number%3 == 0) || (number%5 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Exercise 15 StartHi
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool StartHi(string str)
        {
            if (str.Length > 2 && str.StartsWith("hi "))
            {
                return true;
            }
            else if (str.Length <= 2 && str.StartsWith("hi"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Exercise 16 IcyHot
        /// </summary>
        /// <param name="temp1"></param>
        /// <param name="temp2"></param>
        /// <returns></returns>
        public bool IcyHot(int temp1, int temp2)
        {
            if ((temp1 >= 100) || (temp2 >= 100) && (temp1 <= 0 || temp2 <= 0))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 17 Between10and20
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool Between10and20(int a, int b)
        {
            if (((a <= 20) && (a >= 10)) || ((b <= 20) && (b >= 10)))
            {
                return true;
            }
            return false;

        }

        /// <summary>
        /// Exercise 18 HasTeen
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool HasTeen(int a, int b, int c)
        {
            if ((a <= 19) && (a >= 13) || (b <= 19) && (b >= 13) || (c <= 19 && (c >= 13)))
            {
                return true;
            }
            return false;
        }

        public bool SoAlone(int a, int b)
        {
            if ((a <= 19) && (a >= 13) && (b <= 19) && (b >= 13))
            {
                return false;
            }

            else if ((a <= 19) && (a >= 13) || (b <= 19) && (b >= 13))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 20 RemoveDel
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string RemoveDel(string str)
        {
            if (str.Contains("del"))
            {
                string newString = str.Remove(1, 3);
                return newString;
            }
            return str;
        }

        /// <summary>
        /// Exercise 21 IxStart
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool IxStart(string str)
        {
            if (str.Substring(1, 2).Contains("ix"))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 22 StartOz
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string StartOz(string str)
        {
            if (str.StartsWith("oz"))
            {
                string newString = str.Substring(0, 2);
                return newString;
            }

            else if (str.Substring(1, 1).Contains("z"))
            {
                string newString = "z";
                return newString;
            }

            else if (str.StartsWith("o"))
            {
                string newString = "o";
                return newString;
            }

            return str;
        }

        /// <summary>
        /// Exercise 23 Max
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public int Max(int a, int b, int c)
        {
            int max = 0;
            if ((a > b) && (a > c))
            {
                max = a;
            }

            else if ((b > a) && (b > c))
            {
                max = b;
            }

            else if ((c > a) && (c > b))
            {
                max = c;
            }
            return max;
        }

        /// <summary>
        /// Exercise 24 Closer
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Closer(int a, int b)
        {
            if (Math.Abs(10 - a) == Math.Abs(10 - b))
            {
                return 0;
            }
            if ((a - 10) < (b - 10))
            {
                return a;
            }

            return b;
        }

        /// <summary>
        /// Exercise 25 GotE
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool GotE(string str)
        {
            int i = 0;
            foreach (char c in str)
            {
                if (c == 'e')
                {
                    i++;
                }
            }
            if (i >= 1 && i <= 3)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 26 EndUp
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string EndUp(string str)
        {
            if (str.Length > 3)
            {
                return str.Substring(0, str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
            }
            return str.ToUpper();
        }

        /// <summary>
        /// Exercise 27 EveryNth
        /// </summary>
        /// <param name="str"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public string EveryNth(string str, int n)
        {
            string newString = "";
            if (str != "")
            {
                for (int i = 0; i < str.Length; i += n)
                {
                    newString += str.Substring(i, 1);
                }
                return newString;
            }
            return str;
        }
    }
}
