using System;

namespace Prob5523
{
    class Program
    {
        static void Main(string[] args)
        {   // 경기 결과 (5523)
            string input = Console.ReadLine();
            int n = int.Parse(input);
            int aWinCnt = 0;
            int bWinCnt = 0;
            for (int i = 0; i < n; i++)  
            {
                input = Console.ReadLine();
                string[] arrInput = input.Split();
                int a = int.Parse(arrInput[0]);
                int b = int.Parse(arrInput[1]);

                if (a > b)
                    aWinCnt++;
                else if (a < b)
                    bWinCnt++;
            }
            Console.WriteLine("{0} {1}", aWinCnt, bWinCnt);
        }
    }
}