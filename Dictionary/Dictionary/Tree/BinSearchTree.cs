using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
	class BinSearchTree :ISetSorted
	{
		private Node root = null;

        public void print()
        {
            return;
        }
		void Delete(int s)
		{
			string dir="";
			Node a = this.root;
			Node b;
			Node preda = null;
			Search(ref a, s, ref preda);

			if(a == null)
			{
				return;
			}
			if (a.right != null && a.left != null)
			{
				DelSymPred(a);
				return;
			}
			if(a.left == null)
			{
				b = a.right;
			}
			else
			{
				b = a.left;
			}
			if(this.root == a)
			{
				this.root = b;
				a = null;
				return;
			}
			if(dir == "left")
			{
				preda.left = b;
			}
			else
			{
				preda.right = b;
			}
			a = null;
			return;
		}

		void DelSymPred (Node a)
		{
			Node b;
			Node c;
			b = a;
			if(b.left.right != null)
			{
				b = b.left;
				while(b.right.right != null)
				{
					b = b.right;
				}
			}
			if (b == a)
			{
				c = b.left;
				b.left = c.left;
			}
			else
			{
				c = b.right;
				b.right = c.left;
			}
			a.data = c.data;
			c = null;
		}
		public string Search(ref Node a, int item, ref Node preda)
		{
			string dir = "";
			while (a != null)
			{
				if (item < a.data)
				{
					preda = a;
					a = a.left;
					dir = "left";
				}
				else
				{
					if (item > a.data)
					{
						preda = a;
						a = a.right;
						dir = "right";
					}
					else
					{
						break;
					}
				}

			}
			return dir;
		}

		public bool isEmpty()
		{
			return root == null;
		}

		public class Node
		{
			public Node left;
			public Node right;
			public int data;

			public Node(int d)
			{
				data = d;
				left = null;
				right = null;
			}
			public bool isLeaf(Node node)
			{
				return (node.left == null && node.right == null);
			}



			void Print(Node root)
			{
				if (root == null)
				{
					return;
				}
				Print(root.left);
				Print(root.right);
			}
			public Node Search(BinSearchTree tree, int s)
			{
				Node a = tree.root;
				while (a.data != s && a != null)
				{
					if (s < a.data)
					{
						a = a.left;
					}
					else
					{
						a = a.right;
					}
				}
				return a;
			}

			public void Insert(BinSearchTree tree, int s)
			{
				Node a = tree.root;
				Node b = null;
				while (a.data != s && a != null)
				{
					b = a;
					if (s < a.data)
					{
						a = a.left;
					}
					else
					{
						a = a.right;
					}
				}
				if (a == null)
				{
					a = new Node(s);
					a.left = null;
					a.right = null;
					if (b == null)
					{
						tree.root = a;
						return;
					}
					if (s < b.data)
					{
						b.left = a;
					}
					else
					{
						b.right = a;
					}
				}
			}


			//public bool nodeSearch(Node node, int s)
			//{
			//    if (node == null)
			//    {
			//        return false;
			//    }
			//    if (node.data == s)
			//    {
			//        return true;
			//    }
			//    else if (node.data < s)
			//    {
			//        return nodeSearch(node.right, s);
			//    }
			//    else if (node.data > s)
			//    {
			//        return nodeSearch(node.left, s);
			//    }
			//    return true;
			//}

			//public void nodeInsert(Node node, int data)
			//{
			//    if (node == null)
			//    {
			//        node = new Node(data);
			//    }
			//    if (nodeSearch(node, data) == false)
			//    {
			//        if (node.data < data)
			//        {
			//            nodeInsert(node.right, data);
			//        }
			//        else if (node.data > data)
			//        {
			//            nodeInsert(node.left, data);
			//        }
			//    }
			//    else
			//        return;
			//}
			public void print(Node n)
			{
				if (n == null)
				{
					return;
				}
				print(n.left);
				Console.WriteLine(" " + n.data);
				print(n.right);
			}
		}
	}
}
