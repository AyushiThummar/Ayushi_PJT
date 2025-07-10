using System;

namespace Ayushi_PJT
{
    internal class Program6
    {
        public static void Main(string[] args)
        {
            //int a = 5;
            // //int b = 5;
            //int res = a++;

            ////res = a
            ////a = a + 1
            //Console.WriteLine(res);

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //int a = 5;
            //int b = 5;
            //int res = a++ + b++;

            ////res = a + b
            ////a = a + 1
            ////b = b + 1
            //Console.WriteLine(res);

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //int a = 5;
            //int b = 5;
            //int res = a++ + b++ + a++;

            ////res = 5 + 
            ////a = 5+1 = 6 // a will become 6.

            //Console.WriteLine(res);

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //int a = 5;
            //int b = 5;
            //int res = a++ + b++ + b++ +a++;

            ////res = 5 + 5 + 6 + 6
            //Console.WriteLine(res);

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //int a = 5;
            //int b = 5;
            //int res = ++a + b++ + b++ + a++;

            ////res = 6 + 5 + 6 + 6
            //Console.WriteLine(res);

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            int a = 5;
            int b = 5;
            int res = ++a + b++ + b++ + a++ + ++a + ++b + a++;

            //res = 6 + 5 + 6 + 6 + 8 + 8 + 8
            Console.WriteLine(res);


        }
    }
}