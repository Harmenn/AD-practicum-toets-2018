using System;
using System.Collections.Generic;
using System.Linq;
using ADTP.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TPUnitTests
{
    [TestClass]
    public class GraphTests
    {
        [TestMethod]
        public void Graph_a_MakeMap()
        {
            var graph = DSBuilder.MakeMapGraph();
            int fromZwolle = graph.GetVertex("Zwolle").Outgoing();
            Assert.AreEqual(3, fromZwolle);
        }
        [TestMethod]
        public void Graph_b_Zwolle_tHarde()
        {
            var expectedList = new List<string> {"Raalte", "Kampen", "Wezep"}; 
            var graph = DSBuilder.MakeMapGraph();
            List<string> notSP = graph.VerticesNotOnShortestPath("Zwolle", "'t Harde");
            CollectionAssert.AreEquivalent(expectedList, notSP);
        }



      
    }
}


    
   
