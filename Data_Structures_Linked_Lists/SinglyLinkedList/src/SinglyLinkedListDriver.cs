using System.Collections.Generic;

namespace SinglyLinkedList 
{ 
    class SinglyLinkedListDriver {

        static void Main(string[] args)
        {
            SinglyLinkedList list = new SinglyLinkedList();
            Console.WriteLine($"Size: {list.Size}");

            Console.WriteLine("Creating 2 nodes to add...");
            Node node_A = new Node(5);
            Node node_B = new Node();

            Console.WriteLine("Nodes added: ");
            Console.WriteLine($"{node_A.StringifyNode()}");
            Console.WriteLine($"{node_B.StringifyNode()}");

            Console.WriteLine($"\nAdded node_a: {list.PrependNode(node_A)}");
            Console.WriteLine($"Added node_b: {list.PrependNode(node_B)}");

            DisplayCurrentList(list);

            Console.WriteLine("\nCreating a node to add...");
            Node node_C = new Node(200);
            Console.WriteLine($"Node appended: {list.AppendNode(node_C)}");

            DisplayCurrentList(list);

            Console.WriteLine("Removing head node...");
            Console.WriteLine($"Node removed is: {list.RemoveHeadNode()?.Data}");
            DisplayCurrentList(list);

            Console.WriteLine("Removing tail node...");
            Console.WriteLine($"Node removed is: {list.RemoveTailNode()?.Data}");
            DisplayCurrentList(list);

            Console.WriteLine($"List is empty: {list.IsEmpty()}");
            Console.WriteLine($"Current List Size: {list.Size}");
            Console.WriteLine($"Clearing list... {list.ClearList()}");
            Console.WriteLine($"Current List Size: {list.Size}");
            Console.WriteLine($"List is empty: {list.IsEmpty()}");
        }

        private static void DisplayCurrentList(SinglyLinkedList list)
        {
            Console.Write("\nCurrent List: ");
            list.DisplayList();
        }
    }
  
}