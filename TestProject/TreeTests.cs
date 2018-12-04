using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ADTP.Util;
using ADTP.Opdracht3Tree;

namespace TPUnitTests
{
    [TestClass]
    public class TreeTests
    {
        [TestMethod]
        public void Tree_a_Make()
        {
            IBinaryTree<char> bt = DSBuilder.MakePlusMinTree();
            Assert.AreEqual("toxkspei", bt.ToPreorderString());
        }
        
        [TestMethod]
        public void Tree_b_Decode1()
        {
            IBinaryTree<char> bt = DSBuilder.MakePlusMinTree();
            char s = bt.Decode("---");
            Assert.AreEqual('k', s);

        }
        [TestMethod]
        public void Tree_b_Decode2()
        {
            IBinaryTree<char> bt = DSBuilder.MakePlusMinTree();
            char s = bt.Decode("+-");
            Assert.AreEqual('e', s);

        }
        [TestMethod]
        public void Tree_c_Encode1()
        {
            IBinaryTree<char> bt = DSBuilder.MakePlusMinTree();
            string s = bt.Encode('k');
            Assert.AreEqual("---", s);

        }
        [TestMethod]
        public void Tree_c_Encode2()
        {
            IBinaryTree<char> bt = DSBuilder.MakePlusMinTree();
            string s = bt.Encode('e');
            Assert.AreEqual("+-", s);

        }
    }
}
