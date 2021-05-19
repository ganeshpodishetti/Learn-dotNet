using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit conversion

            byte a = 1;
            int i = a;
            Console.WriteLine(i);

            int x = 10;
            float z = x;
            Console.WriteLine(z);

            // Explicit conversion

            float b = 11.9f;
            int c = (int)b;
            Console.WriteLine(c);

            // Non-compitable

            string s = "1";
            int r = Convert.ToInt32(s);
            int j = int.Parse(s);
            Console.WriteLine(r);
            Console.WriteLine(j);
        }
    }
}
