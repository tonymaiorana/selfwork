using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Warmups.Tests
{
    [TestFixture]
    public class ArrayTests
    {
        [TestCase(new[] { 1, 2, 6 }, true)]
        [TestCase(new[] { 6, 1, 2, 3 }, true)]
        [TestCase(new[] { 13, 6, 1, 2, 3 }, false)]
        public void FirstLast6_Test(int[] numbers, bool expectedResult)
        {
            Arrays test = new Arrays();
            bool actual = test.FirstLast6(numbers);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(new[] { 1, 2, 3 }, false)]
        [TestCase(new[] { 1, 2, 3, 1 }, true)]
        [TestCase(new[] { 1, 2, 1 }, true)]
        public void SameFirstLast_Test(int[] numbers, bool expectedResult)
        {
            Arrays test = new Arrays();
            bool actual = test.SameFirstLast(numbers);
            Assert.AreEqual(expectedResult,actual);
        }

        //[TestCase(3, new[] {3, 1, 4})]
        //[TestCase(4, new[] {3, 1, 4, 1})]
        //[TestCase(6, new[] {3, 1, 4, 1, 5, 9})]
        //public void MakePi_Test(int n, int[] expectedResult)
        //{
        //    Arrays test = new Arrays();
        //    int[] actual = test.MakePi(n);
        //    Assert.AreEqual(expectedResult, actual);
        //}

        [TestCase(new[] {1, 2, 3}, new[] {7, 3}, true)]
        [TestCase(new[] {1, 2, 3}, new[] {7, 3, 2}, false)]
        [TestCase(new[] {1, 2, 3}, new[] {1, 3}, true)]
        public void CommonEnd_Test(int[] a, int[] b, bool expectedResult)
        {
            Arrays test = new Arrays();
            bool actual = test.CommonEnd(a, b);
            Assert.AreEqual(expectedResult, actual);
        }

        //[TestCase(new[] {1, 2, 3}, 6)]
        //[TestCase(new[] {5, 11, 2}, 18)]
        //[TestCase(new[] {7, 0, 0}, 7)]
        //public void Sum(int[] numbers, int expectedResult)
        //{
        //    Arrays test = new Arrays();
        //    int actual = test.Sum(numbers);
        //    Assert.AreEqual(expectedResult, actual);
        //}
    }
}
