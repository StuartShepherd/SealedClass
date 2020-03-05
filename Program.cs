using System;

namespace SealedClass
{
    class Program
    {
        public sealed class Name
        {
            public string FirstName;
            public string LastName;
        }

        // Program.Employee: cannot derive from sealed type Program.Name
        //public class Employee : Name
        //{

        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Sealed Class");
            Console.WriteLine("A class with sealed keyword indicates that class is sealed to prevent inheritance. Sealed class cannot inheritance.");
            Console.WriteLine("");

            // You are unable to inherit the Name class.
        }
    }
}