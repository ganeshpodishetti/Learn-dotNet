using System;

namespace _13._For_Each
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Ganesh";

            foreach (var chara in name)
                Console.WriteLine(chara);

            var l = new int[] { 1, 2, 3 };
            foreach (var i in l)
                Console.WriteLine(i);
        }
    }
}
