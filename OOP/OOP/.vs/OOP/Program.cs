using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Node c = new Node(3);
            Node b = new Node(2, c);
            Node a = new Node(1, b);
            LinkedList abc = new LinkedList(a);
            abc.Append(4);
            abc.Prepend(0);
            abc.PrintLinkedList();
            Console.WriteLine();
            Console.WriteLine(abc.Unqueue().ToString());
            Console.WriteLine();
            abc.PrintLinkedList();

        }

    }
}
