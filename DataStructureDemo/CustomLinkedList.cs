using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{/// <summary>
/// Template for testing linked list
/// </summary>
    class CustomLinkedList
    {/// <summary>
    /// UC2 insert a element at front in linked list
    /// </summary>
        Node head;
        
        //creating method for inserting elements at last
        public void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if(this.head==null)
            {
                this.head = new_node;
            }
            else 
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("Inserted into list:" + new_node.data);
        }

       //method for getting the last node
        public Node GetLastNode()
        {
            Node temp = this.head;
            while(temp.next!=null)
            {
                temp = temp.next;
            }
            return temp;
        }

       //method for inserting element at front
       public void InsertFront(int new_data)
        {
            //We will create a new node.The next of the node will point to the head of the linked list
            Node new_node = new Node(new_data);
            //When we want to add any node at the front,we want the head to point to it.
            new_node.next = this.head;
            //The previous Head node is now the second node of the linked list because the new node is added at the front 
            this.head = new_node;
            Console.WriteLine("Inserted into list" +new_node.data);
        }

       //method for displaying elements in linked list
       public void Display()
        {
            Console.WriteLine("Displaying Nodes");
            Node temp = this.head;
            if (temp==null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            else
            {
                while(temp!=null)
                {
                    Console.WriteLine(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
