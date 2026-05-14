using System;

namespace ValidPalindromeConsoleApp
{
    class Program
    {
        static bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length-1;

            while (left < right)
            {
                while(left < right && !char.IsLetterOrDigit(s[left])) 
                    left++;
                while(left < right && !char.IsLetterOrDigit(s[right]))
                    right--;
                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                    return false;
                left++;
                right--;
            }
           return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Valid Palindrome");
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            bool result = IsPalindrome(input);
            Console.WriteLine("Output: " + result);
            Console.ReadLine();

        }
    }
}