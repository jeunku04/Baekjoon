using System;

namespace Prob8393
{
    class Program
    {
        static void Main(string[] args)
        {   // 합 (8393)
            string input = Console.ReadLine();
            int n = int.Parse(input);
            int a = 0;
            
            for (int i = 0; i < n;  i++)
            {
                a += 1 + i;
            }
            n = n + a;  
            Console.WriteLine(a);
        }
    }
}