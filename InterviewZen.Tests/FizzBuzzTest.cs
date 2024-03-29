using InterviewZen;
// <copyright file="ProgramTest.cs">Copyright ©  2022</copyright>

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace InterviewZen.Tests
{
    /// <summary>This class contains parameterized unit tests for Program</summary>
    [TestClass]
    public class FizzBuzzTest
    {

        [TestMethod()]
        public void PrintFizzBuzzTest()
        {
            Assert.Fail();
        }


        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(3, "Fizz")]
        [DataRow(15, "FizzBuzz")]
        [DataRow(20, "Buzz")]
        [DataRow(30, "FizzBuzz")]
        [DataRow(45, "FizzBuzz")]
        public void GetFizzBuzzTest(int number, string expected)
        {
            var result = FizzBuzz.GetFizzBuzz(number);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void GetSecondsSinceMidnightTest()
        {
            var result = FizzBuzz.GetSecondsSinceMidnight("12:34:56.789");
            Assert.AreEqual(result, 45296.789);
        }

        [TestMethod()]
        [DataRow("cheap", "peach", true)]
        [DataRow("deer", "reed", true)]
        [DataRow("cheap", "reed", false)]
        [DataRow("deer", "cheap", false)]
        [DataRow("tar", "rat", true)]
        public void IsAnagramTest(string first, string second, bool expected)
        {
            var result = FizzBuzz.IsAnagram(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}