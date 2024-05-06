using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamasFirstProject
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
        public int Unqueue()
        {
            Node headNext = Head.Next;
            int FirstNodeValue = Head.Value;
            Head.Next = null;
            Head = headNext;
            return FirstNodeValue;
        }
        public IEnumerable<int> ToList()
        {
            Node currentNode = Head;
            List<int> allLinkedListValues = new List<int>();
            while (currentNode.Next != null)
            {
                allLinkedListValues.Add(currentNode.Value);
                currentNode = currentNode.Next;
            }
            IEnumerable<int> allLinkedListValuesIEnumerble = allLinkedListValues;
            return allLinkedListValuesIEnumerble;
        }
        public bool IsCircular()
        {
            Node currentNode = Head;
            while (currentNode.Next != null)
            {
                if (currentNode.Next == Head)
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }
    }
}
