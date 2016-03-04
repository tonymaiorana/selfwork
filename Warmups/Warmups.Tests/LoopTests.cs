using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
