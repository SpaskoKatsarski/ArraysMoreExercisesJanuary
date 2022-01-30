using System;

namespace T01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[] allValues = new int[n];

            for (int i = 0; i < n; i++)
            {
                int currentSumOfVowels = 0;
                int currentSumOfConsonants = 0;
                char[] arr = Console.ReadLine().ToCharArray();

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == 'a' || arr[j] == 'e' || arr[j] == 'i' || arr[j] == 'o' || arr[j] == 'u' || arr[j] == 'A' || arr[j] == 'E' || arr[j] == 'I' || arr[j] == 'O' || arr[j] == 'U')
                    {
                        currentSumOfVowels += arr[j] * arr.Length;
                    }
                    else
                    {
                        currentSumOfConsonants += arr[j] / arr.Length;
                    }
                }

                allValues[i] = currentSumOfVowels + currentSumOfConsonants;
            }
            Array.Sort(allValues);
            
                Console.WriteLine(String.Join(" \n", allValues));
        }
    }
}
