using System;

namespace P03EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());

            if ((a % 2 == 0 && b % 2 == 1) || (a % 2 == 1 && b % 2 == 0))
                Console.WriteLine("False");
            else
                Console.WriteLine("True");

            Console.ReadKey();
        }
    }
}
