using System;
using Xunit;
using code;

namespace Test.Tests
{
    public class Calculator
    {
    
        [Theory]
        [InlineData("", 0)]
        [InlineData("2", 2)]
        [InlineData("2,3", 5)]
        [InlineData("2,3,3", 8)]
        [InlineData("2,3,3,2,5,6,4,3", 28)]
        public void ShouldReturnTheSumOfNumbersinString(string input, int expected)
        {
           Kata numberAsStr = new Kata();
           var actual = numberAsStr.add(input);
           Assert.Equal(expected, actual);
        }


    
    }
}