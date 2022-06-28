using System;

namespace Prob2576
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                a[i] = int.Parse(input);
            }
            int sum = 0;
            int min = int.MaxValue;
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 1)
                {
                    cnt++;
                    sum += a[i];

                    if (a[i] < min)
                        min = a[i];
                }
            }
            if (sum > 0)
            {
                Console.WriteLine(sum);
                Console.WriteLine(min);
                Console.WriteLine(sum / cnt);
            }
            else
                Console.WriteLine(-1);
        }
    }
}
