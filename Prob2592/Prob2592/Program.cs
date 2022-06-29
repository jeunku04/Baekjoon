using System;

namespace Prob2592
{
    class Program
    {
        static void Main(string[] args)
        {   // 최대값 (2562)
            int n = 10;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                a[i] = int.Parse(input);
            }
            int av = 0; 
            for (int i = 0; i < n; i++)
            {
                av += a[i];
            }
            int[] index = new int[1000];
            int max = int.MinValue;
            int mode = 0;
            for{}
            index[a]++;
            Console.WriteLine(av / 10);
            Console.WriteLine(mode);
                
        }
    }
}
