using System;

namespace Chapter05
{
    class Program
    {
        static void IfElse()
        {
            int number = 6;
            if (number < 5)
            {
                Console.WriteLine("{0} is less then 5", number);
            }
            else if (number > 5)
            {
                Console.WriteLine("{0} is grater then 5", number);
            }
            else
            {
                Console.WriteLine("{0} is equal to 5", number);
            }
        }
        static void NestedIf()
        {
            int a = 100;
            int b = 200;

            if (a == 100)
            {
                if (b == 200)
                {
                    Console.WriteLine("Value of a is 100 and b is 200");
                }
            }
            Console.WriteLine("Exact value of a is: {0}", a);
            Console.WriteLine("Exact value of b is: {0}", b);
        }
        static void TernaryOperator()
        {
            int number = 4;
            string value = number % 2 == 0 ? "Even" : "Odd";
            Console.WriteLine($"{number} is {value}");
        }
        static void BreakContinue()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            // IfElse();
            // int a = 9;
            // int b = -17;

            // Console.WriteLine(a % b);
            // Console.WriteLine(a / b);
        }
    }
}