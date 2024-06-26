﻿using System;
using System.Collections.Generic;

namespace MamasFirstProject
{
    class LinkedList
    {

        public Node Head { get; set; }
        public Node Tail { get; set; }
        public LinkedList(Node head)
        {
            Head = head;
            Node currentNode = Head;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            Tail = currentNode;
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
            Node newNode = new Node(val);
            Node lastNode = Tail;
            lastNode.Next = newNode;
            Tail = newNode;
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
            Tail = currentNode;
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
        public List<int> ConvertLinkedListToList()
        {
            Node currentNode = Head;
            List<int> allLinkedListValues = new List<int>();
            while (currentNode.Next != null)
            {
                allLinkedListValues.Add(currentNode.Value);
                currentNode = currentNode.Next;
            }
            allLinkedListValues.Add(currentNode.Value);
            return allLinkedListValues;
        }
        public IEnumerable<int> ToList()
        {
            List<int> allLinkedListValues = ConvertLinkedListToList();
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
        public void Sort()
        {
            List<int> allLinkedListValues = ConvertLinkedListToList();
            allLinkedListValues.Sort();
            Node newHead = new Node(allLinkedListValues[0]);
            Node currentNode = newHead;
            for (int i = 1; i < allLinkedListValues.Count; i++)
            {
                Node nextNode = new Node(allLinkedListValues[i]);
                currentNode.Next = nextNode;
                currentNode = nextNode;
            }
            Head = newHead;
            Tail = currentNode;
        }
        public Node GetMaxNode()
        {
            Sort();
            return Tail;
        }
        public Node GetMinNode()
        {
            Sort();
            return Head;
        }
    }
}
