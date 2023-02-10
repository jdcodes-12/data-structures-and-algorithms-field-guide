package SinglyLinkedList;

public class Node {
	int data;
	Node nextLink;
	
	public Node() {
		data = -1;
		nextLink = null;
	}
	
	public Node(int data) {
		this.data = data;
		nextLink = null;
	}
	
	public void displayNode() {
		System.out.print("[" + data + " | " + nextLink + "]\n");
	}
}