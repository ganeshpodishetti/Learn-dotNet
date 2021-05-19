using System;

namespace Enum
{
    public enum Week
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = Week.Saturday;
            Console.WriteLine((int)method);

            var methodId = 6;
            Console.WriteLine((Week)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Monday";
            var result = (Week) Week.Parse(typeof(Week), methodName);
            Console.WriteLine(result);
        }
    }
}
