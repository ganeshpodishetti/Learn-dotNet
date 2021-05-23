using System;
using System.Collections.Generic;

namespace String2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = " This is going to be really really really long text.";
            var summary = StringUtility.summaryText(sentence);

            Console.WriteLine(summary);
        }
    }
}
