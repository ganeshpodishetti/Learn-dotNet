using System;

namespace ValidNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
            switch(n)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Valid");
                    break;
                default:
                    Console.WriteLine("Not valid");
                    break;
            }

            if (n >= 1 && n <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }

        public void max()
        {
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            var m = (a > b) ? a : b;
            Console.WriteLine(m);
        }
    }
}