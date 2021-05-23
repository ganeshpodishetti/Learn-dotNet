﻿using System;

namespace _22._ProcedureLang
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine("Reversed Name : " + reversed);
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];
            return new string(array);
        }

    }
}
