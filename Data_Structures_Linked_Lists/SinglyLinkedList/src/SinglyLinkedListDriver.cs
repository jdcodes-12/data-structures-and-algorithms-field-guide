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

            Console.Write("Current List: ");
            list.DisplayList();
        }
    }
  
}