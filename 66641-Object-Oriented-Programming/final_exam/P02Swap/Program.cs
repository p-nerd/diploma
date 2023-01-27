using System;

namespace P02Swap
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

            Console.WriteLine($"Before a:{a}, b:{b}");
            int tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine($"After a:{a}, b:{b}");
        }
    }
}
