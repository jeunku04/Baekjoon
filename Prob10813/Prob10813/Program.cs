using System;

namespace Prob10813
{
    class Program
    {
        static void Main(string[] args)
        {   // 공 바꾸기 (10813)
            string input = Console.ReadLine();
            string[] arrInput = input.Split();
            int n = int.Parse(arrInput[0]);
            int m = int.Parse(arrInput[1]);

            int[] arr = new int[n + 1];
            for (int i = 1; i <= n; i++)
                arr[i] = i;

            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine();
                arrInput = input.Split();

                int a = int.Parse(arrInput[0]);
                int b = int.Parse(arrInput[1]);

                int tmp = arr[a];
                arr[a] = arr[b];
                arr[b] = tmp;
            }
            for (int i = 1; i <= n; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
