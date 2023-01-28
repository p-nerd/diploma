using System;
delegate int NChanger(int x);

namespace P13Delegates
{
    class Program
    {
        static int num = 10;
        public static int Add(int n)
        {
            num += n;
            return num;
        }
        public static int Mul(int n)
        {
            num *= n;
            return num;
        }
        static void Main(string[] args)
        {
            NChanger nc1 = new NChanger(Add);
            NChanger nc2 = new NChanger(Mul);

            nc1(25);
            Console.WriteLine($"Value of num: {num}");

            nc2(5);
            Console.WriteLine($"Value of num: {num}");

            Console.ReadKey();
        }
    }
}
