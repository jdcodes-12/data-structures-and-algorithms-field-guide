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
		public bool AppendNode(Node node)
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

		public Node? RemoveHeadNode()
		{
			if (_head is null) return null;

			Node removedNode = _head;
			_head = _head?.NextLink;
			_size--;
			return removedNode;
		}

		public Node? RemoveTailNode()
		{
			Node nodeBeforeTail = TraverseToPositionBefore(_size - 1);
			Node tailNode = nodeBeforeTail?.NextLink;
			nodeBeforeTail.NextLink = null;
			_size--;
			return tailNode;
			
		}
		// removeNodeAtPosition
		
		// insertNodeAtPosition
		 		
		public bool IsEmpty()
		{
			return _size == 0;
		}

		public bool ClearList()
		{
			_head = null;
			_size = 0;
			return true;
		}

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
		
		private Node TraverseToEndOfList()
		{
			Node temp = _head;
			
			while (temp?.NextLink != null)
				temp = temp.NextLink;

			return temp;
		}

		private Node TraverseToPositionBefore(int position)
		{
			Node travPointer = _head;
			int moves = 0;

			while (moves < position - 1)
			{
				travPointer = travPointer?.NextLink;
				moves++;
			}
		

			return travPointer;
		}
	}	
}