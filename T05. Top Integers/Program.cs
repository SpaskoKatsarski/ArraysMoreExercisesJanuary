using System;
using System.Linq;

namespace T05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool isTopInteger = true;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        isTopInteger = false;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write($"{arr[i]} ");
                }
            }

            Console.Write(arr[arr.Length - 1]);
        }
    }
}
