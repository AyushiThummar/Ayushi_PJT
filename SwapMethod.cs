using System;

namespace Ayushi_PJT
{
    internal class SwapMethod
    {
        static void Swap(ref int a,ref int b)      // a and b both are local variables.
        {
            // Without 3rd variable.
            //a = a + b     // => 10+20 = 30; 
            //b = a - b     // => 30-20 = 10; 
            //a = a - b     // => 30-10 = 20;

            // With 3rd variable.
            int temp = a ;
            a = b;
            b = temp ;
        }
        public static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine("Before swap : a = {0} and b = {1} ", a, b);
            //Swap(a,b);  // Passing the args by values.
            Swap(ref a, ref b);  // Passing the args by reference.
            Console.WriteLine("After swap : a = {0} and b = {1} ", a, b);
        }
    }
}
