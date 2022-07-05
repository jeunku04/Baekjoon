using System;

namespace Prob5073
{
    class Program
    {
        static void Main(string[] args)
        {   // 삼각형과 세변(5073)
            while (true)
            {
                string input = Console.ReadLine();
                string[] arrInput = input.Split();
                int a = int.Parse(arrInput[0]);
                int b = int.Parse(arrInput[1]);
                int c = int.Parse(arrInput[2]);
                if (a + b + c == 0)
                    break;

                if (a < b)
                {
                    int tmp = a;
                    a = b;
                    b = tmp;
                }
                if (a < c)
                {
                    int tmp = a;
                    a = c;
                    c = tmp;
                }
                if (a >= b + c)
                    Console.WriteLine("Invalid");
                else if (a == b && b == c)
                    Console.WriteLine("Equilateral");
                else if (a == b || a == c || b == c)
                    Console.WriteLine("Isosceles");
                else
                    Console.WriteLine("Scalene");
            }
        }
    }
}