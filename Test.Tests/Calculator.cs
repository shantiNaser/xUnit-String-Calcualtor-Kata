using System;
using Xunit;
using code;

namespace Test.Tests
{
    public class Calculator
    {
        Kata numberAsStr = new Kata();
    
        [Theory]
        [InlineData("", 0)]
        [InlineData("2", 2)]
        [InlineData("2,3", 5)]
        [InlineData("2,3,3", 8)]
        [InlineData("2,3,3,2,5,6,4,3", 28)]
        public void ShouldReturnTheSumOfNumbersinStringSplitedByComma(string input, int expected)
        {
           var actual = numberAsStr.add(input);
           Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldREturnZeroIfInputIsNull()
        {
            var actual = numberAsStr.add(null);
            Assert.Equal(0,actual);
        }

        [Theory]
        [InlineData("1\n2,3",6)]
        [InlineData("1,\n",-99999)]
        public void ShouldReturnTheSumOfNumbersinStringSplitedByNewLine(string input, int expected)
        {
            var actual = numberAsStr.add(input);
            Assert.Equal(expected,actual);
        }
        

        [Theory]
        [InlineData("//;\n1;2",3)]
        [InlineData("//$\n3$2",5)]
        [InlineData("//%\n4%6",10)]
        public void ShouldReturnTheSumOfNumbersinStringSplitedByDifferentDilmater(string input, int expected)
        {
            var actual = numberAsStr.add(input);
            Assert.Equal(expected,actual);
        }


        // [Theory]
        // [InlineData("1,-2", "negatives not allowed: -2")]
        // public void Add_WithNegativeNumbers_ThrowsException(string input, string exceptionMessage)
        // {
        //     ArgumentException ex = Assert.Throws<ArgumentException>(() => numberAsStr.add(input));
        //     Assert.Equal(exceptionMessage, ex.Message);
        // }


        [Theory]
        [InlineData("10000,3,4",7)]
        [InlineData("//$\n3$2$10000",5)]
        [InlineData("1000,2",2)]
        public void ShouldIgnoreTheBigNumberValue(string input, int expected)
        {
            var actual = numberAsStr.add(input);
            Assert.Equal(expected,actual);
        }
    
    }
}