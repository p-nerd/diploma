using System;

namespace SWitchStatement
{
    class SwitchCase
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter an alphabet");
            var x = Console.ReadLine();
            if (x == null) {
                ch = 'c';
                return;
            }
            ch = Convert.ToChar(x);

            switch (Char.ToLower(ch))
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