using System;

namespace ProjectEuler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            long n = 600851475143;
            long reserve = n; // to display on the screen
            int i = 2;

            while (!CheckPrimeNumber(n))
            {
                if (n % i == 0)
                    n /= i;
                else
                    i++;
            }

            Console.WriteLine($"The largest prime divisor of {reserve} is {n}");

        }

        static bool CheckPrimeNumber (long n)
        {
            bool isPrimeNumber = true;
            int i = 2;

            while (i < n / i)
            {
                if (n % i == 0)
                {
                    isPrimeNumber = false;
                    break;
                }
                i++;
            }

            return isPrimeNumber;

        }

    }

}
