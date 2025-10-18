using System;

namespace WebApplication1.services
{
    public static class UtilityServices
    {
        // Count vowels in a string
        public static int CountVowels(string input)
        {
            if (string.IsNullOrEmpty(input)) return 0;
            int count = 0;
            foreach (char c in input.ToLower())
            {
                if ("aeiou".Contains(c))
                    count++;
            }
            return count;
        }

        // Check if a year is a leap year
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        // Check if a number is a palindrome
        public static bool IsPalindrome(int number)
        {
            string s = number.ToString();
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return s == new string(arr);
        }
    }
}
