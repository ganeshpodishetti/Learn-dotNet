using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Winter;

            switch(season)
            {
                case Season.Spring:
                    Console.WriteLine("this is winter");
                    break;
                case Season.Summer:
                    Console.WriteLine("this is summer");
                    break;
                default:
                    Console.WriteLine("spring");
                    break;
            }
        }
    }
}
