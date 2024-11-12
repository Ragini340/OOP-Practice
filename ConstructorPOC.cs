using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public class ConstructorPOC
    {
        int num;
        string name;
        int age;

        //Default constructor
        ConstructorPOC()
        {
            Console.WriteLine("Default constructor");
        }

        //Parametrized constructor with 2 parameters
        ConstructorPOC(int num, string name)
        {
            this.num = num;
            this.name = name;
        }

        //Parametrized constructor with 3 parameters
        ConstructorPOC(int num, string name, int age)
        {
            this.num = num;
            this.name = name;
            this.age = age;
        }

        public static void Main()
        {
            ConstructorPOC constructorPOC = new ConstructorPOC();
            Console.WriteLine(constructorPOC.num);
            Console.WriteLine(constructorPOC.name);
            Console.WriteLine(constructorPOC.age);
        }

    }
}
