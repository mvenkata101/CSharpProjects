using System;
using Xunit;
using FizzBuzzLibrary;


namespace FizzBuzzTests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void TestInputWith3ReturnString12Fizz()
        {
            int inputParam = 3;
            FizzBuzz fizzBuzzObj = new FizzBuzz();
            string expectedValue = "1 2 Fizz ";
            string actualValue = fizzBuzzObj.GetResults(inputParam);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void TestInputWith5ReturnString12Fizz4Buzz()
        {
            int inputParam = 5;
            FizzBuzz fizzBuzzObj = new FizzBuzz();
            string expectedValue = "1 2 Fizz 4 Buzz ";
            string actualValue = fizzBuzzObj.GetResults(inputParam);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void TestInputWith1000ReturnStringInvalidNumber()
        {
            int inputParam = 1000;
            FizzBuzz fizzBuzzObj = new FizzBuzz();
            string expectedValue = "InvalidNumber";
            string actualValue = fizzBuzzObj.GetResults(inputParam);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void TestInputWithEqualOrGreaterThan1000ReturnStringInvalidNumber()
        {
            int inputParam = 1200;
            FizzBuzz fizzBuzzObj = new FizzBuzz();
            string expectedValue = "InvalidNumber";
            string actualValue = fizzBuzzObj.GetResults(inputParam);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
