using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    class LinkQueue
    {
        CustomLinkedList list1 = new CustomLinkedList();
        Node head;
        //public void Enqueue(int new_data)
        //{
        //    Node new_node = new Node(new_data);
        //    if (this.head==null)
        //    {
        //        this.head = new_node;
        //    }
        //    else
        //    {
        //        Node temp = this.head;
        //        while(temp.next!=null)
        //        {
        //            temp = temp.next;
        //        }
        //        temp.next = new_node;
        //    }
        //    Console.WriteLine("Inserted into List" +new_node.data);
        //}

        //method for adding element in queue using customlinkedlist
        public void LinkEnqueue(int new_data)
        {
            list1.InsertLast(new_data);
        }

        public void LinkQueueDisplay()
        {
            list1.Display();
        }

        //Display method for queue
        //public void Display()
        //{
        //    ///checking if stack is not empty
        //    ///printing values till temp point towards null i.e. end of stack 
        //    Node temp = this.head;
        //    if (temp == null)
        //    {
        //        Console.WriteLine("Queue is empty");
        //        return;
        //    }
        //    while (temp != null)
        //    {
        //        Console.WriteLine("Value in the queue : " + temp.data);
        //        temp = temp.next;
        //    }
        //}
    }   
}
