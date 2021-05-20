using System;

namespace _16._Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = new[] { 1, 2, 3, 4, 5 };

            // Length
            Console.WriteLine("Length : " + n.Length);

            // IndexOf
            var index = Array.IndexOf(n, 5);
            Console.WriteLine("IndexOf : " + index);

            // Clear()
            Array.Clear(n, 0, 2);

            Console.WriteLine("effect of clear");
            foreach (var i in n)
                Console.Write(i + " ");
            Console.WriteLine();

            // Copy
            int[] another = new int[2];
            Array.Copy(n, another, 2);

            Console.WriteLine("effect of copy");
            foreach (var i in another)
                Console.Write(i + " ");

            // Sort
            Array.Sort(n);

            Console.WriteLine("effect of sor");
            foreach (var i in n)
                Console.Write(i + " ");

            // reverse
            Array.Reverse(n);
            Console.WriteLine("effect of reverse");
            foreach (var i in n)
                Console.Write(i + " ");
        }
    }
}
