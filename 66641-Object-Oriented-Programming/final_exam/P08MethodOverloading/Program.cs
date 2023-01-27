namespace P08MethodOverloading
{
    class Program
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int sum1 = p.Add(1, 2);
            Console.WriteLine("sum of two: " + sum1);
            int sum2 = p.Add(1, 2, 3);
            Console.WriteLine("sum of three: " + sum2);
            Console.ReadKey();
        }
    }

}
