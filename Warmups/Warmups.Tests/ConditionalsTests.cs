using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.Tests
{
    [TestFixture]
    public class ConditionalsTests
    {
        [TestCase(true, true, true)]
        [TestCase(true, false, false)]
        [TestCase(false, false, true)]
        public void AreWeInTrouble_Tests(bool aSmile, bool bSmile, bool expectedResult)
        {
            Conditionals cond = new Conditionals();
            //Creates Object from class Conditionals calling it cond, which creates a new instance of Conditionals

            Assert.AreEqual(expectedResult, cond.AreWeInTrouble(aSmile, bSmile));
            //Assert.AreEqual is NUnit method "cond." is method call of our object
        }

        [TestCase(1, 2, 3)]
        [TestCase(2, 2, 8)]
        public void SumDouble_Tests(int a, int b, int expectedResult)
        {
            Conditionals cond = new Conditionals();
            int actual = cond.SumDouble(a, b);
            Assert.AreEqual(expectedResult, actual);

        }

        [TestCase(23, 4)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]
        public void Diff21_Tests(int n, int expectedResult)
        {
            Conditionals cond = new Conditionals();
            int actual = cond.Diff21(n);
            Assert.AreEqual(expectedResult, actual);


        }
        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]
        public void parrotTrouble_Tests(bool isTalking, int hour, bool expectedResult)
        {
            Conditionals cond = new Conditionals();
            bool actual = cond.ParrotTrouble(isTalking, hour);
            Assert.AreEqual(expectedResult, actual);


        }

        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]
        [TestCase(true, true, true)]
        public void CanSleepIn_Tests(bool isWeekday, bool isVacation, bool expectedResult)
        {
            Conditionals cond = new Conditionals();
            bool actual = cond.CanSleepIn(isWeekday, isVacation);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(9, 10, true)]
        [TestCase(9, 9, false)]
        [TestCase(1, 9, true)]
        public void Makes10_Test(int a, int b, bool expectedResult)
        {
            Conditionals cond = new Conditionals();
            bool actual = cond.Makes10(a, b);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(103, true)]
        [TestCase(90, true)]
        [TestCase(89, false)]
        [TestCase(209, true)]
        [TestCase(189, false)]
        public void NearHundred_Test(int n, bool expectedResult)
        {
            Conditionals cond = new Conditionals();
            bool actual = cond.NearHundred(n);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase(1, -1, false, true)]
        [TestCase(-1, 1, false, true)]
        [TestCase(-4, -5, true, true)]
        [TestCase(-4, -5, false, false)]
        public void PosNeg_Test(int a, int b, bool negative, bool expectedResult)
        {
            Conditionals cond = new Conditionals();
            bool actual = cond.PosNeg(a, b, negative);
            Assert.AreEqual(actual, expectedResult);
        }

        [TestCase("candy", "not candy")]
        [TestCase("x", "not x")]
        [TestCase("not bad", "not bad")]
        public void NotString_Test(string s, string expectedResult)
        {
            Conditionals cond = new Conditionals();
            string actual = cond.NotString(s);
            Assert.AreEqual(expectedResult, actual);

        }
    }
}
