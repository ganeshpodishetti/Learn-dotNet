using System;

namespace _14._While_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            while (true)
            {
                Console.WriteLine("your name : ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;
            }
        }
    }
}
