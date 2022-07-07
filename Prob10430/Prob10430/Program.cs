using System;

namespace Prob1000
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrinput = input.Split();
            int A = int.Parse(arrinput[0]);
            int B = int.Parse(arrinput[1]);
            int C = int.Parse(arrinput[2]);
            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A * B) % C);
            Console.WriteLine((A % C) * (B % C) % C);

        }
    }
}
