using System;

namespace P05MultilevelInheritance
{
    class Grandfather
    {
        public void DisplayOne()
        {
            Console.WriteLine("Grandfather ...");
        }
    }
    class Father : Grandfather
    {
        public void DisplayTwo()
        {
            Console.WriteLine("Father ...");
        }
    }
    class Son : Father
    {
        public void DisplayThree()
        {
            Console.WriteLine("Son ...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Son s = new Son();
            s.DisplayOne();
            s.DisplayTwo();
            s.DisplayThree();
        }
    }

}