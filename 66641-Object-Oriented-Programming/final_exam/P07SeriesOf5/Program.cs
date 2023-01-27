namespace P07SeriesOf5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.Write("Enter the n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 5; i <= n; i += 5)
            {
                sum += i;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }

}