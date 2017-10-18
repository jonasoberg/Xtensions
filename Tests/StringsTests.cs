using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xtensions;
using System.Collections.Generic;

namespace Tests {
    [TestClass]
    public class StringsTests {
        [TestMethod]
        public void Test_String_ToInt32() {

            var tests = new List<Tuple<string, int>>();
            tests.Add(new Tuple<string, int>("1", 1));
            tests.Add(new Tuple<string, int>("-1", -1));
            tests.Add(new Tuple<string, int>("123", 123));

            tests.Add(new Tuple<string, int>("hello", 0));
            tests.Add(new Tuple<string, int>("", 0));
            tests.Add(new Tuple<string, int>(null, 0));


            tests.ForEach(t => Assert.IsTrue(t.Item1.ToInt32() == t.Item2, $"could not parse string '{t.Item1}' to int32: {t.Item2}"));

        }
        [TestMethod]
        public void Test_String_ToDecimal() {

            var tests = new List<Tuple<string, decimal>>();
            tests.Add(new Tuple<string, decimal>("1.0", 1));
            tests.Add(new Tuple<string, decimal>("-1", -1));
            tests.Add(new Tuple<string, decimal>("123.123", 123.123m));

            tests.Add(new Tuple<string, decimal>("hello", 0));
            tests.Add(new Tuple<string, decimal>("3,4", 0));
            tests.Add(new Tuple<string, decimal>(null, 0));

            tests.ForEach(t => Assert.IsTrue(t.Item1.ToDecimal() == t.Item2, $"could not parse string '{t.Item1}' to Decimal: {t.Item2}"));

        }
        [TestMethod]
        public void Test_String_ToDouble() {

            var tests = new List<Tuple<string, double>>();
            tests.Add(new Tuple<string, double>("1.0", 1));
            tests.Add(new Tuple<string, double>("-1", -1));
            tests.Add(new Tuple<string, double>("123.123", 123.123));

            tests.Add(new Tuple<string, double>("hello", 0));
            tests.Add(new Tuple<string, double>("3,4", 0));
            tests.Add(new Tuple<string, double>(null, 0));

            tests.ForEach(t => Assert.IsTrue(t.Item1.ToDouble() == t.Item2, $"could not parse string '{t.Item1}' to Double: {t.Item2}"));

        }


        [TestMethod]
        public void Test_String_IsNullOrEmpty() {
            Assert.IsTrue(((string)null).IsNullOrEmpty() == true);
            Assert.IsTrue("".IsNullOrEmpty() == true);
            Assert.IsTrue("hello".IsNullOrEmpty() == false);
        }
        [TestMethod]
        public void Test_String_ToNotNull() {
            string str = null;
            Assert.IsTrue(str.ToNotNull().Length == 0, "");
            str = "hello";
            Assert.IsTrue(str.ToNotNull() == str, "");
        }

        [TestMethod]
        public void Test_String_Left() {
            Assert.IsTrue(((string)null).Left(1) == String.Empty);
            Assert.IsTrue("".Left(1) == String.Empty);
            Assert.IsTrue("hello".Left(2) == "he");
            Assert.IsTrue("hello".Left(10) == "hello");
        }

        [TestMethod]
        public void Test_String_Right() {
            Assert.IsTrue(((string)null).Right(1) == String.Empty);
            Assert.IsTrue("".Right(1) == String.Empty);
            Assert.IsTrue("hello".Right(2) == "lo");
            Assert.IsTrue("hello".Right(10) == "hello");
        }

    }

}
