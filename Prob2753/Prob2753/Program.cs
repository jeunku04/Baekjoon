using System;

namespace Prob2753
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input);
            int result = 0;

            if (n % 4 == 0)
            {
                result = 1;
            }
            if(n%100==0)
            {
                result = 0;
                    
            }
            if(n%400==0)

            {
                result = 1;
            }
            Console.WriteLine(result);

        }
    }
}
