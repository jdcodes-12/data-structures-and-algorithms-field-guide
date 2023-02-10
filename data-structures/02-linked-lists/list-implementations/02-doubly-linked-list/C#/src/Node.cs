namespace DoublyLinkedList
{
    class Node
    {
        public int Data { get; set; }
        public Node? NextLink { get; set; }
        public Node? PrevLink { get; set; }

        public Node()
        {
            Data = -1;
            NextLink = null;
            PrevLink = null;
        }

        public Node(int data)
        {
            Data = data;
            NextLink = null;
            PrevLink = null;
        }

        public string StringifyNode() => $"[{PrevLink?.Data} | {Data} | {NextLink?.Data}]";
    }
}