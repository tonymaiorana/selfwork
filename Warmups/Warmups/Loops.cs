using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
            string newString = "";
            for (int i = 0; i < str.Length-1; i+++)
            {
                newString = str.Substring(i, 1);

                for (newString)
                {
                    str.Remove(1, 1);
                }
            }
            return newString;
        }
    }
}
