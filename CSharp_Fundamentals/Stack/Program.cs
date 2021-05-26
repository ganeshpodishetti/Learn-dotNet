using System;
using System.Collections.Generic;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<String> pancakes = new Stack<string>();

            pancakes.Push("hi");
            pancakes.Push("hello");
            pancakes.Push("Namaste");

            foreach (var i in pancakes)
                Console.WriteLine("push : " + i);
            Console.WriteLine("pop : " + pancakes.Pop());
        }
    }
}
