#region
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


        // removeNode
        // clearList
        // is empty
        // insertNodeAtIndex
        // removeNodeAtIndex

        public void DisplayList()
        {
            if (IsEmpty()) 
                return;

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

        private bool IsEmpty() => Size == 0;
        private bool OnlyHeadNode() => Size == 1;
    }
}