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
            AssertAverageStringShouldBe("", "n/a");
        }

        [TestMethod]
        public void input_one_one_should_return_one()
        {
            AssertAverageStringShouldBe("one one", "one");
        }

        [TestMethod]
        public void input_zero_zero_zero_zero_zero_should_return_zero()
        {
            AssertAverageStringShouldBe("zero zero zero zero zero", "zero");
        }

        [TestMethod]
        public void input_five_four_should_return_four()
        {
            AssertAverageStringShouldBe("five four", "four");
        }

        [TestMethod]
        public void input_zero_nine_five_two_should_return_four()
        {
            AssertAverageStringShouldBe("zero nine five two", "four");
        }

        [TestMethod]
        public void input_four_six_two_three_should_return_three()
        {
            AssertAverageStringShouldBe("four six two three", "three");
        }

        [TestMethod]
        public void input_one_two_three_four_five_should_return_three()
        {
            AssertAverageStringShouldBe("one two three four five", "three");
        }

        [TestMethod]
        public void input_one_one_eight_one_should_return_two()
        {
            AssertAverageStringShouldBe("one one eight one", "two");
        }

        private static void AssertAverageStringShouldBe(string str, string expected)
        {
            var kata = new Kata();
            var actual = kata.AverageString(str);
            Assert.AreEqual(expected, actual);
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