using System;

namespace VariableDataTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* 
            Value Types:
                Integers
                    - short, ushort -> 2bytes -> 16bits
                    - int, uint     -> 4bytes -> 32bits
                    - long, ulong   -> 8bytes -> 64bits
                Floating Points
                    - float
                    - double
                Characters
                    - char
                Boolean
                    - bool
            */

            bool isAdult = true;
            isAdult = false;
            Console.WriteLine(isAdult);


            /*
            Reference Types:
                1. string
                2. array
                3. object
                4. class
                5. delegate
            */
            string name = "Shihab Mahamud";
            Console.WriteLine(name);

            string[] names = new string[100];

            /*
            Pointers Types;
            */
            // int x = 11;
            // int* p = &x;
            // Console.WriteLine((int)p);

            /*
                Type Conversion
                    - Implicit
                    - Explict
             */
            int a = 10;
            double b = a;

            Console.WriteLine(a);
            Console.WriteLine(b);

            double x = 23.44;
            int y = (int)x;

            Console.WriteLine(x);
            Console.WriteLine(y);

            // Constants
            const double PI = 3.1416;
            Console.WriteLine(PI);

            /*
            Literals
                - Numeric
                    - Integer
                        - Decimal
                        - Hexadecimal
                    - Real
                - Boolean
                - Characters
                    - Single Character ''
                    - String ""
            
            */
            int de = 100;
            int hx = 0x4F;
            Console.WriteLine(de);
            Console.WriteLine(hx);

            float f = 123.22f;
            // float f2 = 123.22; // error
            double d = 234.555;
            Console.WriteLine(f);
            Console.WriteLine(d);

            bool is_valid = true;
            is_valid = false;
            Console.WriteLine(is_valid);

            char c = 'c';
            string ss = "Hello World";
            Console.WriteLine(c);
            Console.WriteLine(ss);
        }
    }
}
