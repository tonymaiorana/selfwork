using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
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

        [TestCase("kitten", 1, "ktten")]
        [TestCase("kitten", 0, "itten")]
        [TestCase("kitten", 4, "kittn")]
        public void MissingChar_Test(string str, int n, string expectedResult)
        {
            Conditionals cond = new Conditionals();
            string actual = cond.MissingChar(str, n);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("code", "eodc")]
        [TestCase("a", "a")]
        [TestCase("ab", "ba")]
        public void FrontBack_Test(string str, string expectedResult)
        {
            Conditionals cond = new Conditionals();
            string actual = cond.FrontBack(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Microsoft", "MicMicMic")]
        [TestCase("Chocolate", "ChoChoCho")]
        [TestCase("at", "atatat")]
        public void Front3_Test(string str, string expectedResult)
        {
            Conditionals cond = new Conditionals();
            string actual = cond.Front3(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("cat", "tcatt")]
        [TestCase("Hello", "oHelloo")]
        [TestCase("a", "aaa")]
        public void BackAround_Test(string str, string expectedResult)
        {
            Conditionals cond = new Conditionals();
            string actual = cond.BackAround(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(8, false)]
        public void Multiple3or5_Test(int number, bool expectedResult)
        {
            Conditionals cond = new Conditionals();
            bool actual = cond.Multiple3or5(number);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("hi there", true)]
        [TestCase("hi", true)]
        [TestCase("high up", false)]
        public void StartHi_Test(string str, bool expectedResult)
        {
            Conditionals cond = new Conditionals();
            bool actual = cond.StartHi(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(120, -1, true)]
        [TestCase(-1, 120, true)]
        [TestCase(2, 120, false)]
        public void IcyHot_Test(int temp1, int temp2, bool expectedResult)
        
        {
            Conditionals cond = new Conditionals();
            bool actual = cond.IcyHot(temp1, temp2);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(12, 99, true)]
        [TestCase(21, 12, true)]
        [TestCase(8, 99, false)]
        public void Between10and20_Test(int a, int b, bool expectedResult)
        {
            Conditionals cond = new Conditionals();
            bool actual = cond.Between10and20(a, b);
            Assert.AreEqual(expectedResult, actual);

        }

        [TestCase(13, 20, 10, true)]
        [TestCase(20, 19, 10, true)]
        [TestCase(20, 10, 12, false)]
        public void HasTeen_Test(int a, int b, int c, bool expectedResult)
        {
            Conditionals cond = new Conditionals();
            bool actual = cond.HasTeen(a, b, c);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(13, 99, true)]
        [TestCase(21, 19, true)]
        [TestCase(13, 13, false)]
        public void SoAlone_Test(int a, int b, bool expectedResult)
        {
            Conditionals cond = new Conditionals();
            bool actual = cond.SoAlone(a, b);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("adelbc", "abc")]
        [TestCase("adelHello", "aHello")]
        [TestCase("adedbc", "adedbc")]
        public void RemoveDel_Test(string str, string expectedResult)
        {
            Conditionals cond = new Conditionals();
            string actual = cond.RemoveDel(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("mix snacks", true)]
        [TestCase("pix snacks", true)]
        [TestCase("piz snacks", false)]
        public void IxStart_Test(string str, bool expectedResult)
        {
            Conditionals cond = new Conditionals();
            bool actual = cond.IxStart(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("ozymandias", "oz")]
        [TestCase("bzoo", "z")]
        [TestCase("oxx", "o")]
        public void StartOz_Test(string str, string expectedResult)
        {
            Conditionals cond = new Conditionals();
            string actual = cond.StartOz(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(1, 2, 3, 3)]
        [TestCase(1, 3, 2, 3)]
        [TestCase(3, 2, 1, 3)]
        public void Max_Test(int a, int b, int c, int expectedResult)
        {
            Conditionals cond = new Conditionals();
            int actual = cond.Max(a, b, c);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(8, 13, 8)]
        [TestCase(13, 8, 8)]
        [TestCase(13, 7, 0)]
        public void Closer_Test(int a, int b, int expectedResult)
        {
            Conditionals cond = new Conditionals();
            int actual = cond.Closer(a, b);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Hello", true)]
        [TestCase("Heelle", true)]
        [TestCase("Heelele", false)]
        public void GotE_Test(string str, bool expectedResult)
        {
            Conditionals cond = new Conditionals();
            bool actual = cond.GotE(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Hello", "HeLLO")]
        [TestCase("hi there", "hi thERE")]
        [TestCase("hi", "HI")]
        public void EndUp_Tests(string str, string expectedResult)
        {
            Conditionals cond = new Conditionals();
            string actual = cond.EndUp(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Miracle", 2, "Mrce")]
        [TestCase("abcdefg", 2, "aceg")]
        [TestCase("abcdefg", 3, "adg")]
        public void EveryNth(string str, int n, string expectedResult)
        {
            Conditionals cond = new Conditionals();
            string actual = cond.EveryNth(str, n);
            Assert.AreEqual(expectedResult, actual);
        }
        
    }
}
