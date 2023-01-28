namespace P15QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            c = Convert.ToInt32(Console.ReadLine());

            double d = b * b - 4 * a * c, s1, s2;
            if (d == 0)
            {
                Console.WriteLine("Both roots are equal.");
                s1 = -b / (2.0 * a);
                s2 = s1;

                Console.Write($"Both root = {s1}");
            }
            else if (d > 0)
            {
                Console.WriteLine("Both roots are real");

                s1 = (-b + Math.Sqrt(d)) / 2 * a;
                s2 = (-b - Math.Sqrt(d)) / 2 * a;

                Console.Write($"First root = {s1}");
                Console.Write($"Second root = {s2}");
            }
            else
            {
                Console.WriteLine("Root are imaginary;\nNot Solution.");
            }
        }
    }

}