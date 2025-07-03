using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_PJT
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                int s = i <= 5 ? i : 10 - i;

                for (int j = 1; j <= s; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
