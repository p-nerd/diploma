namespace P17FactorialRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = Factorial(number);
            Console.WriteLine("Factorial: " + result);
            Console.ReadKey();
        }
        static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
    }

}