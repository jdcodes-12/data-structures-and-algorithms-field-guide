#region
using System.ComponentModel.Design;
using static System.Console;
#endregion

namespace SinglyLinkedList
{
    class SinglyLinkedList
    {
        public int Size { get; set; }
        
        public Node? Head { get; set; }
        
        public SinglyLinkedList()
        {
            Size = 0;
            Head = null;
        }
       
        public bool PrependNode(Node node)
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
        
        public bool AppendNode(Node node)
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
                Node? tail = TraverseToTail();

                if (tail == null) return false;

                else
                {
                    tail.NextLink = node;
                    Size++;
                    return true;
                }
            }
        }

        public bool InsertNodeAtPosition(Node node, int position)
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
                    Node? nodeAtPosition = TraverseToNodeAtPosition(position);
                    Node? nodeBeforePosition = TraverseToOneNodeBeforePosition(position);
                    
                    node.NextLink = nodeAtPosition;
                    nodeBeforePosition!.NextLink = node;
                    Size++;
                    return true;
                }
            }
        }

        public Node? RemoveHead()
        {
            if (HeadIsNull()) return null;
            
            else
            {
                Node oldHeadNode = Head;
                
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

        public Node? RemoveTail()
        {
            if (HeadIsNull()) return null;

            else
            {
                Node oldHead = Head!;

                if (OnlyHeadNode()) {
                    Head = null;
                    Size--;
                    return oldHead;
                }

                else
                {
                    // TODO: Create a function that grabs previous node before nodeAtposition
                    Node? nodeBeforeTail = TraverseToNodeAtPosition(Size - 2);
                    Node oldTail = nodeBeforeTail?.NextLink;
                    nodeBeforeTail.NextLink = null;
                    Size--;
                    return oldTail;
                }
            }
        }
        
        public Node? RemoveNodeAtPosition(int position)
        {
            if (HeadIsNull()) return null;
            
            else
            {
                if (position > Size) return null;

                else 
                {
                    Node? nodeToReturn = TraverseToNodeAtPosition(position);
                    Node? nodeBeforePosition = TraverseToOneNodeBeforePosition(position);

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
                Node? traversalPointer = Head;
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
        
        private static bool NodeIsNull(Node node) => node == null;
        
        public bool HeadIsNull() => Head == null;
        
        private Node? TraverseToTail()
        {
            if (HeadIsNull()) return null;

            Node? traversalPointer = Head;
            
            while (traversalPointer?.NextLink != null)
            {
                traversalPointer = traversalPointer.NextLink;
            }

            return traversalPointer;
        }

        private Node? TraverseToNodeAtPosition(int position)
        {
            if (position > Size) return null;

            Node? traversalPointer = Head;

            int moves = 0;

            while (moves < position)
            {
                traversalPointer = traversalPointer?.NextLink;
                moves++;
            }

            return traversalPointer;
        }
        
        private Node? TraverseToOneNodeBeforePosition(int position)
        {
            int moves = 0;
            Node? traversalPointer = Head;
            
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