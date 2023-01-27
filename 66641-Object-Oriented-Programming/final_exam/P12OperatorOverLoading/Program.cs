using System;

namespace P12OperatorOverLoading
{
    class Office
    {
        public double salary;
        public Office()
        {
            salary = 0;
        }
        public Office(double sal)
        {
            salary = sal;
        }
        public static Office operator +(Office o, Office o2)
        {
            Office obj = new Office();
            obj.salary = o.salary + o2.salary;
            return obj;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Office a = new Office(1200);
            Office b = new Office(7880);
            Office sum = a + b;
            Console.WriteLine(sum.salary);
        }
    }

}
