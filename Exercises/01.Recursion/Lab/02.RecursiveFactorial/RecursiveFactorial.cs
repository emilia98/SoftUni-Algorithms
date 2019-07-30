using System;

namespace _02.RecursiveFactorial
{
    class RecursiveFactorial
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            long fact = Factorial(n);

            Console.WriteLine(fact);
        }

        private static long Factorial(int n)
        {
            if(n == 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}
