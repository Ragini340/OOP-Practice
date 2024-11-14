﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    //Inheritance POC
    //Single Inheritance
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }

    //Multi - level inheritance
    class Mammal : Animal
    {
        public void Run()
        {
            Console.WriteLine("Mammal is running");
        }
    }

    class Horse : Mammal
    {
        public void Gallop()
        {
            Console.WriteLine("Horse is galloping.");
        }
    }

    //Hierarchical inheritance
    class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }

    class Eagle : Bird
    {
        public void Hunt()
        {
            Console.WriteLine("Eagle is hunting");
        }
    }

    class Penguin : Bird
    {
        public void Swim()
        {
            Console.WriteLine("Penguine is swimming");
        }
    }

    //Multiple inheritance
    interface I1
    {
        void Method1();
    }

    interface I2
    {
        void Method2();
    }

    class MyClass : I1, I2
    {
        public void Method1()
        {
            Console.WriteLine("Method1 is called");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 is called");
        }
    }

    class DriverClass
    {
        static void Main(string[] args)
        {
            //Single inheritance
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            //Multi-level inheritance
            Horse horse = new Horse();
            horse.Eat();
            horse.Run();
            horse.Gallop();

            //Hierarchical inheritance
            Eagle eagle = new Eagle();
            eagle.Hunt();
            eagle.Fly();
            Penguin penguin = new Penguin();
            penguin.Fly();
            penguin.Eat();

            //Multiple inheritance
            MyClass myClass = new MyClass();
            myClass.Method1();
            myClass.Method2();
            Console.ReadLine();
        }

    }
}
