using System;

namespace Prob10178
{
    class Program
    {
        static void Main(string[] args)
        {   // 할로윈의 사탕 (10178)
            string input = Console.ReadLine();
            int tc = int.Parse(input);
            for (int t = 0; t < tc; t++)
            {
                input = Console.ReadLine();
                string[] arrInput = input.Split();
                int c = int.Parse(arrInput[0]);
                int v = int.Parse(arrInput[1]);
                Console.WriteLine("You get {0} piece(s) and your dad gets {1} piece(s).", c / v, c % v);
            }
        }
    }
}