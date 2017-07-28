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
    }

    public class Kata
    {
        public string AverageString(string str)
        {
            return "n/a";
        }
    }
}
