namespace DataStructuresLib
{
    public class DoubleLinkNode
    {
        public int Data { get; set; }
        public DoubleLinkNode? NextLink { get; set; }
        public DoubleLinkNode? PrevLink { get; set; }

        public DoubleLinkNode()
        {
            Data = -1;
            NextLink = null;
            PrevLink = null;
        }

        public DoubleLinkNode(int data)
        {
            Data = data;
            NextLink = null;
            PrevLink = null;
        }

        public string StringifyNode() => $"[{PrevLink?.Data} | {Data} | {NextLink?.Data}]";
    }
}