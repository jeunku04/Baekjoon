using System;
using System.Text;

namespace Prob2741
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input);

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                sb.Append(i + "Wn");
            }
            Console.WriteLine(sb);
        }
    }
}
