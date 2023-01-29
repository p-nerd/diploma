namespace P24Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine("Factorial: " + result);
            Console.ReadKey();
        }
    }
}