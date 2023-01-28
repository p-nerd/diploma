using System;
delegate void NChanger(int x);

namespace P13Delegates
{
    class Program
    {
        static int num = 10;
        public static void Add(int n)
        {
            num += n;
        }
        public static void Mul(int n)
        {
            num *= n;
        }
        public static void Calc(NChanger x, int n)
        {
            x(n);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(num);
            Calc(Add, 20);
            Console.WriteLine(num);
            Calc(Mul, 50);
            Console.WriteLine(num);
        }
    }
}
