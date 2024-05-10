using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamasFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Node d = new Node(5);
            Node c = new Node(9, d);
            Node b = new Node(1, c);
            Node a = new Node(2, b);
            LinkedList abc = new LinkedList(a);
            abc.PrintLinkedList();
            Console.WriteLine();
            Console.WriteLine(abc.GetMaxNode().Value);
            Console.WriteLine();
            abc.PrintLinkedList();
        }
    }
}
