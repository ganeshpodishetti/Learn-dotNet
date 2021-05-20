using System;

namespace _15._Random_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (var i = 0; i <= 10; i++)
                Console.Write((char)random.Next(97, 122));
            Console.WriteLine();

            var buffer = new char[10];
            for (var i = 0; i < 10; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));
            var password = new string(buffer);
            Console.WriteLine(password);

            Console.WriteLine((int)'a');
        }
    }
}
