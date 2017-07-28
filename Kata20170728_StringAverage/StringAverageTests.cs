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
        public void input_zero_zero_zero_zero_zero_should_return_zero()
        {
            var kata = new Kata();
            var actual = kata.AverageString("zero zero zero zero zero");
            Assert.AreEqual("zero", actual);
        }

        [TestMethod]
        public void input_five_four_should_return_four()
        {
            var kata = new Kata();
            var actual = kata.AverageString("five four");
            Assert.AreEqual("four", actual);
        }

        [TestMethod]
        public void input_zero_nine_five_two_should_return_four()
        {
            var kata = new Kata();
            var actual = kata.AverageString("zero nine five two");
            Assert.AreEqual("four", actual);
        }

        [TestMethod]
        public void input_four_six_two_three_should_return_three()
        {
            var kata = new Kata();
            var actual = kata.AverageString("four six two three");
            Assert.AreEqual("three", actual);
        }

        [TestMethod]
        public void input_one_two_three_four_five_should_return_three()
        {
            var kata = new Kata();
            var actual = kata.AverageString("one two three four five");
            Assert.AreEqual("three", actual);
        }

        [TestMethod]
        public void input_one_one_eight_one_should_return_two()
        {
            var kata = new Kata();
            var actual = kata.AverageString("one one eight one");
            Assert.AreEqual("two", actual);
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
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9}
        };

        public string AverageString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "n/a";
            }

            var numList = ConvertStringList2NumberList(str.Split(' '));
            return ConvertNumber2String(NumberAverage(numList));
        }

        private string ConvertNumber2String(int numberAverage)
        {
            return dicStrToNum.FirstOrDefault(kv => kv.Value == numberAverage).Key;
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