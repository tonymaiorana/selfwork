using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
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

        [TestCase("oddly", true)]
        [TestCase("y", false)]
        [TestCase("oddy", false)]
        public void EndsWithLy_Test(string str, bool expectedResult)
        {
            Strings test = new Strings();
            bool actual = test.EndsWithLy(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Hello", 2, "Helo")]
        [TestCase("Chocolate", 3, "Choate")]
        [TestCase("Chocolate", 1, "Ce")]
        public void FrontAndBack_Test(string str, int n, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.FrontAndBack(str, n);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("java", 0, "ja")]
        [TestCase("java", 2, "va")]
        [TestCase("java", 3, "ja")]
        public void TakeTwoFromPosition_Test(string str, int n, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.TakeTwoFromPosition(str, n);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("badxx", true)]
        [TestCase("xbadxx", true)]
        [TestCase("xxbadxx", false)]
        public void HasBad_Test(string str, bool expectedResult)
        {
            Strings test = new Strings();
            bool actual = test.HasBad(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("hello", "he")]
        [TestCase("hi", "hi")]
        [TestCase("h", "h@")]
        public void AtFirst_Test(string str, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.AtFirst(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("last", "chars", "ls")]
        [TestCase("yo", "mama", "ya")]
        [TestCase("hi", "", "h@")]
        public void LastChars_Test(string a, string b, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.LastChars(a, b);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("abc", "cat", "abcat")]
        [TestCase("dog", "cat", "dogcat")]
        [TestCase("abc", "", "abc")]
        public void ConCat_Test(string a, string b, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.ConCat(a, b);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("coding", "codign")]
        [TestCase("cat", "cta")]
        [TestCase("ab", "ba")]
        public void SwapLast_Test(string str, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.SwapLast(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("edited", true)]
        [TestCase("edit", false)]
        [TestCase("ed", true)]
        public void FrontAgain_Test(string str, bool expectedResult)
        {
            Strings test = new Strings();
            bool actual = test.FrontAgain(str);
            Assert.AreEqual(expectedResult, actual);

        }

        [TestCase("Hello", "Hi", "loHi")]
        [TestCase("Hello", "java", "ellojava")]
        [TestCase("java", "Hello", "javaello")]
        public void MinCat_Test(string a, string b, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.MinCat(a, b);
            Assert.AreEqual(expectedResult, actual);

        }

        [TestCase("Hello", "llo")]
        [TestCase("away", "aay")]
        [TestCase("abed", "abed")]
        public void TweakFront_Test(string str, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.TweakFront(str);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("xHix", "Hi")]
        [TestCase("xHi", "Hi")]
        [TestCase("Hxix", "Hxi")]
        public void StripX_Test(string str, string expectedResult)
        {
            Strings test = new Strings();
            string actual = test.StripX(str);
            Assert.AreEqual(expectedResult, actual);
        }
    }
}