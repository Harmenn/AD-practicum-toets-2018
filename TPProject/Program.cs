using ADTP.Opdracht2Stack;
using ADTP.Opdracht3Tree;
using ADTP.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ADTP
{
    class Program
    {
        static void Main(string[] args)
		{
			var graph = DSBuilder.MakeMapGraph();
			int fromZwolle = graph.GetVertex("Zwolle").Outgoing();
			Console.WriteLine(fromZwolle);
			Console.Read();
		}
		private static IStack<int> makeStack1()
		{
			IStack<int> intStack = DSBuilder.MakeIntStack();
			intStack.Push(1); intStack.Push(1);
			intStack.Push(2);
			intStack.Push(1);
			intStack.Push(3); intStack.Push(3); intStack.Push(3);
			intStack.Push(4);
			return intStack;
		}
	}
}