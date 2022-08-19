using System;

namespace Prob2438
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrinput = input.Split();
            int a = int.Parse(arrinput[0]);
            int b = int.Parse(arrinput[1]);
            {
                if (a > b)
                    Console.WriteLine(">");
                else if (a < b)
                    Console.WriteLine("<");
                else if (a == b)
                    Console.WriteLine("==");
            }
        }
    }
}