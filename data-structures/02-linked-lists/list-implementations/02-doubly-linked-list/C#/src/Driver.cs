using static System.Console;

namespace DoublyLinkedList
{

    class DoublyLinkedListDriver { 
    
        static void Main()
        {
            DoublyLinkedList list = new();

            Node node_a = CreateNodeWithInternalDataOf(5);
            Node node_b = CreateNodeWithInternalDataOf(10);
            Node node_c = CreateNodeWithInternalDataOf(15);
            Node node_d = CreateNodeWithInternalDataOf(20);

            Node[] nodes = { node_a, node_b, node_c, node_d };

            WriteLine("\n\nAppending nodes to list...");
            foreach (Node node in nodes)
            {
                AppendNode(node, list);
            }
            WriteLine("Done appending nodes.");

            DisplayListState(list);
            list.DisplayList();

            ReadKey();
        }

        private static Node CreateNodeWithInternalDataOf(int data)
        {
            Node node = new(data);
            WriteLine("\nCreating new node...");
            WriteLine($"New Node Contents: {node.StringifyNode()}");
            return node;
        }

        private static void DisplayListState(DoublyLinkedList list)
        {
            WriteLine($"\nCurrent list size: {list.Size}");
            WriteLine($"Current Head node: {(list.HeadIsNull() ? "null" : list.Head!.StringifyNode())}");
        }

        private static void PrependNode(Node node, DoublyLinkedList list)
        {
            WriteLine($"\nPrepending {node.StringifyNode()} to list...");
            WriteLine($"Node was prepended: {list.PrependNode(node)}");
        }

        private static void AppendNode(Node node, DoublyLinkedList list)
        {
            WriteLine($"\nAppending {node.StringifyNode()} to list...");
            WriteLine($"Node was appended: {list.AppendNode(node)}");
        }

        private static void InsertNodeAtPosition(Node node, int position, DoublyLinkedList list)
        {
            WriteLine($"\nInserting {node.StringifyNode()} to list at position ${position}...");
            //WriteLine($"Node was inserted: {list.InsertNodeAtPosition(node, position)}");
        }

        private static void RemoveNodeAtPosition(int position, DoublyLinkedList list)
        {
            WriteLine($"\nRemoving the Node at position {position}...");
            //WriteLine($"Node removed was: {list.RemoveNodeAtPosition(position)?.StringifyNode()}");
        }
    }
}