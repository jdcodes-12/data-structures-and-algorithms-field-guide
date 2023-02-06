namespace SinglyLinkedList
{
    public class Node {

        public int Data { get; set; }
        public Node? NextLink { get; set; }

        public Node()
        {
            Data = -1;
            NextLink = null;
        }

        public Node (int data)
        {
            Data = data;
            NextLink = null;
        }

        public string StringifyNode()
        {
            return $@"[{Data} | {NextLink}]";
        }
    }
}