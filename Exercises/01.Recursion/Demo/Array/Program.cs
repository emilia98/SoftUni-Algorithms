using System;
using System.Linq;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(Loop(arr, 0));
        }

        private static int? Loop(int[] array, int index)
        {
            if(index == array.Length)
            {
                return 0;
            }

            int? el = null;
            Console.WriteLine(el + " => "+ index);

            el = array[index] + Loop(array, index + 1);

            Console.WriteLine(el + " => " + index);
            return el;

            //Console.WriteLine(index);
        }
    }
}
