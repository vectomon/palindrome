using System;
using Palindrome.Logic;
using Xunit;

namespace Palindrome.Test
{
    public class PalindromeTest
    {
        [Fact]
        public void Should_ReturnTrue_ForEmptyString()
        {
            Assert.True(string.Empty.IsPalindrome());
            Assert.True(string.Empty.IsPalindrome2());
        }

        [Theory]
        [InlineData("a")]
        [InlineData("b")]
        [InlineData("c")]
        public void Should_ReturnTrue_ForSingleLetterStrings(string input)
        {
            Assert.True(input.IsPalindrome());
            Assert.True(input.IsPalindrome2());
        }

        [Theory]
        [InlineData("aa")]
        [InlineData("bbb")]
        [InlineData("bob")]
        [InlineData("abba")]
        [InlineData("tacocat")]
        public void Should_ReturnTrue_ForPalindromes(string input)
        {
            Assert.True(input.IsPalindrome());
            Assert.True(input.IsPalindrome2());
        }

        [Theory]
        [InlineData("ab")]
        [InlineData("abb")]
        [InlineData("takonycat")]
        public void Should_ReturnFalse_ForNonPalindromes(string input)
        {
            Assert.False(input.IsPalindrome());
            Assert.False(input.IsPalindrome2());
        }

        [Fact]
        public void Should_ThrowArgumentNullException_ForNull()
        {
            Action action = () => ((string)null).IsPalindrome();
            Assert.Throws<ArgumentNullException>(action);

            Action action2 = () => ((string)null).IsPalindrome2();
            Assert.Throws<ArgumentNullException>(action2);
        }
    }
}
