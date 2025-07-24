// Create one add method to add two numbers and return result of addition of that numbers.
using System;

namespace Ayushi_PJT
{
    internal class method_add
    {
        //int test;   // Belongs to object. Copies as per object
        //static int test2;  // Belongs class with single copy.
        //int Add(int a,int b) // Non static
        //{
        //    return a + b;
        //}
        // Can not use non-static members within static methods.
        static int Add(int a, int b) //  Static
        {
            return a + b;
        }
        static int Sub(int a, int b) 
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Div(int a, int b)
        {
            return a / b;
        }
        static void Main() // Static
        {
            int a = 20, b = 10;
            int ra,rs,rm,rd;
            ra = Add(a, b); // Non static member call in static method.
            Console.WriteLine("Addition : "+ra);
            //Console.WriteLine("Addition : {0}", ra);
            //Console.WriteLine("{0} + {1} : {2} ", a,b,ra);

            rs = Sub(a, b); 
            Console.WriteLine("Subtraction : " + rs);
            rm = Multiply(a, b);
            Console.WriteLine("Multiplication : " + rm);
            rd = Div(a, b);
            Console.WriteLine("Division : " + rd);
        }
    }
}
