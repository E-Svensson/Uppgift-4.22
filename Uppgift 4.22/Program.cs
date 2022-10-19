using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 30; i++)
            {
                if (i == 30)
                {
                    Console.Write("30");
                    break;
                }
                Console.Write($"{i}, ");
            }

            Console.WriteLine("\n");

            for (int j = 200; j >= 180; j--)
            {
                if (j == 180)
                {
                    Console.Write("180");
                    break;
                }
                Console.Write($"{j}, ");
            }

            Console.WriteLine("\n");

            for (int k = 1000; k <= 1400; k += 50)
            {
                if (k == 1400)
                {
                    Console.Write("1400");
                    break;
                }
                Console.Write($"{k}, ");
            }

            Console.WriteLine();
        }
    }
}
