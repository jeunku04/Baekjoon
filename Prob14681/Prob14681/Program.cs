    using System;

    namespace Prob14681
    {
        class Program
        {
            static void Main(string[] args)
            {   // 사분면 고르기 (14681)
                string input = Console.ReadLine();
                int x = int.Parse(input);
                input = Console.ReadLine();
                int y = int.Parse(input);

                if (x > 0)
                {
                    if (y > 0)
                        Console.WriteLine(1);
                    else
                        Console.WriteLine(4);
                }
                else
                if(x<0)
                {
                    if (y > 0)
                        Console.WriteLine(2);
                    else
                        Console.WriteLine(3);
                }
            }
        }
    }