using System;
using System.Collections.Generic;

namespace Hash_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHash = new HashSet<String>();

            myHash.Add("hello");
            myHash.Add("hello");

            String[] s = new String[] { "hello" };

            Console.WriteLine(myHash.Count);
            Console.WriteLine(myHash.Overlaps(s));
        }
    }
}
