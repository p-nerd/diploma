using System;

namespace P01SumOf2Numbers
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

            int sum = a + b;
            Console.WriteLine("Sum: " + sum);
            Console.ReadKey();
        }
    }

}