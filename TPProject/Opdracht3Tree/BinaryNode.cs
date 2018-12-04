using System;

namespace ADTP.Opdracht3Tree
{
	public class BinaryNode<T>
	{
		public T Element { get; }
		public BinaryTree<T> Left { get; set; }
		public BinaryTree<T> Right { get; set; }

		public BinaryNode(T x)
		{
			Element = x;
			Left = null;
			Right = null;
		}
	}
}