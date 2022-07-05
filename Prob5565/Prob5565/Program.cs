using System;

namespace Prob5565
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int total = int.Parse(input);
            for (int i = 0; i < 9; i++)
            {
                input = Console.ReadLine();
                int price = int.Parse(input);

                total -= price;
            } 

                Console.WriteLine(total);
            
        }
    }
}
