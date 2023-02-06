namespace SinglyLinkedList
{
	class SinglyLinkedList {

		private int _size;
		private Node? _head;

		public int Size {
			get { return _size; }
		}
		
		public SinglyLinkedList()
		{
			this._head = null;
			this._size = 0;
		}

		public bool PrependNode(Node node)
		{
			if (node is null) return false;
			
			else if (_head is null)
			{
				_head = node;
				_size++;
				return true;
			}

			else
			{
				Node oldHead = _head;
				node.NextLink = oldHead;
				_head = node;
				_size++;
				return true;
			}
		}

		// appendNode
		public bool appendNode(Node node)
		{
			if (node is null) return false;

			else if (_head is null)
			{
				_head = node;
				_size++;
				return true;
			}
			
			else
			{
				Node endNode = TraverseToEndOfList();
				endNode.NextLink = node;
				_size++;
				return true;
			}
		}

		// removeNodeAtPosition
		// removeHead
		// removeTail
		// insertNodeAtPosition
		// clearList
		// isEmpty
		public void DisplayList()
		{
			Node temp = _head!;
			Console.Write("[");
			int moves = 0;
			while (temp != null)
			{
				if (moves == _size - 1) 
					Console.Write(temp.Data);
				else 
					Console.Write(temp.Data + ", ");

				temp = temp.NextLink;
				moves++;
			}
			Console.WriteLine("]");
		}
		

		// helpers
		private Node TraverseToEndOfList()
		{
			Node temp = _head;
			
			while (temp?.NextLink != null)
				temp = temp.NextLink;

			return temp;
		}
		// 
	}	
}