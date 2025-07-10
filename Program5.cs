using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_PJT
{
    internal class Program5
    {
        public static void Main(string[] args)
        {
            // Printing tables from 1 to 10.
            for(int i=1; i<=10; i++)
            {
                //Console.WriteLine("1 * "+ i+ " = "+1 * i);
                for (int j = 1; j <= 10; j++)
                {
                    int k = i * j;
                    Console.WriteLine(i+" * "+" = "+k);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
