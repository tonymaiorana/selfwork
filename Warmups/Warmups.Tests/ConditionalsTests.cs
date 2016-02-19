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
    }
}
