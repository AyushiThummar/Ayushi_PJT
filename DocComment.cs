using System;

namespace Ayushi_PJT
{
    /// <summary>
    /// The <c>DocComment</c> class demonstrates how to use XML documentation comments in C#.
    /// It also contains a method to swap two integer values.
    /// </summary>
    internal class DocComment
    {
        /// <summary>
        /// A sample integer field (not used in logic).
        /// </summary>
        int a;

        /// <summary>
        /// Swaps the values of two integers using reference parameters.
        /// </summary>
        /// <param name="a">The first integer to be swapped (passed by reference).</param>
        /// <param name="b">The second integer to be swapped (passed by reference).</param>
        public void Swap(ref int a, ref int b)
        {
            // Swap without third variable
            a = a + b;
            b = a - b;
            a = a - b;
        }

    /// <summary>
    /// The main program class to test the DocComment class.
    /// </summary>
        public static void Main(string[] args)
        {
            int a = 10, b = 20;

            Console.WriteLine("Before swap : a = {0} and b = {1}", a, b);

            // ✅ Creating object of DocComment class
            DocComment doc = new DocComment();

            // ✅ Calling Swap method via object
            doc.Swap(ref a, ref b);

            Console.WriteLine("After swap  : a = {0} and b = {1}", a, b);
        }
    }
}
