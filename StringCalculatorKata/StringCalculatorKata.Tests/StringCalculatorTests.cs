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
        public StringCalculatorKata _calc;

        [TestFixtureSetUp]
        public void BeforeTesting()
        {
            _calc = new StringCalculatorKata();
            Console.WriteLine("Setup Called...");
        }

        [Test]
        public void Add_EmptyString_ReturnZero()
        { 
            Assert.AreEqual(0,_calc.Add(""));
        }

        [TestCase("1",1)]
        [TestCase("11", 11)]
        public void Add_OneNumber_ReturnSelf(string numbers, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _calc.Add(numbers));
        }

        [TestCase("1,2", 3)]
        [TestCase("3,5", 8)]
        public void Add_TwoNumbers_ReturnSum(string numbers, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _calc.Add(numbers));
        }

        [TestCase("1,2,3,4", 10)]
        public void Add_UnknownNumbers_Return_Sum(string numbers, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _calc.Add(numbers));
        }

        [TestCase("1\n2,3", 6)]
        public void Add_MultipleDelimeters_ReturnSum(string numbers, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _calc.Add(numbers));
        }

        [TestCase("//;\n1;2", 3)]
        public void Add_SpecifyDelimeter_ReturnSum(string numbers, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _calc.Add(numbers));
        }

    }
}
