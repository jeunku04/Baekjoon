using System;

namespace Prob2947
{
    class Program
    {
        static void Main(string[] args)
        {   // 나무 조각 (2947)
            string input = Console.ReadLine();
            string[] arrInput = input.Split();

            int n = 5;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(arrInput[i]);

            if(a[0] > a[1])
            {
                int b = a[0];
                a[0] = a[1];
                a[1] = b;
            }
            else if (a[1] > a[2])
            {
                int b = a[1];
                a[1] = a[2];
                a[2] = b;
            }
            else if (a[2] > a[3])
            {
                int b  = a[2];
                a[2] = a[3];
                a[4] = b;
            }
            else if (a[3] > a[4])
            {
                int b  = a[3];
                a[3] = a[4];
                a[4] = b;
            }
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", a[0], a[1], a[2], a[3], a[4]);
        }
    }
}