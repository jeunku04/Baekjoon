using System;

namespace _10156
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrInput = input.Split();
            int k = int.Parse(arrInput[0]);
            int n = int.Parse(arrInput[1]);
            int m = int.Parse(arrInput[2]);

            int need = k * n;
            int result = need - m;
            if (result < 0)
                result = 0;

            Console.WriteLine(result);
        }
    }
}
