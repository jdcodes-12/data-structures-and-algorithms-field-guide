package SinglyLinkedList;

public class SinglyLinkedList {

	private int size = 0;
	private Node head;
	private Node tail;
	public SinglyLinkedList() {
		size = 0;
		head = null;
	}
	
	public boolean preprendNode(Node node) {
		if (node == null) return false;
		
		if (head == null) {
			head = node;
			tail = head;
			size++;
			return true;
		}
		
		Node oldHead = head;
		head = node;
		head.nextLink = oldHead;
		size++;
		return true;
	}
	
	public boolean appendNode(Node node) {
		if (node == null) return false;
		
		head.nextLink = node;
		tail = node;
		size++;
		return true;
	}
	 
	public Node removeNodeFromHead() {
		Node nodeToReturn = head;
		head = head.nextLink;
		return nodeToReturn;
	}
	
	public Node removeNodeFromTail() {
		Node nodeToReturn = tail;
		int tailPosition = size;
		tail = traverseToNodeBeforePosition(tailPosition);
		System.out.println("New tail: " + tail.data);
		return tail;
	}

	// insertNodeAtIndex() : Node
	
	public void displayList() {
		Node temp = head;
		int moves = 0;
		
		System.out.println("[");
		while (temp.nextLink != null) {
			if (moves == size) 
				System.out.print(temp.data);
			else 
				System.out.print(temp.data + " ");
		}
		System.out.println("]");
	}
	
	public boolean clearList() {
		size = 0;
		head = null;
		tail = null;
		return true;
	}
	
	public int getListSize() {
		return size;
	}
	
	public boolean isEmpty() {
		return size == 0;
	}
	
	// -- Helpers --
	private Node traverseToNodeBeforePosition(int index) {
		 System.out.println("inside traverseToNodeBeforePosition()");
		 Node temp = head;
		 int moves = 0;
		 int targetLocation = index - 1;
		 
		 while (temp.nextLink != null && moves < targetLocation) {
			 temp = temp.nextLink;
		 }
		 
		 System.out.println(temp.data);
		 return temp;
	 }

}
