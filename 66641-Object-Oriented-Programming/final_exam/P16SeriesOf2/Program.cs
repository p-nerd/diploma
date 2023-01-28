namespace P16SeriesOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.Write("Enter the n: ");
            n = Convert.ToInt32(Console.ReadLine());

            // n = 10

            // sum = 
            // i = 6,
            // 12 <= 10 -> false
            for (int i = 2; i <= n; i = i + 2)
            {
                sum = sum + i;
            }
            // 
            Console.WriteLine("Sum: " + sum);
        }
    }

}