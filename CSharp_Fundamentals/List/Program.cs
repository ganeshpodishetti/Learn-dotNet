using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> customer = new List<string>();
            customer.Add("ganesh");
            customer.Add("ga");
            customer.Add("gaa");

            Console.WriteLine("Count list : " + customer.Count);

            foreach (var i in customer)
                Console.WriteLine("list items : " + i);

            Console.WriteLine("last customer : " + customer[2]);
        }
    }
}
