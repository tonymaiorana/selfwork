using System;
using System.Collections.Generic;
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
           
       }
    }
}
