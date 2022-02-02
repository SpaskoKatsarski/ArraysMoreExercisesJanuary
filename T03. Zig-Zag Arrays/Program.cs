using System;
using System.Linq;

namespace T03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] evenArray = new int[n];
            int[] oddArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    evenArray[i] = arr[0];
                    oddArray[i] = arr[1];
                }
                else
                {
                    evenArray[i] = arr[1];
                    oddArray[i] = arr[0];
                }
            }

            Console.WriteLine(String.Join(" ", evenArray));
            Console.WriteLine(String.Join(" ", oddArray));
        }
    }
}
