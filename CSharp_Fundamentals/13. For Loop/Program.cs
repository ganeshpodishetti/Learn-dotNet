using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i=0; i<=10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
