using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("mom",true)]
        [InlineData("wasabi", false)]
        public void Test1(string word, bool expected)
        {
            var myTest = new WordSmith();
            var actual = myTest.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
