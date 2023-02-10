#region
using System.Xml.Linq;
using static System.Console;
#endregion

namespace SinglyLinkedList
{ 
    class SinglyLinkedListDriver {
        static void Main()
        {
            SinglyLinkedList list = new();
            DisplayListState(list);

            Node node_a = CreateNodeWithInternalDataOf(5);
            Node node_b = CreateNodeWithInternalDataOf(10);
            Node node_c = CreateNodeWithInternalDataOf(15);
            Node node_d = CreateNodeWithInternalDataOf(20);
            Node node_e = CreateNodeWithInternalDataOf(25);
            Node node_f = CreateNodeWithInternalDataOf(30);
            Node node_g = CreateNodeWithInternalDataOf(35);

            WriteLine("Populating list with nodes...");
            Node[] nodes = { node_a, node_b, node_c, node_d, node_e };
           
            foreach (Node node in nodes) {
                AppendNode(node, list);
            }
            WriteLine("Done populating.\n");

            DisplayListState(list);

            // Change head node
            PrependNode(node_f, list);
            DisplayListState(list);

            InsertNodeAtPosition(node_g, 2, list);
            DisplayListState(list);
            list.DisplayList();

            RemoveNodeAtPosition(2, list);
            DisplayListState(list);
            list.DisplayList();

            WriteLine($"List is empty: {list.IsEmpty()}");
            WriteLine($"Clearing list... {list.ClearList()}");
            list.DisplayList();
            DisplayListState(list);

            ReadKey();
        }

        private static Node CreateNodeWithInternalDataOf(int data)
        {
            Node node = new(data);
            WriteLine("\nCreating new node...");
            WriteLine($"New Node Contents: {node.StringifyNode()}");
            return node;
        }
        
        private static void DisplayListState(SinglyLinkedList list)
        {
            WriteLine($"\nCurrent list size: {list.Size}");
            WriteLine($"Current Head node: {(list.HeadIsNull() ? "null" : list.Head!.StringifyNode())}");
        }

        private static void PrependNode(Node node, SinglyLinkedList list)
        {
            WriteLine($"\nPrepending {node.StringifyNode()} to list...");
            WriteLine($"Node was prepended: {list.PrependNode(node)}");
        }

        private static void AppendNode(Node node, SinglyLinkedList list)
        {
            WriteLine($"\nAppending ${node.StringifyNode()} to list...");
            WriteLine($"Node was appended: {list.AppendNode(node)}");
        }

        private static void InsertNodeAtPosition(Node node, int position, SinglyLinkedList list)
        {
            WriteLine($"\nInserting {node.StringifyNode()} to list at position ${position}...");
            WriteLine($"Node was inserted: {list.InsertNodeAtPosition(node, position)}");
        }

        private static void RemoveNodeAtPosition(int position, SinglyLinkedList list)
        {
            WriteLine($"\nRemoving the Node at position {position}...");
            WriteLine($"Node removed was: {list.RemoveNodeAtPosition(position)?.StringifyNode()}");
        }
    }
}