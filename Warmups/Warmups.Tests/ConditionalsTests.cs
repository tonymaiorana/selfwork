using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
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
            Conditionals cond = new Conditionals(); //Creates Object from class Conditionals calling it cond, which creates a new instance of Conditionals

            Assert.AreEqual(expectedResult, cond.AreWeInTrouble(aSmile, bSmile)); //Assert.AreEqual is NUnit method "cond." is method call of our object
        }

    }
}
