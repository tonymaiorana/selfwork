using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringCalculatorKata.Tests
{
    [TestFixture]
   public class StringCalculatorTests
    {
        [Test]
        public void Add_EmptyString_ReturnZero()
        {
            StringCalculatorKata calc = new StringCalculatorKata();

            Assert.AreEqual(0,calc.Add(""));

        }

        [Test]
        public void Add_OneString_ReturnInt()
        {
            StringCalculatorKata calc = new StringCalculatorKata();

            Assert.AreEqual(3, calc.Add("3"));

        }
    }
}
