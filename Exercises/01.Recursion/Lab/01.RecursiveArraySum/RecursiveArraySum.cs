using System;
using System.Linq;

namespace _01.RecursiveArraySum
{
    class RecursiveArraySum
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = Sum(arr, 0);

            Console.WriteLine(sum);
        }

        private static int Sum(int[] array, int index)
        {
            if(index == array.Length)
            {
                return 0;
            }

            return array[index] + Sum(array, index + 1);
        }
    }
}
