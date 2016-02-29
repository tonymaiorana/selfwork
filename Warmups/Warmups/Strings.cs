﻿using System;
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
            return "<"+ tag + ">" + content + "</" + tag + ">";
        }

        /// <summary>
        /// Exercise 04 InsertWord
        /// </summary>
        /// <param name="container"></param>
        /// <param name="word"></param>
        /// <returns></returns>
       public string InsertWord(string container, string word)
        {
            return container.Substring(0, 2) + word + container.Substring(2,2);
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
            return str.Substring(0, str.Length/2);
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
           return newString + str.Substring(0,str.Length - 2);
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
            if ()
            {
                
            }
       }
    }
}
