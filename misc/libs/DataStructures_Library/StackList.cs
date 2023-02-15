namespace DataStructuresLib
{
    public class StackList
    {
        public int Size { get; set; }
        public DoubleLinkNode? Top { get; set; }
        public DoubleLinkNode? Base { get; set; }

        public StackList()
        {
            Size = 0;
            Top = null;
        }
        
        public bool Push(DoubleLinkNode? node)
        {
            if (NodeIsNull(node)) return false;

            else if (IsEmpty())
            {
                Base = node;
                Top = node;
                Size++;
                return true;
            }

            else if (OnlyOneNodeInStack())
            {
                Base.NextLink = node;
                node.PrevLink = Base;
                Top = node;
                Size++;
                return true;
            }

            else
            {
                Top.NextLink = node;
                node.PrevLink = Top;
                Top = node;
                Size++;
                return true;
            }
        }
        
        public DoubleLinkNode Pop()
        {
            if (IsEmpty()) return null;

            else if (OnlyOneNodeInStack())
            {
                DoubleLinkNode oldTop = Top;
                Top = null;
                Base = null;
                Size--;
                return oldTop;
            }

            else
            {
                DoubleLinkNode oldTop = Top;
                Top = Top.PrevLink;
                Size--;
                return oldTop;
            }
        }
       
        public DoubleLinkNode Peek()
        {
            if (IsEmpty()) return null;
            else return Top;
        }

        
        // PeekAtPosition()
        public bool ClearStack()
        {
            Base = null;
            Top = null;
            Size = 0;
            return true;
        }
        // DisplayStack()
        
        public bool IsEmpty() => Size <= 0;

        // --- Utility Functions ---

        // Node Checks
        private bool NodeIsNull(DoubleLinkNode node) => node == null;
        private bool OnlyOneNodeInStack() => Size == 1;

        // Traversals
        //private DoubleLinkNode TraverseStack_TopDown()
        //{
        //   // start from top
        //   // while top.prevLink != null
        //    // move top = top.prevLink

        //  // return bottomNode
        //}
        
    }
}