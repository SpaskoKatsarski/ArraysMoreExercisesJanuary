using System;
using System.Linq;

namespace T07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            int longestSequence = 0;
            int currentSequence = 1;
            int longestNumber = 0;

            bool flag = true;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }

                if (currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                    longestNumber = arr[i];
                }
            }

            for (int i = 0; i < longestSequence; i++)
            {
                Console.Write($"{longestNumber} ");
            }
        }
    }
}
