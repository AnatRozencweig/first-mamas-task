using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class LinkedList
    {
        public Node Head { get; set; }
        public LinkedList(Node head)
        {
            Head = head;
        }
        public void PrintLinkedList()
        {
            Node currentNode = Head;
            while (currentNode.Next != null)
            {
                Console.WriteLine(currentNode.Value.ToString());
                currentNode = currentNode.Next;
            }
            Console.WriteLine(currentNode.Value.ToString());
        }
        public void Append(int val)
        {
            Node currentNode = Head;
            Node lastNode = new Node(val);
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = lastNode;
        }
        public void Prepend(int val)
        {
            Node newHead = new Node(val, Head);
            Head = newHead;
        }
        public int Pop()
        {
            Node currentNode = Head;
            while (currentNode.Next.Next != null)
            {
                currentNode = currentNode.Next;
            }
            int lastNodeValue = currentNode.Next.Value;
            currentNode.Next = null;
            return lastNodeValue;
        }
    }
}
