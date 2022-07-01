using System;

namespace Prob2884
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrInput = input.Split();

            int h = int.Parse(arrInput[0]);
            int m = int.Parse(arrInput[1]);

            m -= 45;
            if(m<0)
            {
                m += 60;
                --h;
                if (h < 0)
                    h += 24;
            }
                Console.WriteLine("{0} {1}", h, m);



        }
    }
}
