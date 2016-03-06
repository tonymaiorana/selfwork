using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Warmups.Tests
{
    [TestFixture]
    class LogicTests
    {
        [TestCase(30, false, false)]
        [TestCase(50, false, true)]
        [TestCase(70, true, true)]
        public void GreatParty_Test(int cigars, bool IsWeekend, bool expectedResult)
        {
            Logic test = new Logic();
            bool actual = test.GreatParty(cigars, IsWeekend);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(5, 10, 2)]
        [TestCase(5, 2, 0)]
        [TestCase(5, 5, 1)]
        public void CanHazTable_Test(int yourStyle, int dateStyle, int expectedResult)
        {
            Logic test = new Logic();
            int actual = test.CanHazTable(yourStyle, dateStyle);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(70, false, true)]
        [TestCase(95, false, false)]
        [TestCase(95, true, true)]
        public void PlayOutside_Test(int temp, bool isSummer, bool expectedResult)
        {
            Logic test = new Logic();
            bool actual = test.PlayOutside(temp, isSummer);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(60, false, 0)]
        [TestCase(65, false, 1)]
        [TestCase(65, true, 0)]
        public void CaughtSpeeding_Test(int speed, bool isBirthday, int expectedResult)
        {
            Logic test = new Logic();
            int actual = test.CaughtSpeeding(speed, isBirthday);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(3, 4, 7)]
        [TestCase(9, 4, 20)]
        [TestCase(10, 11, 21)]
        public void SkipSum_Test(int a, int b, int expectedResult)
        {
            Logic test = new Logic();
            int actual = test.SkipSum(a, b);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(1, false, "7:00")]
        [TestCase(5, false, "7:00")]
        [TestCase(0, false, "10:00")]
        [TestCase(0, true, "off")]
        public void AlarmClock_Test(int day, bool vacation, string expectedResult)
        {
            Logic test = new Logic();
            string actual = test.AlarmClock(day, vacation);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(6, 4, true)]
        [TestCase(4, 5, false)]
        [TestCase(1, 5, true)]
        public void LoveSix_Test(int a, int b, bool expectedResult)
        {
            Logic test = new Logic();
            bool actual = test.LoveSix(a, b);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(5, false, true)]
        [TestCase(11, false, false)]
        [TestCase(11, true, true)]
        public void InRange_Test(int n, bool outsideMore, bool expectedResult)
        {
            Logic test = new Logic();
            bool actual = test.InRange(n, outsideMore);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(22, true)]
        [TestCase(23, true)]
        [TestCase(24, false)]
        public void SpecialEleven_Test(int n, bool expectedResult)
        {
            Logic test = new Logic();
            bool actual = test.SpecialEleven(n);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(20, false)]
        [TestCase(21, true)]
        [TestCase(22, true)]
        public void Mod20_Test(int n, bool expectedResult)
        {
            Logic test = new Logic();
            bool actual = test.Mod20(n);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(15, false)]
        public void Mod35_Test(int n, bool expectedResult)
        {
            Logic test = new Logic();
            bool actual = test.Mod35(n);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(false, false, false, true)]
        [TestCase(false, false, true, false)]
        [TestCase(true, false, false, false)]
        public void AnswerCell_Test(bool isMorning, bool isMom, bool isAsleep, bool expectedResult)
        {
            Logic test = new Logic();
            bool actual = test.AnswerCell(isMorning, isMom, isAsleep);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(1, 2, 3, true)]
        [TestCase(3, 1, 2, true)]
        [TestCase(3, 2, 2, false)]
        public void TwoIsOne_Test(int a, int b, int c, bool expectedResult)
        {
            Logic test = new Logic();
            bool actual = test.TwoIsOne(a, b, c);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(1, 2, 4, false, true)]
        [TestCase(1, 2, 1, false, false)]
        [TestCase(1, 1, 2, true, true)]
        public void AreInOrder_Test(int a, int b, int c, bool bOk, bool expectedResult)
        {
            Logic test = new Logic();
            bool actual = test.AreInOrder(a, b, c, bOk);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(2, 5, 11, false, true)]
        [TestCase(5, 7, 6, false, false)]
        [TestCase(5, 5, 7, true, true)]
        public void InOrderEqual_Test(int a, int b, int c, bool equalOK, bool expectedResult)
        {
            Logic test = new Logic();
            bool actual = test.InOrderEqual(a, b, c, equalOK);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(23, 19, 13, true)]
        [TestCase(23, 19, 13, true)]
        [TestCase(23, 19, 13, true)]
        public void LastDigit_Test(int a, int b, int c, bool expectedResult)
        {
            Logic test = new Logic();
            bool actual = test.LastDigit(a,b,c);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(2, 3, true, 5)]
        [TestCase(3, 3, true, 7)]
        [TestCase(3, 3, false, 6)]
        [TestCase(4,4,true,9)]
        public void RollDice_Test(int die1, int die2, bool noDoubles, int expectedResult)
        {
            Logic test = new Logic();
            int actual = test.RollDice(die1, die2, noDoubles);
            Assert.AreEqual(expectedResult, actual);
        }
    }
}
