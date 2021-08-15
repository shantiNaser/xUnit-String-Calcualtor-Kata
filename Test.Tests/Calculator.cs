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
        public void ShouldReturnTheSumOfNumbersinStringSplitedByComma(string input, int expected)
        {
           Kata numberAsStr = new Kata();
           var actual = numberAsStr.add(input);
           Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldREturnZeroIfInputIsNull()
        {
            Kata numberAsStr = new Kata();
            var actual = numberAsStr.add(null);
            Assert.Equal(0,actual);
        }

        [Theory]
        [InlineData("1\n2,3",6)]
        [InlineData("1,\n",-99999)]
        public void ShouldReturnTheSumOfNumbersinStringSplitedByNewLine(string input, int expected)
        {
            Kata numberAsStr = new Kata();
            var actual = numberAsStr.add(input);
            Assert.Equal(expected,actual);
        }
        

        [Theory]
        [InlineData("//;\n1;2",3)]
        [InlineData("//$\n3$2",5)]
        [InlineData("//%\n4%6",10)]
        public void ShouldReturnTheSumOfNumbersinStringSplitedByDifferentDilmater(string input, int expected)
        {
            Kata numberAsStr = new Kata();
            var actual = numberAsStr.add(input);
            Assert.Equal(expected,actual);
        }
    
    }
}