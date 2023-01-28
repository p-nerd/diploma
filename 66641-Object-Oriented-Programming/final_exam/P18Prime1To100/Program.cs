namespace P18Prime1To100
{
    class Program
    {
        static bool IsPrime(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            int root = (int)Math.Floor(Math.Sqrt(num));
            for (int i = 3; i <= root; i += 2)
            {
                if (num % 3 == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i + " is prime");
                }
            }
            Console.ReadKey();
        }
    }

}