using System;
using System.Linq;

namespace Palindrome.Logic
{
    public static class PalindromeExtensions
    {
        public static bool IsPalindrome(this string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            for (var i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[^(i + 1)])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsPalindrome2(this string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            var trimmedLower = value.Replace(" ", string.Empty).Trim().ToLower();
            return trimmedLower.Reverse().SequenceEqual(trimmedLower);
        }
    }
}
