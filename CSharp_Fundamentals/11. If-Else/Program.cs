using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 18;

            if (hour > 0 && hour < 12)
                Console.WriteLine("This is morning");
            else if (hour >= 12 && hour < 18)
                Console.WriteLine("This is after noon");
            else
                Console.WriteLine("It is eveing");

            // conditional statement

            bool gold = true;

            float price = (gold) ? 19.0f : 20.6f;
            Console.WriteLine(price);

        }
    }
}
