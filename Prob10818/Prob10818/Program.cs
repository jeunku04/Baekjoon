using System;

namespace Prob10818
{
    class Program
    {
        static void Main(string[] args)
        {   // 최소, 최대 (10818)
            string input = Console.ReadLine();
            int n = int.Parse(input);
            int[] a = new int[n];
            input = Console.ReadLine();
            string[] arrInput = input.Split();
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(arrInput[i]);

            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];                   
                }
            }
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];                   
                }
            }
            Console.WriteLine(min); Console.WriteLine(max);
        }
    }
}