using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Warmups.Tests
{
    public class StringsTests
    {
        [TestCase("Bob", "Hello Bob!")]
        [TestCase("Alice", "Hello Alice!")]
        [TestCase("X", "Hello X!")]
        public void SayHi_Test(string name, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.SayHi(name);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Hi", "Bye", "HiByeByeHi")]
        [TestCase("Yo", "Alice", "YoAliceAliceYo")]
        [TestCase("What", "Up", "WhatUpUpWhat")]
        public void Abba_Test(string a, string b, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.Abba(a, b);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("i", "Yay", "<i>Yay</i>")]
        [TestCase("i", "Hello", "<i>Hello</i>")]
        [TestCase("cite", "Yay", "<cite>Yay</cite>")]
        public void MakeTags_Test(string tag, string content, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.MakeTag(tag, content);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("<<>>", "Yay", "<<Yay>>")]
        [TestCase("<<>>", "WooHoo", "<<WooHoo>>")]
        [TestCase("[[]]", "word", "[[word]]")]
        public void InsertWord_Test(string container, string word, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.InsertWord(container, word);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Hello", "lololo")]
        [TestCase("ab", "ababab")]
        [TestCase("Hi", "HiHiHi")]
        public void MultipleEndings_Test(string str, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.MultipleEndings(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("WooHoo", "Woo")]
        [TestCase("HelloThere", "Hello")]
        [TestCase("abcdef", "abc")]
        public void FirstHalf_Test(string str, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.FirstHalf(str);
            Assert.AreEqual(expectedResult, actual);

        }

        [TestCase("Hello", "ell")]
        [TestCase("java", "av")]
        [TestCase("coding", "odin")]
        public void TrimOne_Test(string str, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.TrimOne(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Hello", "hi", "hiHellohi")]
        [TestCase("hi", "Hello", "hiHellohi")]
        [TestCase("aaa", "b", "baaab")]
        public void LongInMiddle_Test(string a, string b, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.LonginMiddle(a, b);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Hello", "lloHe")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void RotateLeft2_Test(string str, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.RotateLeft2(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Hello", "loHel")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void RotateRight2_Test(string str, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.RotateRight2(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Hello", true, "H")]
        [TestCase("Hello", false, "o")]
        [TestCase("oh", true, "o")]
        public void TakeOne_Test(string str, bool FromFront, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.TakeOne(str, FromFront);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("string", "ri")]
        [TestCase("code", "od")]
        [TestCase("Practice", "ct")]
        public void MiddleTwo_Test(string str, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.MiddleTwo(str);
            Assert.AreEqual(expectedResult, actual);
        }
    }
}