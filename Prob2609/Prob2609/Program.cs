using System;

namespace Prob2609
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrInput = input.Split();
            int a = int.Parse(arrInput[0]);
            int b = int.Parse(arrInput[1]);
            int i;
            int num1 = 0, num2 = 0;
            for (i = 1;  i <= a && i <= b; i++)
                if (a % i + b % i == 0)
                {
                    num1 = i;
                }
            for (i = a * b; i >= 1; i--)
                if (i % a + i % b == 0)
                {
                    num2 = i;
                }
            Console.WriteLine("{0} {1}",num1, num2);
        }
    }
}
