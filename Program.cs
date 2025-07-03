using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_PJT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Point 1 -> According to No. of rows.
            for(int i=1; i<=5; i++)
            {
                // Point 2 -> According to No. of columns in each row.
                for(int j=1; j<=5; j++)
                {
                    // Point 3 -> Dealing with printing.
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
