using System;
using Xtensions.Strings;
using System.Collections.Generic;
using NUnit.Framework;

namespace Tests {

    [TestFixture]
    public class StringsTests {
        [Test]
        public void Test_String_ToInt32() {

            var tests = new List<Tuple<string, int>>();
            tests.Add(new Tuple<string, int>("1", 1));
            tests.Add(new Tuple<string, int>("-1", -1));
            tests.Add(new Tuple<string, int>("123", 123));

            tests.Add(new Tuple<string, int>("hello", 0));
            tests.Add(new Tuple<string, int>("", 0));
            tests.Add(new Tuple<string, int>(null, 0));


            tests.ForEach(t => Assert.AreEqual(t.Item2, t.Item1.ToInt32(), $"could not parse string '{t.Item1}' to int32: {t.Item2}"));

        }
        [Test]
        public void Test_String_ToDecimal() {

            var tests = new List<Tuple<string, decimal>>();
            tests.Add(new Tuple<string, decimal>("1.0", 1));
            tests.Add(new Tuple<string, decimal>("-1", -1));
            tests.Add(new Tuple<string, decimal>("123.123", 123.123m));

            tests.Add(new Tuple<string, decimal>("hello", 0));
            tests.Add(new Tuple<string, decimal>("3,4", 0));
            tests.Add(new Tuple<string, decimal>(null, 0));

            tests.ForEach(t => Assert.AreEqual(t.Item2, t.Item1.ToDecimal(), $"could not parse string '{t.Item1}' to Decimal: {t.Item2}"));

        }
        [Test]
        public void Test_String_ToDouble() {

            var tests = new List<Tuple<string, double>>();
            tests.Add(new Tuple<string, double>("1.0", 1));
            tests.Add(new Tuple<string, double>("-1", -1));
            tests.Add(new Tuple<string, double>("123.123", 123.123));

            tests.Add(new Tuple<string, double>("hello", 0));
            tests.Add(new Tuple<string, double>("3,4", 0));
            tests.Add(new Tuple<string, double>(null, 0));

            tests.ForEach(t => Assert.AreEqual(t.Item2, t.Item1.ToDouble(), $"could not parse string '{t.Item1}' to Double: {t.Item2}"));

        }


        [Test]
        public void Test_String_IsNullOrEmpty() {
            Assert.AreEqual(true, ((string)null).IsNullOrEmpty());
            Assert.AreEqual(true, "".IsNullOrEmpty());
            Assert.AreEqual(false, "hello".IsNullOrEmpty());
        }
        [Test]
        public void Test_String_ToNotNull() {
            string str = null;
            Assert.AreEqual(String.Empty, str.ToNotNull());
            str = "hello";
            Assert.AreEqual(str, str.ToNotNull());
        }

        [Test]
        public void Test_String_Left() {
            Assert.AreEqual(String.Empty, ((string)null).Left(1));
            Assert.AreEqual(String.Empty, "".Left(1));
            Assert.AreEqual("he", "hello".Left(2));
            Assert.AreEqual("hello", "hello".Left(10));
        }

        [Test]
        public void Test_String_Right() {
            Assert.AreEqual(String.Empty, ((string)null).Right(1));
            Assert.AreEqual(String.Empty, "".Right(1));
            Assert.AreEqual("lo", "hello".Right(2));
            Assert.AreEqual("hello", "hello".Right(10));
        }

        [Test]
        public void Test_String_ToListOfInt32() {
            Assert.AreEqual(new List<int>(), ((string)null).ToListOfInt32());
            Assert.AreEqual(new List<int>(), "".ToListOfInt32());
            Assert.AreEqual(new List<int>() { 1, 2 }, "1;2".ToListOfInt32());
            Assert.AreEqual(new List<int>() { 1, 2, 0, 4 }, "1;2;0;4".ToListOfInt32());
        }

    }

}
