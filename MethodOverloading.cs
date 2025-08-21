using System;

namespace Ayushi_PJT
{
    internal class MethodOverloading
    {
        void Sum(int n1, int n2)
        {
            Console.WriteLine("Sum of two integers: " + (n1 + n2));
        }
        void Sum(int n1, int n2, int n3)
        {
            Console.WriteLine("Sum of three integers: " + (n1 + n2 + n3));
        }
        void Sum(double n1, double n2)
        {
            Console.WriteLine("Sum of two doubles: " + (n1 + n2));
        }
        public static void Main(String[] args)
        {
            MethodOverloading s1 = new MethodOverloading();
            s1.Sum(14,25);
        }
    }
}
