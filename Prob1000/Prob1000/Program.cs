using System;

namespace Prob1000
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrinput = input.Split();
            int a = int.Parse(arrinput[0]);
            int b = int.Parse(arrinput[1]);
            Console.WriteLine(a + b);
            
        }
    }
}
