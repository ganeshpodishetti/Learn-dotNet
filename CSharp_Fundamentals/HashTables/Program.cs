using System;
using System.Collections;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table.Add("title", "web");

            var s = (String)table["title"];
            Console.WriteLine(s);
        }
    }
}
