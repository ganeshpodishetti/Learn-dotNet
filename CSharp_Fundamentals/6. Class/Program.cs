using System;
using Class.Math;

namespace Class
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is "+ FirstName + " " + LastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Ganesh = new Person();
            Ganesh.FirstName = Console.ReadLine();
            Ganesh.LastName = Console.ReadLine();
            Ganesh.Introduce();

            Calculator cal = new Calculator();
            var result = cal.Add(3, 2);
            Console.WriteLine(result);
        }
    }
}
