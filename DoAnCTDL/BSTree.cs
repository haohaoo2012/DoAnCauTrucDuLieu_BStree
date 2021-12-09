using System;


namespace DoAnCTDL
{
	public class BSTree
	{
		private int size;
		public Node root;

		public BSTree()
		{
			size = 0;
			root = null;
		}

		public int Size()
		{
			return size;
		}
//Insert
		public  void insert(Node newNode)
		{
			root = insert(root, newNode);
		}

		private Node insert(Node node, Node newNode)
		{
			if (node == null)
			{
				size++;
				return newNode;
			}

			if (newNode.lessThanOrEqual(node.product))
			{
				node.left = insert(node.left, newNode);
			}
			else
			{
				node.right = insert(node.right, newNode);
			}
			return node;
		}
//Search
		public Node search(int productId)
		{
			return search(this.root, productId);
		}

		private Node search(Node node, int productId)
		{
			if (node == null)	return null;


			if (node.hasproduct(productId))
			{
				return node;
			}
			if (node.lessThan(productId))
			{
				return search(node.right, productId);
			}
			else
			{
				return search(node.left, productId);
			}
		}
//Delete
		public void delete(int productId)
		{
			root = delete(root, productId);
		}

		public Node delete(Node node, int productId)
		{
			if (node == null) return null;


			if (node.hasproduct(productId))
			{
				size--;
				if (node.left == null)
				{
					return node.right;
				}
				Node maxNode = node.left;
				Node preNode = maxNode;
				while (maxNode.right != null)
				{
					preNode = maxNode;
					maxNode = maxNode.right;
				}

          //      Console.WriteLine("\n\n----------------------------------------NodeInfor----------------------------------------");
          //      Console.Write("\npreNode: ");
          //      preNode.Data();
          //      Console.Write("\n\nmaxnode: ");
          //      maxNode.Data();
		        //Console.WriteLine("\n\n-----------------------------------------------------------------------------------------");
				
				maxNode.right = node.right;
				if (maxNode != node.left)
				{
					preNode.right = maxNode.left;
					maxNode.left = node.left;
					
				}
				return maxNode;
			}
			if (node.lessThan(productId))
			{
				node.right = delete(node.right, productId);
			}
			else
			{
				node.left = delete(node.left, productId);
			}
			return node;
            
		}
//TraversePreOrder
		public void TraversePreOrder()
		{
			Console.Write("\n\n----------------------------------------TraversePreOrder-----------------------");
			TraversePreOrder(root);
		}

		private void TraversePreOrder(Node node)
		{
			if (node == null) return;
			node.Data();
			TraversePreOrder(node.left);
			TraversePreOrder(node.right);
		}
//TraverseInOrder
		public void TraversetInOrder()
		{
			Console.Write("\n\n----------------------------------------TraverseInOrder----------------------------------------");
			TraverseInOrder(root);
		}

		private void TraverseInOrder(Node node)
		{
			if (node == null) return;
			TraverseInOrder(node.left);
			node.Data();
			TraverseInOrder(node.right);
		}
//TraversePostOrder
		public void TraversePostOrder()
		{
			Console.Write("\n\n----------------------------------------TraversePostOrder----------------------------------------");
			TraversePostOrder(root);
		}

		private void TraversePostOrder(Node node)
		{
			if (node == null)
			{
				return;
			}
			TraversePostOrder(node.left);
			TraversePostOrder(node.right);
			node.Data();
		}
	}
}
