using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_PJT
{
    // Not required to be crated any object.
    static class MathMethods
    {
        //public void Display() { }
        ////Can not create non-static method in static class.

        public static void Show()
        { }
    }
    /* A static class is functionally the same as creating a class with a private constructor.
     * An instance of the class can never be created.
     * By using the static keyword, the compiler can help by checking that instance member are never accidently added to the class.
     * If they are, a compile error happens.
     * This can help guarantee that an instance of the class can never be created.
    */
    class StudentDetails 
    {
        private StudentDetails()
        { }
        public void Display() { } // No benefit of adding non static methods bcz of private constructor.
        static public void Show() { }
        
    }
    internal class StaticClass
    {
        public static void Main(string[] args)
        {

            //// Trick - 1
            //// 1) You can not create an instance of a static class.
            //MathMethods oj1 = new MathMethods();
            //// 2) You can call static methods with class name.
            MathMethods.Show();
            //// 3) You can not call non static methods with class name.
            //MathMethods.Display();

            //// Trick - 2
            //// 1) You can not create an instance of a private constructor class.
            //StudentDetails oj2 = new MathMethods();
            //// 2) You can call static methods with class name.
            StudentDetails.Show();  // Only static methods can be called.
            //// 3) You can not call non static methods with class name.
            //StudentDetails.Display();   // non static method.


            // To create object of a class.
            // To call methods, constructors, etc.
            // To assign values or calculate values for data members.
        }
    }
}
