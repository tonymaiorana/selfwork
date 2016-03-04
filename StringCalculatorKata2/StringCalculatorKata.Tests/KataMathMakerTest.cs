using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StringCalculatorKata2;

namespace StringCalculatorKata.Tests
{
    [TestFixture]
   public class KataMathMakerTest
    {
        private KataMathMaker _calc;

        [TestFixtureSetUp]
        public void Setup()
        {
            _calc = new KataMathMaker();
        }


        [Test]
        public void Add_EmptyString_ReturnZero()
        {
            Assert.AreEqual(0, _calc.Add(""));
        }

        [TestCase("1", 1)]
        [TestCase("17", 17)]
        public void Add_SingleNumber_ReturnNumber(string number, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _calc.Add(number));
        }

        [TestCase("1,2", 3)]
        [TestCase("4,5", 9)]
        public void Add_TwoNumbers_ReturnSum(string numbers, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _calc.Add(numbers));
        }

        [TestCase("1,2,3", 6)]
        [TestCase("9,8,7,6,5", 35)]
        public void Add_UnknownNumbers_ReturnSum(string numbers, int expectedResult)
        {
            
            Assert.AreEqual(expectedResult, _calc.Add(numbers));
        }

        [TestCase("1,2\n3", 6)]
        [TestCase("9\n8,7\n6,5", 35)]
        public void Add_NewLineSeparator_ReturnSum(string numbers, int expectedResult)
        {

            Assert.AreEqual(expectedResult, _calc.Add(numbers));
        }

        [TestCase("//;\n1;2", 3)]
        [TestCase("//|\n9|8|7|6|5", 35)]
        public void Add_SpecifySeparator_ReturnSum(string numbers, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _calc.Add(numbers));
        }

        [TestCase("-1,2", -1)]
        [TestCase("1,2,-3", -1)]
        public void Add_NegativeNumbers_ReturnNeg(string numbers, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _calc.Add(numbers));
        }

        [TestCase("1000, 2", 2)]
        [TestCase("12, 13, 2002", 25)]
        public void Add_IgnoreThousands_ReturnSum(string numbers, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _calc.Add(numbers));
        }

        [TestCase("//[***],\n1***2***3", 6)]
        [TestCase("//[|||||]\n9|||||8|||||7|||||6|||||5", 35)]
        public void Add_AnyLengthDelim_ReturnSum(string numbers, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _calc.Add(numbers));
        }

        [TestCase("//[*][%][\n1*2%3", 6)]
        [TestCase("//[|][*][@]\n1@2*7|9", 19)]
        public void Add_MultipleDelim_ReturnSum(string numbers, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _calc.Add(numbers));
        }
    }

}
