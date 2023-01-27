using System;

namespace P10AreaOfCircle
{
    class Program
    {
        static float FindArea(float a, float b, float c)
        {
            if (a < 0 || b < 0 || c < 0 || (a + b <= c) || (b + c <= a) || (a + c <= b))
            {
                Console.WriteLine("Not a valid triangle");
                Environment.Exit(0);
            }
            float s = (a + b + c) / 2;
            float area = (float)Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
        static void Main(string[] args)
        {
            float a = 3.0f;
            float b = 4.0f;
            float c = 5.0f;
            Console.WriteLine("Area is: " + FindArea(a, b, c));
            Console.ReadKey();
        }
    }
}
