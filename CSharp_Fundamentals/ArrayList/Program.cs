using System;
using System.Collections;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add("some string");
            int i = 123;
            object o = i;
            i = (int)o;
            String s = (String)list[0];
            Console.WriteLine(s);   
        }
    }
}
