using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups
{
    public class Logic
    {

        /// <summary>
        /// Exercise 01 GreatParty
        /// </summary>
        /// <param name="cigars"></param>
        /// <param name="isWeekend"></param>
        /// <returns></returns>
        public bool GreatParty(int cigars, bool isWeekend)
        {
            if ((cigars >= 40) && (cigars <= 60) && !isWeekend)
            {
                return true;
            }

            else if ((cigars >= 40) && isWeekend)
            {
                return true;

            }
            return false;
        }

        /// <summary>
        /// Exercise 02 CanHazTable
        /// </summary>
        /// <param name="yourStyle"></param>
        /// <param name="dateStyle"></param>
        /// <returns></returns>
        public int CanHazTable(int yourStyle, int dateStyle)
        {
            int no = 0;
            int maybe = 1;
            int yes = 2;
            if ((yourStyle >= 8 || dateStyle >= 8) &&(yourStyle > 2 && dateStyle > 2))
            {
                return yes;
            }

            if (yourStyle <= 2 || dateStyle <= 2)
            {
                return no;
            }
            return maybe;
        }

        /// <summary>
        /// Exercise 03 PlayOutside
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="isSummer"></param>
        /// <returns></returns>
        public bool PlayOutside(int temp, bool isSummer)
        {
            if (temp <= 100 && temp >=60 && isSummer)
            {
                return true;
            }
            if (temp <= 90 && temp >= 60 && !isSummer)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 04 CaughtSpeeding
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="isBirthday"></param>
        /// <returns></returns>
        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            int noTicket = 0;
            int smallTicket = 1;
            int bigTicket = 2;

            if (speed > 60 && speed <= 80 && (!isBirthday))
            {
                return smallTicket;
            }
            if (speed > 80 && !isBirthday)
            {
                return bigTicket;
            }
            if ((speed >= 65) || (speed <= 85) && isBirthday)
            {
                return noTicket;
            }
            return noTicket;
        }

        /// <summary>
        /// Exercise 05 SkipSum
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int SkipSum(int a, int b)
        {
            if ((a + b >= 10) && (a + b <= 19))
            {
                return 20;
            }
            return a + b;
        }

        /// <summary>
        /// Exercise 06 AlarmClock
        /// </summary>
        /// <param name="day"></param>
        /// <param name="vacation"></param>
        /// <returns></returns>
        public string AlarmClock(int day, bool vacation)
        {
            string weekDayAlarm = "7:00";
            string weekendAlarm = "10:00";
            string vacationAlarm = "off";

            if (vacation)
            {
                return vacationAlarm;
            }

            if (day == 0 || day == 6 && !vacation)
            {
                return weekendAlarm;
            }
            return weekDayAlarm;
        }

        /// <summary>
        /// Exercise 07 LoveSix
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool LoveSix(int a, int b)
        {
            if (a == 6 || b == 6)
            {
                return true;
            }
            if ((a + b == 6) || (a - b == 6))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 08 InRange
        /// </summary>
        /// <param name="n"></param>
        /// <param name="outsideMore"></param>
        /// <returns></returns>
        public bool InRange(int n, bool outsideMore)
        {
            if (n >= 1 && n <= 10 && !outsideMore)
            {
                return true;
            }
            if (n <= 1 || n >= 10 && outsideMore)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 09 SpecialEleven
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool SpecialEleven(int n)
        {
            if (n % 11 == 0 || n % 11 == 1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 10 Mod20
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool Mod20(int n)
        {
            if (n % 20 == 1 || n % 20 == 2)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 11 Mod35
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool Mod35(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
            {
                return false;
            }
            if (n % 3 == 0 || n % 5 == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 12 AnswerCell
        /// </summary>
        /// <param name="isMorning"></param>
        /// <param name="isMom"></param>
        /// <param name="isAsleep"></param>
        /// <returns></returns>
        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (isAsleep)
            {
                return false;
            }
            if (isMorning && !isMom)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Exercise 13 TwoIsOne
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool TwoIsOne(int a, int b, int c)
        {
            if ((a + b == c) || (b + c == a) || (a + c == b))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 14 AreInOrder
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="bOk"></param>
        /// <returns></returns>
        public bool AreInOrder(int a, int b, int c, bool bOk)
        {
            if ((b > a) && (c > b) && !bOk)
            {
                return true;
            }
            if (c > b && bOk)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 15 InOrderEqual
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="equalOk"></param>
        /// <returns></returns>
        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            if (a < b && b < c && !equalOk)
            {
                return true;
            }
            if (a <= b && b <= c && equalOk)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 16 LastDigit
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool LastDigit(int a, int b, int c)
        {
            if ((a % 10 == b % 10) || (a % 10 == c % 10))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Exercise 17 RollDice
        /// </summary>
        /// <param name="die1"></param>
        /// <param name="die2"></param>
        /// <param name="noDoubles"></param>
        /// <returns></returns>
        public int RollDice(int die1, int die2, bool noDoubles)
        {
            if (noDoubles && die1 == die2)
            {
                return die1 + die2 + 1;
            }
            return die1 + die2;
        }
    }
}
