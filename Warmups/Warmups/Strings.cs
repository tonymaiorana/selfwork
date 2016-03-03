using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups
{
    public class Strings
    {
        /// <summary>
        /// Exercise 01 SayHi
        /// </summary>
        /// <param name="name"></param>
        /// <param name=""></param>
        /// <returns></returns>

        public string SayHi(string name)
        {
            return "Hello " + name + "!";
        }

        /// <summary>
        /// Exercise 02 Abba
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string Abba(string a, string b)
        {
            return a + b + b + a;
        }

        /// <summary>
        /// Exercise 03 MakeTags
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public string MakeTag(string tag, string content)
        {
            return "<" + tag + ">" + content + "</" + tag + ">";
        }

        /// <summary>
        /// Exercise 04 InsertWord
        /// </summary>
        /// <param name="container"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public string InsertWord(string container, string word)
        {
            return container.Substring(0, 2) + word + container.Substring(2, 2);
        }

        /// <summary>
        /// Exercise 05 MultipleEndings
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string MultipleEndings(string str)
        {
            return str.Substring(str.Length - 2) + str.Substring(str.Length - 2) + str.Substring(str.Length - 2);
        }

        /// <summary>
        /// Exercise 06 FirstHalf
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string FirstHalf(string str)
        {
            return str.Substring(0, str.Length / 2);
        }

        /// <summary>
        /// Exercise 07 TrimOne
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string TrimOne(string str)
        {
            return str.Substring(1, str.Length - 2);
        }

        /// <summary>
        /// Exercise 08 LongInMiddle
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string LonginMiddle(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return b + a + b;
            }
            return a + b + a;
        }

        /// <summary>
        /// Exercise 09 RotateLeft2
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string RotateLeft2(string str)
        {
            string newString = str.Substring(0, 2);
            return str.Substring(2) + newString;
        }

        /// <summary>
        /// Exercise 10 RotateRight2
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string RotateRight2(string str)
        {
            string newString = str.Substring(str.Length - 2);
            return newString + str.Substring(0, str.Length - 2);
        }

        /// <summary>
        ///Exercise 11 TakeOne 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="fromFront"></param>
        /// <returns></returns>
        public string TakeOne(string str, bool fromFront)
        {
            if (fromFront == false)
            {
                return str.Substring(str.Length - 1);
            }
            return str.Substring(0, 1);
        }

        /// <summary>
        /// Exercise 12 MiddleTwo
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string MiddleTwo(string str)
        {
            if (str.Length % 2 == 0)
            {
                string newString = str.Substring(str.Length / 2 - 1, 2);
                return newString;

            }
            return str;
        }

        /// <summary>
        /// Exercise 13 EndsWithLy
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool EndsWithLy(string str)
        {
            if (str.EndsWith("ly"))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 14 FrontAndBack
        /// </summary>
        /// <param name="str"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public string FrontAndBack(string str, int n)
        {
            return str.Substring(0, n) + str.Substring(str.Length - n);
        }

        /// <summary>
        /// Exercise 15 TakeTwoFromPosition
        /// </summary>
        public string TakeTwoFromPosition(string str, int n)
        {
            if (n <= str.Length - n)
            {
                return str.Substring(n, 2);
            }
            else if (n > str.Length - n)
            {
                return str.Substring(0, 2);
            }
            return str;

        }

        /// <summary>
        /// Exercise 16 HasBad
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool HasBad(string str)
        {
            if (str.Substring(0, 3).Contains("bad") || str.Substring(1, 3).Contains("bad"))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 17 AtFirst
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string AtFirst(string str)
        {
            if (str.Length >= 2)
            {
                return str.Substring(0, 2);
            }
            return str + "@";
        }

        /// <summary>
        /// Exercise 18 LastChars
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string LastChars(string a, string b)
        {
            if (a.Length == 0)
            {
                return b.Substring(0, 1) + "@";
            }
            if (b.Length == 0)
            {
                return a.Substring(0, 1) + "@";
            }
            return a.Substring(0, 1) + b.Substring(b.Length - 1, 1);
        }

        /// <summary>
        /// Exercise 19 ConCat
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string ConCat(string a, string b)
        {
            if (a != "" && b != "")
            {
                if (a.EndsWith(b.Substring(0, 1)))
                {
                    return a + b.Remove(0, 1);
                }
            }
            return a + b;
        }

        /// <summary>
        /// Exercise 20 SwapLast
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string SwapLast(string str)
        {
            return str.Substring(0, str.Length - 2) + str.Substring(str.Length - 1, 1) +
                   str.Substring(str.Length - 2, 1);
        }

        /// <summary>
        /// Exercise 21 FrontAgain
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool FrontAgain(string str)
        {
            if (str.Substring(0, 2) == (str.Substring(str.Length - 2)))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 22 MinCat
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string MinCat(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return a.Substring(a.Length - b.Length) + b;
            }

            else if (a.Length < b.Length)
            {
                return a + b.Substring(b.Length - a.Length);
            }
            return a + b;
        }

        /// <summary>
        /// Exercise 23 TweakFront
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string TweakFront(string str)
        {
            if (!str.Substring(1, 1).Contains("b"))
            {
                str = str.Remove(1, 1);
            }
            
            if (!str.StartsWith("a"))
            {
                str = str.Remove(0, 1);
            }

            return str;
        }

        /// <summary>
        /// Exercise 24 StripX
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string StripX(string str)
        {
            if (str.StartsWith("x") && str.EndsWith("x"))
            {
                return str.Substring(1, str.Length - 2);
            }
            if (str.StartsWith("x"))
            {
                return str.Substring(1);
            }
            else if (str.EndsWith("x"))
            {
                return str.Substring(0, str.Length - 1);
            }
            return str;
        }


    }
}
