using System;

namespace T03._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wantedFibonacciNumber = int.Parse(Console.ReadLine());

            int[] fibonacciNumbers = new int[wantedFibonacciNumber];
            
            fibonacciNumbers[0] = 1;

            if (fibonacciNumbers.Length <= 1)
            {
                Console.WriteLine(1);
                return; 
            }

            fibonacciNumbers[1] = 1;

            for (int i = 2; i < fibonacciNumbers.Length; i++)
            {
                fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
            }

            Console.WriteLine(fibonacciNumbers[fibonacciNumbers.Length - 1]);
        }
    }
}
