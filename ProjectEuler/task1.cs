using System;

namespace ProjectEuler
{
    internal class task1
    {
        static void Main(string[] args)
        {

            int n = 1000;
            int sum = SumOfNaturalMultiples(n);

            Console.WriteLine($"The sum of the multiples of 3 and 5 to {n}  is {sum}");

        }

        static int SumOfNaturalMultiples (int n)
        {

            int sum = 0;

            for (int i = 1; i < n; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            return sum;
        }

    }

}
