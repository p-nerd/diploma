namespace P09Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a = 0, b = 1, c;
            Console.Write("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write(a + " " + b + " ");
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }

}
