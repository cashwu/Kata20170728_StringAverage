using System;
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
    }

    public class Kata
    {
        public string AverageString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "n/a";
            }

            return "one";
        }
    }
}
