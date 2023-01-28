using System;

namespace P23MaxOf3Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            c = Convert.ToInt32(Console.ReadLine());

            int largest = a;
            if (b > largest)
            {
                largest = b;
            }
            if (c > largest)
            {
                largest = c;
            }
            Console.WriteLine("Largest: " + largest);
            Console.ReadKey();
        }
    }
}
