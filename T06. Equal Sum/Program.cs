using System;
using System.Linq;

namespace T06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            if (arr.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = i; j < arr.Length; j++)
                {
                    leftSum += arr[j];
                }
                
                for (int j = i; j >= 0; j--)
                {
                    rightSum += arr[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
