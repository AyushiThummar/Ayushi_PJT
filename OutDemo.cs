using System;

namespace Ayushi_PJT
{
    internal class OutDemo
    {
        static void Change(ref int a, ref int b)
        {
            a = 100;
            //b = 200;

        }
        static void Update(out int x, out int y) // For returning multiple outputs
        {
            x = 100; //1st
            int t = x;
            y = 200; //2nd

        }
        static void Main()
        {
            int a = 10, b = 20;
            int x = 10, y = 20;
            Console.WriteLine("Before change : a = {0} and b = {1}", a, b);
            Change(ref a, ref b);
            Console.WriteLine("After change : a = {0} and b = {1}", a, b);

            Console.WriteLine("Before Update : x = {0} and y = {1}", x, y);
            Change(ref a, ref b);
            Console.WriteLine("After Update : x = {0} and y = {1}", x, y);
        }
    }
}