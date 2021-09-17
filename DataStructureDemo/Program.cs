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

            LinkedStack stack = new LinkedStack();
            stack.LinkPush(70);
            stack.LinkPush(30);
            stack.LinkPush(56);
            stack.LinkStackDisplay();
            //stack.Peek();
            //stack.Pop();
            //stack.IsEmpty();
            //CustomLinkedList obj1 = new CustomLinkedList();
            //obj1.InsertLast(70);
            //obj1.InsertLast(56);
            //obj1.InsertLast(30);
            //obj1.Display();
            Console.ReadLine();
        }
    }
}
