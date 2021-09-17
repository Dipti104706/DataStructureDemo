using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    class LinkedStack
    {
        CustomLinkedList list1 = new CustomLinkedList();
        //UC1 create a stack using linked list
        public Node top;
        public void Push(int newData)
        {
            ///creating a link between newnode and where top is pointing
            ///then pointing top towards the new node 
            ///new node is inserted on the top 
            Node newNode = new Node(newData);
            if (this.top != null)
            {
                newNode.next = this.top; // newnode will hold the address of top element
            }
            this.top = newNode;// top will point to new element
            Console.WriteLine("New node {0} is added", newNode.data);
            //Using linked list method by association
            
        }

        public void LinkPush(int new_data)
        {
            list1.InsertLast(new_data);
        }

        public void LinkStackDisplay()
        {
            list1.Display();
        }
        //method for peek in a stack means display top element
        public void Peek()
        {
            ///Checking if top element is null
            ///otherwise printing the top element
            if (this.top == null)
            {
                Console.WriteLine("no element present to Peek");
                return;
            }
            Console.WriteLine("Top most element " + this.top.data);
        }

        //
        public void Pop()
        {
            ///Checking if top element is null
            ///otherwise printing the top element and deleting it also
            if (this.top == null)
            {
                Console.WriteLine("no element present to Pop");
                return;
            }
            //Console.WriteLine("The element poped is " + this.top.data);
            int deleteNode = this.top.data;
            Peek();
            this.top = this.top.next;
            Console.WriteLine("Deleted element is {0}", deleteNode);
        }

        //method to delete node till stack is empty
        public void IsEmpty()
        {
            while (this.top != null)
            {
                Pop();
            }
        }

        //method for displaying the stack
        public void Display()
        {
            ///checking if stack is not empty
            ///printing values till temp point towards null i.e. end of stack 
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Value in the stack : " + temp.data);
                temp = temp.next;
            }
        }
    }
}
