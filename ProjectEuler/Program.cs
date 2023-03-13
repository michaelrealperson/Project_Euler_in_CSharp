using System;

namespace ProjectEuler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxPalindrome = 0;
            int n = 1000;
            int digits = NumberOfDigits(n);

            for (int i = n / 10; i < n; i++)
                for (int j = i; j < n; j++)
                    if (CheckPalindrome(i * j) && i * j > maxPalindrome)
                        maxPalindrome = i * j;

            Console.WriteLine($"The largest product-palindrome obtained by multiplying two {digits - 1}-digit numbers is {maxPalindrome}.");
        }

        static bool CheckPalindrome(int n)
        {
            string number = Convert.ToString(n);
            char[] reverseNumber = number.ToCharArray();
            Array.Reverse(reverseNumber);

            return number == new string(reverseNumber);
        }

        static int NumberOfDigits(int n)
        {
            int i = 1;

            while (n > 9)
            { 
                i++;
                n /= 10;
            }

            return i;
        }

    }

}