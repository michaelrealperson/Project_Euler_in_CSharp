using System;

namespace ProjectEuler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 4000000;
            int sum = SumEvenFibonacciNumbers(n);

            Console.WriteLine($"The sum of even Fibonacci numbers up to {n} is {sum}");

        }

        static int SumEvenFibonacciNumbers(int n)
        {
            int fibonacciLast = 2;
            int fibonacciPrevious = 1;
            int sum = 0;

            while (fibonacciLast + fibonacciPrevious < n)
            {
                int reserve;

                if ((fibonacciLast + fibonacciPrevious) % 2 == 0)
                    sum += fibonacciLast + fibonacciPrevious;

                // next numbers
                reserve = fibonacciLast;
                fibonacciLast += fibonacciPrevious;
                fibonacciPrevious = reserve;
            }

            return sum;
        }

    }

}
