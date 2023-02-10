#region
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
            PrependNode(node_a, list);
            list.DisplayList();

            Node node_b = CreateNodeWithInternalDataOf(10);
            AppendNode(node_b, list);
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
            WriteLine("\nPrepending node to list...");
            WriteLine($"{node.StringifyNode()} was prepended: {list.PrependNode(node)}");
        }

        private static void AppendNode(Node node, SinglyLinkedList list)
        {
            WriteLine("\nAppending node to list...");
            WriteLine($"{node.StringifyNode()} was appended: {list.AppendNode(node)}");
        }
    }
}