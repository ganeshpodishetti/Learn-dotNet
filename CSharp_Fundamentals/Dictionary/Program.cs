using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> customer = new Dictionary<string, string>();

            customer.Add("Resolution", "1920x1080");
            customer.Add("title", "myweb");

            /* keys must be unique */
            Console.WriteLine(customer["title"]);

            foreach (var i in customer)
                Console.WriteLine(i);
        }
    }
}
