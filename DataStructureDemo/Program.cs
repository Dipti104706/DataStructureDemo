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
            queue.LinkEnqueue(56);
            queue.LinkEnqueue(30);
            queue.LinkEnqueue(70);
            queue.LinkQueueDisplay();
            Console.ReadLine();
        }
    }
}
