using System;

namespace Prob1000
{
    class Program
    {
        static void Main(string[] args)
        {   
            string input = Console.ReadLine();  
            string[] arrInput = input.Split();
            int a = int.Parse(arrInput[0]);
            if(a >= 90)
                Console.WriteLine("A");
            else if (a >= 80)
                Console.WriteLine("B");
            else if (a >= 70)
                Console.WriteLine("C");
            else if (a >= 60)
                Console.WriteLine("D");
            else
                Console.WriteLine("F");
        }
    }
}