using System;

namespace Prob11021
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input);

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] arrInput = input.Split();
                int a = int.Parse(arrInput[0]);
                int b = int.Parse(arrInput[1]);
                Console.WriteLine(a + b);
            }
        }
    }
}