using System.Collections.Generic;
using System;

namespace _16._List
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = new List<int>() { 1, 2, 3, 4 };
            n.Add(5);
            n.AddRange(new int[3] { 6, 7, 8 });

            foreach (var i in n)
                Console.Write(i + " ");

            Console.WriteLine();
            Console.WriteLine("Index of 1 : " + n.IndexOf(1));

            Console.WriteLine("Last index of : " + n.LastIndexOf(1));

            Console.WriteLine("Count : " + n.Count);

            n.Remove(3);
            foreach (var i in n)
                Console.Write(i + " ");



        }
    }
}
