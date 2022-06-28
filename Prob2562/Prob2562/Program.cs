using System;

namespace Prob2562
{
    class Program
    {
        static void Main(string[] args)
        {   // 최대값 (2562)
            int n = 9;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                a[i] = int.Parse(input);
            }

            int max = int.MinValue;
            int maxi = 0;
            for(int i=0; i<n; i++)
            {
                if (a[i] > max)
                    max = a[i];
                    maxi = i;
                Console.WriteLine(max);
                Console.WriteLine(maxi);
            }

            
        }
    }
}