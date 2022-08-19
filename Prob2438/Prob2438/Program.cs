using System;

namespace Prob2438
{
    class Program
    {
        static void Main(string[] args)
        {   // 별 찍기 - 1 (2438)
            string input = Console.ReadLine();
            int n = int.Parse(input);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}