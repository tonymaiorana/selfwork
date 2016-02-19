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
    }
}
