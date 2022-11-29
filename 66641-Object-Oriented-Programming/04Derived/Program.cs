using System;

namespace Derived
{
    class Animal
    {
        public string name = "Something";

        public void display()
        {
            Console.WriteLine("I am an animal");
        }
    }
    class Dog : Animal
    {
        public void getName()
        {
            Console.WriteLine("My name is " + name);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.display();
        }
    }
}

