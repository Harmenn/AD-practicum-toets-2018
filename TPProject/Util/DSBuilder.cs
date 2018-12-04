using ADTP.Opdracht2Stack;
using ADTP.Opdracht3Tree;
using System.Collections.Generic;

namespace ADTP.Util
{
	public static class DSBuilder
    {
        public static IStack<int> MakeIntStack()
        {
			return new MyStack<int>();
        }

        public static IBinaryTree<char> MakePlusMinTree()
        {
			IBinaryTree<char> tree_T = new BinaryTree<char>();
			BinaryTree<char> tree_O = new BinaryTree<char>();
			BinaryTree<char> tree_X = new BinaryTree<char>();
			BinaryTree<char> tree_S = new BinaryTree<char>();
			BinaryTree<char> tree_K = new BinaryTree<char>();
			BinaryTree<char> tree_P= new BinaryTree<char>();
			BinaryTree<char> tree_E = new BinaryTree<char>();
			BinaryTree<char> tree_I = new BinaryTree<char>();

			tree_K.Merge('k', null, null);
			tree_X.Merge('x', tree_K, null);

			tree_S.Merge('s', null, null);

			tree_O.Merge('o', tree_X, tree_S);

			tree_E.Merge('e', null, null);

			tree_I.Merge('i', null, null);

			tree_P.Merge('p', tree_E, tree_I);

			tree_T.Merge('t', tree_O, tree_P);
			return tree_T;
        }

        public static IGraph MakeMapGraph()
        {
			Graph graph = new Graph();

			graph.AddEdge("Zwolle", "Kampen", 2);
			graph.AddEdge("Kampen", "Zwolle", 1);
			
			graph.AddEdge("Zwolle", "Wezep", 6);
			graph.AddEdge("Wezep", "Zwolle", 7);

			graph.AddEdge("Zwolle", "Heino", 1);
			graph.AddEdge("Heino", "Zwolle", 2);
			
			graph.AddEdge("Wezep", "'t Harde", 5);
			graph.AddEdge("'t Harde", "Wezep", 4);

			graph.AddEdge("'t Harde", "Heino", 6);
			graph.AddEdge("Heino", "'t Harde", 7);
			
			graph.AddEdge("Heino", "Raalte", 5);
			graph.AddEdge("Raalte", "Heino", 6);

			return graph;
        }
        
    }
}
