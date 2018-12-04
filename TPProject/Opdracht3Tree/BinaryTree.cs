using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTP.Opdracht3Tree
{
	public class BinaryTree<T> : IBinaryTree<T>
	{
		private BinaryNode<T> StartNode;
		private BinaryTree<T> t1;
		private BinaryTree<T> t2;
		public T Decode(string signals)
		{
			BinaryTree<T> tree = this;
			char[] chars = signals.ToCharArray();
			for (int i = 0; i < chars.Length; i++)
			{
				if (chars[i] == '-')
				{
					tree = tree.t1;
				}
				else if (chars[i] == '+')
				{
					tree = tree.t2;
				}
			}
			return tree.StartNode.Element;
			
		}

		public string Encode(T elem)
		{
			string signal = "";
			if (this.t1 == null)
				return signal;

			if (this.t1.StartNode.Element.Equals(elem))
				return signal + "-";

			if (this.t2 == null)
				return signal;

			else if (this.t2.StartNode.Element.Equals(elem))
				return signal + "+";

			string t1_search = this.t1.Encode(elem);
			if (t1_search != "")
				signal = "-" + t1_search;

			string t2_search =  this.t2.Encode(elem);
			if (t2_search != "")
				signal = "+" + t2_search;

			return signal;
		}

		public BinaryNode<T> GetRoot()
		{
			return this.StartNode;
		}

		public int Height()
		{
			throw new NotImplementedException();
		}

		public bool IsEmpty()
		{
			if (t1 == null && t2 == null)
				return true;
			else
				return false;
		}

		public void MakeEmpty()
		{
			t1 = null;
			t2 = null;
		}

		public void Merge(T rootItem, BinaryTree<T> t1, BinaryTree<T> t2)
		{
			BinaryTree<T> t;
			if(this.StartNode == null)
				t = this;
			else if (this.t1 == null)
				t = t1;
			else
				t = t2;

			t.StartNode = new BinaryNode<T>(rootItem);
			t.t1 = t1;
			t.t2 = t2;
		}

		public void PrintInOrder()
		{
			string s = "";
			BinaryNode<T> minNode = StartNode;
			while (minNode != null)
			{
				minNode = minNode.Left.StartNode;
				if (minNode.Left != null) continue;
				break;
			}

			s += minNode.Element;
			Console.WriteLine(s);
		}

		public void PrintPostOrder()
		{
			throw new NotImplementedException();
		}

		public void PrintPreOrder()
		{
			throw new NotImplementedException();
		}

		public int Size()
		{
			throw new NotImplementedException();
		}

		public string ToPreorderString()
		{
			string rStr = StartNode.Element.ToString();
			if(this.t1 != null)
			{
				rStr += t1.ToPreorderString();
			}
			if (this.t2 != null)
			{
				rStr +=  t2.ToPreorderString();
			}
			return rStr;
		}
	}
}
