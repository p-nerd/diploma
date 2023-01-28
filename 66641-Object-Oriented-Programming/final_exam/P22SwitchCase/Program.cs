using System;

namespace P22SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an alphabet: ");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }
        }
    }

}
