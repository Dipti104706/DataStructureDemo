using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList < int > list= new LinkedList<int>();
            //list.AddLast(56);
            //list.AddLast(30);
            //list.AddLast(70);

            LinkQueue queue = new LinkQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine("The queue before deletion:");
            queue.Display();
            queue.Dequeue();
            Console.WriteLine("The queue after deletion:");
            queue.Display();
            Console.ReadLine();
        }
    }
}
