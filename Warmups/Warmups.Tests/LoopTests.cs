using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Warmups.Tests
{
    [TestFixture]
    public class LoopTests
    {
        [TestCase("Hi", 2, "HiHi")]
        [TestCase("Hi", 3, "HiHiHi")]
        [TestCase("Hi", 1, "Hi")]
        public void StringTimes_Test(string str, int n, string expectedResult)
        {
            Loops trial = new Loops();
            string actual = trial.StringTimes(str, n);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Chocolate", 2, "ChoCho")]
        [TestCase("Chocolate", 3, "ChoChoCho")]
        [TestCase("Abc", 3, "AbcAbcAbc")]
        public void FrontTimes_Test(string str, int n, string expectedResult)
        {
            Loops trial = new Loops();
            string actual = trial.FrontTimes(str, n);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("abcxx", 1)]
        [TestCase("xxx", 2)]
        [TestCase("xxxx", 3)]
        public void CountXX_Test(string str, int expectedResult)
        {
            Loops trial = new Loops();
            int actual = trial.CountXX(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("axxbb", true)]
        [TestCase("axaxxax", false)]
        [TestCase("xxxxx", true)]
        public void DoubleX_Test(string str, bool expectedResult)
        {
            Loops trial = new Loops();
            bool actual = trial.DoubleX(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Hello", "Hlo")]
        [TestCase("Hi", "H")]
        [TestCase("Heeololeo", "Hello")]
        public void EveryOther_Test(string str, string expectedResult)
        {
            Loops trial = new Loops();
            string actual = trial.EveryOther(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Code", "CCoCodCode")]
        [TestCase("abc", "aababc")]
        [TestCase("ab", "aab")]
        public void StringSplosion_Test(string str, string expectedResult)
        {
            Loops trial = new Loops();
            string actual = trial.StringSplosion(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("hixxhi", 1)]
        [TestCase("xaxxaxaxx", 1)]
        [TestCase("axxxaxx", 2)]
        public void CountLast2_Test(string str, int expectedResult)
        {
            Loops trial = new Loops();
            int actual = trial.CountLast2(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(new[] {1, 2, 9}, 1)]
        [TestCase(new[] {1, 9, 9}, 2)]
        [TestCase(new[] {1, 9, 9, 3, 9}, 3)]
        public void Count9_Test(int[] numbers, int expectedResult)
        {
            Loops trial = new Loops();
            int actual = trial.Count9(numbers);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(new[] {1, 2, 9, 3, 4}, true)]
        [TestCase(new[] {1, 2, 3, 4, 9}, false)]
        [TestCase(new[] {1, 2, 3, 4, 5}, false)]
        public void ArrayFront9_Test(int[] numbers, bool expectedResult)
        {
            Loops trial = new Loops();
            bool actual = trial.ArrayFront9(numbers);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(new[] {1, 1, 2, 3, 1}, true)]
        [TestCase(new[] {1, 1, 2, 4, 1}, false)]
        [TestCase(new[] {1, 1, 2, 1, 2, 3}, true)]
        public void Array123_Test(int[] numbers, bool expectedResult)
        {
            Loops trial = new Loops();
            bool actual = trial.Array123(numbers);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("xxcaazz", "xxbaaz", 3)]
        [TestCase("abc", "abc", 2)]
        [TestCase("abc", "axc", 0)]
        public void SubStringMatch_Test(string a, string b, int expectedResult)
        {
            Loops trial = new Loops();
            int actual = trial.SubStringMatch(a, b);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("xxHxix", "xHix")]
        [TestCase("abxxxcd", "abcd")]
        [TestCase("xabxxxcdx", "xabcdx")]
        public void StringX_Test(string str, string expectedResult)
        {
            Loops trial = new Loops();
            string actual = trial.StringX(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("kitten", "kien")]
        [TestCase("Chocolate", "Chole")]
        [TestCase("CodingHorror", "Congrr")]
        public void AltPairs_Test(string str, string expectedResult)
        {
            Loops trial = new Loops();
            string actual = trial.AltPairs(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("yakpak", "pak")]
        [TestCase("pakyak", "pak")]
        [TestCase("yak123ya", "123ya")]
        public void DoNotYak_Test(string str, string expectedResult)
        {
            Loops trial = new Loops();
            string actual = trial.DoNotYak(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(new[] {6, 6, 2}, 1)]
        [TestCase(new[] {6, 6, 2, 6}, 1)]
        [TestCase(new[] {6, 7, 2, 6}, 1)]
        public void Array667_Test(int[] numbers, int expectedResult)
        {
            Loops trial = new Loops();
            int actual = trial.Array667(numbers);
            Assert.AreEqual(expectedResult, actual);

        }

        [TestCase(new[] {1, 1, 2, 2, 1}, true)]
        [TestCase(new[] {1, 1, 2, 2, 2, 1}, false)]
        [TestCase(new[] {1, 1, 1, 2, 2, 2, 1}, false)]
        public void NoTriples_Test(int[] numbers, bool expectedResult)
        {
            Loops trial = new Loops();
            bool actual = trial.NoTriples(numbers);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(new[] {1, 2, 7, 1}, true)]
        [TestCase(new[] {1, 2, 8, 1}, false)]
        [TestCase(new[] {2, 7, 1}, true)]
        public void Pattern51_Test(int[] numbers, bool expectedResult)
        {
            Loops trial = new Loops();
            bool actual = trial.Pattern51(numbers);
            Assert.AreEqual(expectedResult, actual);
        }

    }
}
