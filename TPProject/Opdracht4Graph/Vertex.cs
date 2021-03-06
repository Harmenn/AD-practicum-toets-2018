﻿using ADTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTP
{
	class Vertex : IVertex
	{
		public String name; // Vertex name
		public List<Edge> adj; // Adjacent vertices
		public double dist; // Cost
		public Vertex prev; // Previous vertex on shortest path
		public int scratch; // Extra variable used in algorithm

		public Vertex(String nm)
		{
			name = nm;
			adj = new List<Edge>();
			Reset();
		}

		public int Outgoing()
		{
			return adj.Count();
		}

		public void Reset()
		{
			dist = Graph.INFINITY; prev = null; scratch = 0;
		}
	}
}
