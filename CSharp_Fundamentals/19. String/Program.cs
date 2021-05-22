using System;

namespace _19._String
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Ganesh Podishetti";
            Console.WriteLine("Trim : " + fullName.Trim());
            Console.WriteLine("ToUpper : " + fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("first name : " + firstName);
            Console.WriteLine("last name : " + lastName);

            var name = fullName.Split(' ');
            Console.WriteLine("first name : " + name[0]);
            Console.WriteLine("last name : " + name[1]);

            Console.WriteLine(fullName.Replace("Ganesh", "Sandhya"));

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float p = 29.01f;
            var a = p.ToString("C0");
            Console.WriteLine(a);
        }
    }
}
