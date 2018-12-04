using ADTP.Opdracht2Stack;
using ADTP.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTP.Opdracht2Stack
{
	class MyStack<T> : IStack<T>
	{
		private Node<T> headerNode;
		public int Count()
		{
			Node<T> currentNode = headerNode;
			int count = currentNode.count;
			while (currentNode.next != null)
			{
				currentNode = currentNode.next;
				count += currentNode.count;
			}
			return count;
		}

		public void Expand()
		{
			Node<T> currentNode = headerNode;
			while (currentNode != null)
			{
				while(currentNode.count > 1)
				{
					Node<T> newNode = new Node<T>(currentNode.value, currentNode.next);
					newNode.count = currentNode.count - 1;
					currentNode.count = 1;
					currentNode.next = newNode;
					currentNode = currentNode.next;
				}
				currentNode = currentNode.next;
			}
		}

		public IStack<int> MakeStack1()
		{
			IStack<int> intStack = DSBuilder.MakeIntStack();
			intStack.Push(1); intStack.Push(1);
			intStack.Push(2);
			intStack.Push(1);
			intStack.Push(3); intStack.Push(3); intStack.Push(3);
			intStack.Push(4);
			return intStack;
		}

		public T Pop()
		{
			Node<T> lastNode = null;
			Node<T> currentNode = headerNode;
			while(currentNode.next != null)
			{
				lastNode = currentNode;
				currentNode = currentNode.next;
			}
			if (currentNode.count == 1)
			{
				lastNode.next = null;
			}
			else
			{
				lastNode.count--;
			}
			return currentNode.value;
		}

		public void Push(T data)
		{
			if (headerNode == null)
			{
				this.headerNode = new Node<T>(data, null);
			}
			else
			{
				Node<T> currentNode = headerNode;
				while (currentNode.next != null)
				{
					currentNode = currentNode.next;
				}
				if (currentNode.value.Equals(data))
				{
					currentNode.count++;
				}
				else
				{
					Node<T> newNode = new Node<T>(data, null);
					currentNode.next = newNode;
				}
			}
		}

		public T Top()
		{
			Node<T> currentNode = headerNode;
			while (currentNode.next != null)
			{
				currentNode = currentNode.next;
			}
			return currentNode.value;
		}

		public override string ToString()
		{
			string rStr = "";
			Node<T> currentNode = headerNode;
			while (currentNode != null)
			{
				rStr = currentNode.value + "/" + currentNode.count + "-" + rStr;
				currentNode = currentNode.next;
			}
			int c = rStr.Length-1;
			if (c == -1) c = 0;
			return rStr.Substring(0, c);
		}

	}

	public class Node<T>
	{
		public T value;
		public Node<T> next;
		public int count = 0;
		//public Node previous;

		// De constructor instantieert een nieuwe Node met een generic value en een referentie naar de volgende node
		public Node(T value, Node<T> next)
		{
			this.value = value;
			this.next = next;
			this.count = 1;
		}
	}
}
