using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public class PrivateConstructor
    {
        //Declaring private constructor
        private PrivateConstructor()
        {
        }

        //Declaring static variable field
        public static int count;

        //Declaring static method
        public static int CountMethod()
        {
            return count++;
        }

        public static void Main()
        {
            PrivateConstructor.count = 99;

            // Accessing without any instance of the class
            PrivateConstructor.CountMethod();
            Console.WriteLine(PrivateConstructor.count);

            // Accessing without any instance of the class
            PrivateConstructor.CountMethod();
            Console.WriteLine(PrivateConstructor.count);
        }

    }
}