using System;

namespace Reference_Type
{
    class Program
    {
        public class Person
        {
            public int age;
        }
        static void Main(string[] args)
        {
            var n = 1;
            Increment(n);
            Console.WriteLine(n);

            var p = new Person() { age = 20 };
            MakeOld(p);
            Console.WriteLine(p.age);
        }

        public static void Increment(int n)
        {
            n += 10;
        }

        public static void MakeOld(Person p)
        {
            p.age += 10;
        }
    }
}
