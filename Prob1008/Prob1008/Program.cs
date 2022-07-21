using System;

namespace Prob1008
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrInput = input.Split();
            double a = int.Parse(arrInput[0]);
            double b = int.Parse(arrInput[1]);
            Console.WriteLine(a / b);
        }
    }
}
