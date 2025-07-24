using System;

namespace Ayushi_PJT
{
    internal class Program7
    {
        public static void Main(string[] args)
        {
            for(int i = 1; i<=4; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (i == 2 & j == 2)
                    {
                        Console.Write(1 + " ");
                    }
                    if (i == 3 & j == 2)
                    {
                        Console.Write(2 + " ");
                    }
                    else
                    {
                        Console.Write(3 + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
