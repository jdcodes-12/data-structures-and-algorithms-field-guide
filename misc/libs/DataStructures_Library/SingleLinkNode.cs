namespace DataStructuresLib
{
    public class SingleLinkNode
    {
        public int Data { get; set; }
        public SingleLinkNode? NextLink { get; set; }

        public SingleLinkNode()
        {
            Data = -1;
            NextLink = null;
        }

        public SingleLinkNode(int data)
        {
            Data = data;
            NextLink = null;
        }

        public string StringifyNode() => $"[{Data} | {NextLink?.Data}]";
    }
}