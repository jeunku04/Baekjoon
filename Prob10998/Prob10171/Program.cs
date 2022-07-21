using System;

namespace Prob10998
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrInput = input.Split();
            int a = int.Parse(arrInput[0]);
            int b = int.Parse(arrInput[1]);
            Console.WriteLine(a * b);
        }
    }
}
