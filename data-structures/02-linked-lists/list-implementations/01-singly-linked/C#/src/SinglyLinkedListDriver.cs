#region
using static System.Console;
using DataStructuresLib;
#endregion

namespace SinglyLinkedListImp
{
    class SinglyLinkedListDriver
    {
        static void Main()
        {
            SinglyLinkedList list = new();
            DisplayListState(list);

            SingleLinkNode node_a = CreateNodeWithInternalDataOf(5);
            SingleLinkNode node_b = CreateNodeWithInternalDataOf(10);
            SingleLinkNode node_c = CreateNodeWithInternalDataOf(15);
            SingleLinkNode node_d = CreateNodeWithInternalDataOf(20);
            SingleLinkNode node_e = CreateNodeWithInternalDataOf(25);
            SingleLinkNode node_f = CreateNodeWithInternalDataOf(30);
            SingleLinkNode node_g = CreateNodeWithInternalDataOf(35);

            WriteLine("Populating list with nodes...");
            SingleLinkNode[] nodes = { node_a, node_b, node_c, node_d, node_e };

            foreach (SingleLinkNode node in nodes)
            {
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

        private static SingleLinkNode CreateNodeWithInternalDataOf(int data)
        {
            SingleLinkNode node = new(data);
            WriteLine("\nCreating new node...");
            WriteLine($"New Node Contents: {node.StringifyNode()}");
            return node;
        }

        private static void DisplayListState(SinglyLinkedList list)
        {
            WriteLine($"\nCurrent list size: {list.Size}");
            WriteLine($"Current Head node: {(list.HeadIsNull() ? "null" : list.Head!.StringifyNode())}");
        }

        private static void PrependNode(SingleLinkNode node, SinglyLinkedList list)
        {
            WriteLine($"\nPrepending {node.StringifyNode()} to list...");
            WriteLine($"Node was prepended: {list.PrependNode(node)}");
        }

        private static void AppendNode(SingleLinkNode node, SinglyLinkedList list)
        {
            WriteLine($"\nAppending ${node.StringifyNode()} to list...");
            WriteLine($"Node was appended: {list.AppendNode(node)}");
        }

        private static void InsertNodeAtPosition(SingleLinkNode node, int position, SinglyLinkedList list)
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