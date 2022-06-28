using System;

namespace Prob1000
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a = int.Parse(input);
            input = Console.ReadLine();
            int b = int.Parse(input);
            
            Console.WriteLine(a * (b % 10));
            Console.WriteLine(a * (b % 100 - b % 10) / 10);
            Console.WriteLine(a * (b - b % 100) / 100);
            Console.WriteLine(a * b);
                        

        }
    }
}
