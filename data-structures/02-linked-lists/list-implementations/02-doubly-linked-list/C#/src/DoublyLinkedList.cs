using System.Runtime.InteropServices;
using static System.Console;

namespace DoublyLinkedList
{ 
    class DoublyLinkedList
    {
        public int Size { get; set; }
        public Node? Head { get; set; }
        public Node? Tail { get; set; }

        public DoublyLinkedList()
        {
            Size = 0;
            Head = null;
            Tail = null;
        }

        public bool PrependNode(Node node)
        {
            if (NodeIsNull(node)) return false;

            else if (HeadIsNull())
            {
                Head = node;
                Tail = Head;
                Size++;
                return true;
            }

            else if (OnlySingleNode())
            {
                Head!.NextLink = node;
                Tail = node;
                Size++;
                return true;
            }

            else
            {
                node.NextLink = Head;
                Head = node;
                Size++;
                return true;
            }
        }

        public bool AppendNode(Node node)
        {
            if (NodeIsNull(node)) return false;

            else if (HeadIsNull())
            {
                Head = node;
                Tail = node;
                Size++;
                return true;
            }

            else if (OnlySingleNode())
            {
                Head!.NextLink = node;
                Tail = node;
                Size++;
                return true;
            }
            
            else
            {
                if (TailIsNull())
                {
                    UpdateTailPointer();
                    Tail.NextLink = node;
                    node.PrevLink = Tail;
                    Size++;
                    return true;
                }

                Tail!.NextLink = node;
                node.PrevLink = Tail;
                Size++;
                return true;
            }
        }

        // InsertNodeAtPosition(Node node, int position)
        // RemoveHead()
        // RemoveTail()
        // RemoveNodeAtPosition()
        public void DisplayList()
        {
            if (IsEmpty())
                WriteLine("[]");

            else if (OnlySingleNode())
                WriteLine($"\nCurrent List: [{Head!.Data}]");

            else
            {
                Node? traversalPointer = Head;
                int moves = 0;

                Write("\nCurrent List: [");
                while (NodeHasNextLink(traversalPointer))
                {
                    if (moves == Size - 1)
                    {
                        Write($"{traversalPointer.Data}");
                        traversalPointer = traversalPointer.NextLink;
                        moves++;
                    }

                    else
                    {
                        Write($"{traversalPointer.Data}, ");
                        moves++;
                        traversalPointer = traversalPointer.NextLink;
                    }
                }
                WriteLine("]");
            }
        }

        public bool IsEmpty() => Size <= 0;
        public bool ClearList()
        {
            Size = 0;
            Head = null;
            Tail = null;
            return true;
        }
        

        // Pointer Updates
        private void UpdateTailPointer()
        {
            if (HeadIsNull()) return;

            else if (OnlySingleNode())
                Tail = Head;

            else
            {
                Node? currentTail = TraverseToTail_FromHead();

                if (NodeIsNull(currentTail!)) return;

                else
                    Tail = currentTail;
            }
        }


        // List Size Checks
        private bool OnlySingleNode() => Size == 1;

        // Head & Tail Node Checks

        /* `public` b/c need to expose for console output conditional formatting */
        public bool HeadIsNull() => Head == null; 
        private bool HeadHasNextLink() => Head?.NextLink != null;
        private bool TailIsNull() => Tail == null;
        private bool TailHasPrevLink() => Tail?.NextLink != null;

        // Arbitrary Node Checks
        private bool NodeHasNextLink(Node node) => node.NextLink != null;
        private bool NodeHasPrevLink(Node node) => node.PrevLink != null;
        private bool NodeIsNull(Node node) => node == null;
       
        // Node "Grabbing"
        private Node? GrabPrevLinkOf(Node node)
        {
            if (NodeIsNull(node)) return null;

            if (NodeHasPrevLink(node)) return node.PrevLink;
            else return null;
        }

        private Node? GrabNextLinkOf(Node node)
        {
            if (NodeIsNull(node)) return null;

            if (NodeHasNextLink(node)) return node.NextLink;
            else return null;
        }

        // List Traversal
        private Node? TraverseToTail_FromHead()
        {
            if (HeadIsNull()) return null;

            Node? traversalNode = Head;
            
            while(NodeHasNextLink(traversalNode!))            
                traversalNode = traversalNode!.NextLink;
            
            return traversalNode;
        }
        // TraverseToPosition_FromHead()
        // TraverseToPosition_FromTail()
        // TraverseToNodeBeforePosition_FromHead()
        // TraverseToNodeBeforePosition_FromTail()

    }
}