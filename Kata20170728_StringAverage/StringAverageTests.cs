using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170728_StringAverage
{
    [TestClass]
    public class StringAverageTests
    {
        [TestMethod]
        public void input_empty_should_return_na()
        {
            var kata = new Kata();
            var actual = kata.AverageString("");
            Assert.AreEqual("n/a", actual);
        }

        [TestMethod]
        public void input_one_one_should_return_one()
        {
            var kata = new Kata();
            var actual = kata.AverageString("one one");
            Assert.AreEqual("one", actual);
        }

        [TestMethod]
        public void input_two_two_should_return_two()
        {
            var kata = new Kata();
            var actual = kata.AverageString("two two");
            Assert.AreEqual("two", actual);
        }
    }

    public class Kata
    {
        public string AverageString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "n/a";
            }

            var strList = str.Split(' ');

            var numList = ConvertStringList2NumberList(strList);

            return NumberAverage(numList) == 1 ? "one" : "two";
        }

        private static int NumberAverage(List<int> numList)
        {
            return numList.Sum() / numList.Count;
        }

        private static List<int> ConvertStringList2NumberList(string[] strList)
        {
            return strList.Select(a => a == "one" ? 1 : 2).ToList();
        }
    }
}
