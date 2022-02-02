using System;
using System.Linq;

namespace T04._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int leftFoldIndex = initArr.Length / 4 - 1;
            int rightFoldIndex = 3 * initArr.Length / 4;

            int[] topArr = new int[initArr.Length / 2];

            int howManyNumbersSoFar = 0;
            for (int i = leftFoldIndex; i >= 0; i--)
            {
                howManyNumbersSoFar++;
                topArr[leftFoldIndex - i] = initArr[i];
            }

            for (int i = initArr.Length - 1; i >= rightFoldIndex; i--)
            {
                topArr[initArr.Length - 1 - i + howManyNumbersSoFar] = initArr[i];
            }


            int[] bottomArr = new int[initArr.Length / 2];

            for (int i = leftFoldIndex + 1; i < rightFoldIndex; i++)
            {
                bottomArr[i - howManyNumbersSoFar] = initArr[i];
            }


            for (int i = 0; i < topArr.Length; i++)
            {
                Console.Write(topArr[i] + bottomArr[i] + " ");









                //int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                //    .ToArray();

                //// 1 2 3 4 | 5 6 7 8

                //// arr[0] + arr[3]
                //// arr[1] + arr[2]

                //int currentIndex = 0;

                //int countOfOperations = arr.Length / 4;

                //int sum = 0;

                //for (int i = 0; i < countOfOperations; i++)
                //{
                //    sum = arr[currentIndex] + arr[currentIndex + 3];
                //    Console.Write(sum + " ");
                //    sum = arr[currentIndex + 1] + arr[currentIndex + 2];
                //    Console.Write(sum + " ");

                //    currentIndex += 4;
                //}
            }
        }
    }
}
