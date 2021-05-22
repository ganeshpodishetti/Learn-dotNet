using System;

namespace _18._Time_Span
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating time span
            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine(timeSpan);

            var timeSpan2 = new TimeSpan(1, 0, 0);
            var timeSpan3 = TimeSpan.FromHours(1);
            Console.WriteLine(timeSpan3);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration : " + duration);

            // properties
            Console.WriteLine("minutes : " + timeSpan.Minutes);
            Console.WriteLine("Total minutes : " + timeSpan.TotalMinutes);

            // Add
            Console.WriteLine("Add example : " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Substract : " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // ToString
            Console.WriteLine("To string : " + timeSpan.ToString());

            // Parse
            Console.WriteLine("Parse : " + TimeSpan.Parse("01:03:02"));
        }
    }
}
