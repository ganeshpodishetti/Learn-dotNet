using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = new int[3];
            n[0] = 2;

            Console.WriteLine(n[0]);   // 2
            Console.WriteLine(n[1]);   // 0
            Console.WriteLine(n[2]);   // 0

            var flag = new bool[3];
            flag[0] = true;

            Console.WriteLine(flag[0]);  // True
            Console.WriteLine(flag[1]);  // False
            Console.WriteLine(flag[2]);  // False

            var names = new string[3] { "hi", "hello", "namaste" };

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
        }
    }
}
