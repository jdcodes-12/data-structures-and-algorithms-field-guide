using static System.Console;

namespace DataStructuresLib
{
    public class SinglyLinkedList
    {
        public int Size { get; set; }

        public SingleLinkNode? Head { get; set; }

        public SinglyLinkedList()
        {
            Size = 0;
            Head = null;
        }

        public bool PrependNode(SingleLinkNode node)
        {
            if (NodeIsNull(node)) return false;

            else if (HeadIsNull())
            {
                Head = node;
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

        public bool AppendNode(SingleLinkNode node)
        {
            if (NodeIsNull(node)) return false;

            else if (HeadIsNull())
            {
                Head = node;
                Size++;
                return true;
            }

            else
            {
                SingleLinkNode? tail = TraverseToTail();

                if (tail == null) return false;

                else
                {
                    tail.NextLink = node;
                    Size++;
                    return true;
                }
            }
        }

        public bool InsertNodeAtPosition(SingleLinkNode node, int position)
        {
            if (NodeIsNull(node)) return false;

            else if (HeadIsNull())
            {
                Head = node;
                Size++;
                return true;
            }

            else
            {
                if (position > Size) return false;

                else
                {
                    // Grab node before position & node at position
                    SingleLinkNode? nodeAtPosition = TraverseToNodeAtPosition(position);
                    SingleLinkNode? nodeBeforePosition = TraverseToOneNodeBeforePosition(position);

                    node.NextLink = nodeAtPosition;
                    nodeBeforePosition!.NextLink = node;
                    Size++;
                    return true;
                }
            }
        }

        public SingleLinkNode? RemoveHead()
        {
            if (HeadIsNull()) return null;

            else
            {
                SingleLinkNode oldHeadNode = Head;

                if (OnlyHeadNode())
                {
                    Head = null;
                    Size--;
                    return oldHeadNode;
                }

                else
                {
                    Head = Head?.NextLink;
                    Size--;
                    return oldHeadNode;
                }
            }
        }

        public SingleLinkNode? RemoveTail()
        {
            if (HeadIsNull()) return null;

            else
            {
                SingleLinkNode oldHead = Head!;

                if (OnlyHeadNode())
                {
                    Head = null;
                    Size--;
                    return oldHead;
                }

                else
                {
                    // TODO: Create a function that grabs previous node before nodeAtposition
                    SingleLinkNode? nodeBeforeTail = TraverseToNodeAtPosition(Size - 2);
                    SingleLinkNode oldTail = nodeBeforeTail?.NextLink;
                    nodeBeforeTail.NextLink = null;
                    Size--;
                    return oldTail;
                }
            }
        }

        public SingleLinkNode? RemoveNodeAtPosition(int position)
        {
            if (HeadIsNull()) return null;

            else
            {
                if (position > Size) return null;

                else
                {
                    SingleLinkNode? nodeToReturn = TraverseToNodeAtPosition(position);
                    SingleLinkNode? nodeBeforePosition = TraverseToOneNodeBeforePosition(position);

                    nodeBeforePosition!.NextLink = nodeToReturn!.NextLink;
                    Size--;
                    return nodeToReturn;
                }
            }
        }

        public bool ClearList()
        {
            Head = null;
            Size = 0;
            return true;
        }

        public bool IsEmpty() => Size == 0;

        public void DisplayList()
        {
            if (IsEmpty())
                Write("[]");

            else if (OnlyHeadNode())
                WriteLine($"\nCurrent List: [{Head?.Data}]");

            else
            {
                SingleLinkNode? traversalPointer = Head;
                int moves = 0;

                Write("\nCurrent List: [");
                while (traversalPointer != null)
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

        private static bool NodeIsNull(SingleLinkNode node) => node == null;

        public bool HeadIsNull() => Head == null;

        private SingleLinkNode? TraverseToTail()
        {
            if (HeadIsNull()) return null;

            SingleLinkNode? traversalPointer = Head;

            while (traversalPointer?.NextLink != null)
            {
                traversalPointer = traversalPointer.NextLink;
            }

            return traversalPointer;
        }

        private SingleLinkNode? TraverseToNodeAtPosition(int position)
        {
            if (position > Size) return null;

            SingleLinkNode? traversalPointer = Head;

            int moves = 0;

            while (moves < position)
            {
                traversalPointer = traversalPointer?.NextLink;
                moves++;
            }

            return traversalPointer;
        }

        private SingleLinkNode? TraverseToOneNodeBeforePosition(int position)
        {
            int moves = 0;
            SingleLinkNode? traversalPointer = Head;

            while (moves < position - 1)
            {
                traversalPointer = traversalPointer!.NextLink;
                moves++;
            }

            return traversalPointer;
        }

        private bool OnlyHeadNode() => Size == 1;
    }
}