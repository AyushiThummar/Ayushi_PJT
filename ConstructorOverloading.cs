using System;

namespace Ayushi_PJT
{
    internal class ConstructorOverloading
    {
        int EmpId;
        string EmpName;
        string City;
        public ConstructorOverloading()
        {
        }
        public ConstructorOverloading(int empId, string empName)
        {
            this.EmpId = empId;
            this.EmpName = empName;
        }
        public ConstructorOverloading(int empId, string empName, string city)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.City = city;
        }
        public void Display()
        {
            Console.WriteLine("Employee ID: " + EmpId);
            Console.WriteLine("Employee Name: " + EmpName);
            Console.WriteLine("City: " + City);
        }
        public static void Main(string[] args)
        {
            // Using default constructor
            ConstructorOverloading emp1 = new ConstructorOverloading();
            emp1.EmpId = 101;
            emp1.EmpName = "Ayushi Thummar";
            emp1.Display();

            // Using constructor with two parameters
            ConstructorOverloading emp2 = new ConstructorOverloading(102, "Param");
            emp2.Display();

            // Using constructor with three parameters
            ConstructorOverloading emp3 = new ConstructorOverloading(103, "Meer", "New York");
            emp3.Display();
        }
    }
}
