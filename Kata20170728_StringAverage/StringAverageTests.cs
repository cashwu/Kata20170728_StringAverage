using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

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
        public void input_zero_zero_should_return_zero()
        {
            var kata = new Kata();
            var actual = kata.AverageString("zero zero");
            Assert.AreEqual("zero", actual);
        }

        [TestMethod]
        public void input_three_four_should_return_three()
        {
            var kata = new Kata();
            var actual = kata.AverageString("three four");
            Assert.AreEqual("three", actual);
        }
    }

    public class Kata
    {
        private readonly Dictionary<string, int> dicStrToNum = new Dictionary<string, int>
        {
            {"zero", 0},
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4}
        };

        private readonly Dictionary<int, string> dicNumToStr = new Dictionary<int, string>
        {
            {0, "zero"},
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"}
        };

        public string AverageString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "n/a";
            }

            var numList = ConvertStringList2NumberList(str.Split(' '));
            var numberAverage = NumberAverage(numList);
            return dicNumToStr[numberAverage];
        }

        private int NumberAverage(List<int> numList)
        {
            return numList.Sum() / numList.Count;
        }

        private List<int> ConvertStringList2NumberList(string[] strList)
        {
            return strList.Select(str => dicStrToNum[str]).ToList();
        }
    }
}