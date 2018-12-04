using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADTP.Opdracht2Stack;
using ADTP.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TPUnitTests
{
    [TestClass]
    public class StackTests
    {
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

        [TestMethod]
        public void Stack_b_Empty()
        {
            IStack<int> intStack = DSBuilder.MakeIntStack();
            Assert.AreEqual("", intStack.ToString());
        }

        [TestMethod]
        public void Stack_b_Push()
        {
            IStack<int> intStack = makeStack1();
            Assert.AreEqual("4/1-3/3-1/1-2/1-1/2", intStack.ToString());
        }

        [TestMethod]
        public void Stack_c_Pop1()
        {
            IStack<int> intStack = makeStack1();
            Assert.AreEqual(4, intStack.Pop());
            Assert.AreEqual(3, intStack.Pop());
            Assert.AreEqual(3, intStack.Pop());
        }
        [TestMethod]
        public void Stack_c_PopAndTop1()
        {
            IStack<int> intStack = makeStack1();
            Assert.AreEqual(4, intStack.Top());
            Assert.AreEqual(4, intStack.Top());
            Assert.AreEqual(4, intStack.Pop());
            Assert.AreEqual(3, intStack.Top());
        }

        [TestMethod]
        public void Stack_d_Count()
        {
            IStack<int> intStack = makeStack1();
            Assert.AreEqual(8, intStack.Count());
        }

        [TestMethod]
        public void Stack_e_Expand1()
        {
            IStack<int> intStack = makeStack1();
            intStack.Expand();
            Assert.AreEqual("4/1-3/1-3/1-3/1-1/1-2/1-1/1-1/1", intStack.ToString());
        }
        
        
    }
}
