using System;

namespace Tuple1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tradational way
            // Tuple<int, String, bool> myTuple = new Tuple<int, string, bool>(1, "Ganesh", true);

            // New way
            var myTuple = Tuple.Create(2, "g", false);

            Console.WriteLine(myTuple.Item1);
        }
    }
}
