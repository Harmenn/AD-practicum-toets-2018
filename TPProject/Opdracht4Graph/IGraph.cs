using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTP
{
    public interface IGraph
    {
        IVertex GetVertex(string name);
        void AddEdge(string source, string dest, double cost);
        string ToString();
        void Unweighted(string name);
        void Dijkstra(string name);
        bool IsConnected();

        string toString2();

        // Opgave 3
        List<string> VerticesNotOnShortestPath(string origin, string destination);
    }
}
