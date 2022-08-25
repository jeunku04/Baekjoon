using System;

namespace Prob2480
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrInput = input.Split();
            int a = int.Parse(arrInput[0]);
            int b = int.Parse(arrInput[1]);
            int c = int.Parse(arrInput[2]);
            if (a == b && b == c)
            {
            Console.WriteLine(10000 + 1000 * a);
            }
            else if (a == b)
            {
            Console.WriteLine(1000 + 100 * a);
            }
            else if (a == c)
            {
                Console.WriteLine(1000 + 100 * a);
            }
            else if (b == c)
            {
                Console.WriteLine(1000 + 100 * b);
            }
            else
            {
             if(a > b && a > c)
             Console.WriteLine(100 * a);
             else if(c > a && c > b)
             Console.WriteLine(100 * c);
             else if(b > a && b > c)
             Console.WriteLine(100 * b);
            }
        }
    }
}
