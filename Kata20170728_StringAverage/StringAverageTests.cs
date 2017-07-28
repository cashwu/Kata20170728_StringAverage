using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [TestMethod]
        public void input_one_twnvyr_should_return_na()
        {
            AssertAverageStringShouldBe("one twnvyr", "n/a");
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
        private readonly string[] numbers = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        public string AverageString(string str)
        {
            var strList = str.Split(' ');
            if (!strList.All(numbers.Contains))
            {
                return "n/a";
            }

            return numbers[(int)strList.Select(s => Array.IndexOf(numbers, s)).Average()];
        }
    }
}