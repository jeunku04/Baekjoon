using System;

namespace Prob2747
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input);

            int[] a = new int[n + 1];
            a[0] = 0;
            a[1] = 1;
            for (int i = 2; i <= n; i++)            
                a[i] = a[i - 1] + a[i - 2];
            Console.WriteLine(a[n]);
        }
    }
}
