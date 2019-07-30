using System;

namespace _02.RecursiveFactorial_2
{
    class RecursiveFactorial_2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(n, 1));
        }

        private static long Factorial(int n, int i)
        {
            if(i == n)
            {
                return n;
            }

            return i * Factorial(n, i + 1);
        }
    }
}
