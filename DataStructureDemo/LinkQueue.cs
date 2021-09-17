using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    class LinkQueue
    {
        Node head;
        //method for insert element in queue
        public void Enqueue(int new_data)
        {
            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
            Console.WriteLine("Inserted into List" + new_node.data);
        }
        public void Dequeue()
        {
            //if queue is empty,return null
            if(this.head==null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            //Store previous head, and move head pointer one step ahead
            Node temp = this.head;
            this.head = this.head.next;
            Console.WriteLine("Deleated element is:" +temp.data);
        }
        //Display method for queue
        public void Display()
        {
            ///checking if stack is not empty
            ///printing values till temp point towards null i.e. end of stack 
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Value in the queue : " + temp.data);
                temp = temp.next;
            }
        }
    }   
}
