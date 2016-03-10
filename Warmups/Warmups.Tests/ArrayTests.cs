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
            Assert.AreEqual(expectedResult, actual);
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

        [TestCase(new[] { 1, 2, 3 }, new[] { 7, 3 }, true)]
        [TestCase(new[] { 1, 2, 3 }, new[] { 7, 3, 2 }, false)]
        [TestCase(new[] { 1, 2, 3 }, new[] { 1, 3 }, true)]
        public void CommonEnd_Test(int[] a, int[] b, bool expectedResult)
        {
            Arrays test = new Arrays();
            bool actual = test.CommonEnd(a, b);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(new[] { 1, 2, 3 }, 6)]
        [TestCase(new[] { 5, 11, 2 }, 18)]
        [TestCase(new[] { 7, 0, 0 }, 7)]
        public void Sum(int[] numbers, int expectedResult)
        {
            Arrays test = new Arrays();
            int actual = test.Sum(numbers);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(new[] { 1, 2, 3 }, new[] { 2, 3, 1 })]
        [TestCase(new[] { 5, 11, 9 }, new[] { 11, 9, 5 })]
        [TestCase(new[] { 7, 0, 0 }, new[] { 0, 0, 7 })]
        public void RotateLeft(int[] numbers, int[] expectedResult)
        {
            Arrays test = new Arrays();
            int[] actual = test.RotateLeft(numbers);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
        [TestCase(new[] { 2, 4, 3 }, new[] { 3, 4, 2 })]
        [TestCase(new[] { 7, 8, 9 }, new[] { 9, 8, 7 })]
        public void Reverse_Test(int[] numbers, int[] expectedResult)
        {
            Arrays test = new Arrays();
            int[] actual = test.Reverse(numbers);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(new[] { 1, 2, 3 }, new[] { 3, 3, 3 })]
        [TestCase(new[] { 11, 5, 9 }, new[] { 11, 11, 11 })]
        [TestCase(new[] { 2, 11, 3 }, new[] { 3, 3, 3 })]
        public void HigherWins_Test(int[] numbers, int[] expectedResult)
        {
            Arrays test = new Arrays();
            int[] actual = test.HigherWins(numbers);
            Assert.AreEqual(expectedResult, actual);

        }

        [TestCase(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 2, 5 })]
        [TestCase(new[] { 7, 7, 7 }, new[] { 3, 8, 0 }, new[] { 7, 8 })]
        [TestCase(new[] { 5, 2, 9 }, new[] { 1, 4, 5 }, new[] { 2, 4 })]
        public void GetMiddle_Test(int[] a, int[] b, int[] expectedResult)
        {
            Arrays test = new Arrays();
            int[] actual = test.GetMiddle(a, b);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(new[] { 2, 5 }, true)]
        [TestCase(new[] { 4, 3 }, true)]
        [TestCase(new[] { 7, 5 }, false)]
        public void HasEven_Test(int[] numbers, bool expectedResult)
        {
            Arrays test = new Arrays();
            bool actual = test.HasEven(numbers);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(new[] { 4, 5, 6 }, new[] { 0, 0, 0, 0, 0, 6 })]
        [TestCase(new[] { 1, 2 }, new[] { 0, 0, 0, 2 })]
        [TestCase(new[] { 3 }, new[] { 0, 3 })]
        public void KeepLast_Test(int[] numbers, int[] expectedResult)
        {
            Arrays test = new Arrays();
            int[] actual = test.KeepLast(numbers);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(new[] { 2, 2, 3 }, true)]
        [TestCase(new[] { 3, 4, 5, 3 }, true)]
        [TestCase(new[] { 2, 3, 2, 2 }, false)]
        public void Double23_Test(int[] numbers, bool expectedResult)
        {
            Arrays test = new Arrays();
            bool actual = test.Double23(numbers);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(new[] { 1, 2, 3 }, new[] { 1, 2, 0 })]
        [TestCase(new[] { 2, 3, 5 }, new[] { 2, 0, 5 })]
        [TestCase(new[] { 1, 2, 1 }, new[] { 1, 2, 1 })]
        public void Fix23_Test(int[] numbers, int[] expectedResult)
        {
            Arrays test = new Arrays();
            int[] actual = test.Fix23(numbers);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(new[] { 1, 3, 4, 5 }, true)]
        [TestCase(new[] { 2, 1, 3, 4, 5 }, true)]
        [TestCase(new[] { 1, 1, 1 }, false)]
        public void Unlucky1_Test(int[] numbers, bool expectedResult)
        {
            Arrays test = new Arrays();
            bool actual = test.Unlucky1(numbers);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(new[] {4, 5}, new[] {1, 2, 3}, new[] {4, 5})]
        [TestCase(new[] {4}, new[] {1, 2, 3}, new[] {4, 1})]
        [TestCase(new[] {3,4,5}, new[] {1}, new[] { 3,4})]
       [TestCase(new int []{}, new[] {1, 2}, new[] {1, 2})]
        public void Make2_Test(int[] a, int[] b, int[] expectedResult)
        {
            Arrays test = new Arrays();
            int[] actual = test.Make2(a, b);
            Assert.AreEqual(expectedResult, actual);
        }
    }
}
