package SinglyLinkedList;

public class SinglyLinkedListDriver {

	public static void main(String[] args) {
		SinglyLinkedList list = new SinglyLinkedList();
	
		Node[] nodes = createNodes(10);
		
		prependNodes(list, nodes);
		
	}
	
	private static void prependNodes(SinglyLinkedList list, Node[] nodes) {
		System.out.print("Prepending Nodes: ");
		for (Node node : nodes) {
			System.out.println("Adding node: ");
			node.displayNode();
			System.out.println("\nWas added: " + list.preprendNode(node));
		}
		
		System.out.println("Current list state: ");
		list.displayList();
	}

	private static Node[] createNodes(int numNodesToCreate) {
		Node[] nodes = new Node[numNodesToCreate];
		for (int i = 0; i < numNodesToCreate; i++) {
			Node node = new Node(i+1);
			nodes[i] = node;
		}
		return nodes;
	}
	
	private static Node createDefaultNode() {
		return new Node();
	}
}
