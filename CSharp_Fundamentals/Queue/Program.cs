using System;
using System.Collections.Generic;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<int> myQueue = new Queue<int>();

            for (var i = 1; i <= 5; i++)
                myQueue.Enqueue(i);

            foreach (var i in myQueue)
                Console.WriteLine("items in queue : {0}", i);

            Console.WriteLine("dequeue element : " + myQueue.Dequeue());
            Console.WriteLine("Top element : " + myQueue.Peek());
        }
    }
}
