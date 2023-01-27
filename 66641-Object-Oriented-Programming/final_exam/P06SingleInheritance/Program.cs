using System;

namespace P06SingleInheritance
{
    class Employee
    {
        public float salary = 40000;
    }
    class Programmer : Employee
    {
        public float bonus = 10000;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Programmer p = new Programmer();
            Console.WriteLine("Salary: " + p.salary);
            Console.WriteLine("Bonus: " + p.bonus);
        }
    }

}