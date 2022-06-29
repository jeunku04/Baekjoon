using System;

namespace Prob2720
{
    class Program
    {
        static void Main(string[] args)
        {   // 세탁소 사장 동혁 (2720)
            string input = Console.ReadLine();
            int tc = int.Parse(input);
            for (int t = 0; t < tc; t++)
            {
                input = Console.ReadLine();
                int n = int.Parse(input);

                int a = n / 25;
                int b = n % 25 / 10;
                int c = n % 25 % 10 / 5;
                int d = n % 25 % 10 % 5 / 1;

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(d);


            }
        }
    }
}
