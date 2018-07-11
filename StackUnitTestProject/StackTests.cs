using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackClassLibrary;

namespace StackUnitTestProject
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void BasicPushPopTest()
        {
            CustomStack<int> stack = new CustomStack<int>();
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Pop());
        }

        [TestMethod]
        public void PushIncreasesCount()
        {
            CustomStack<int> stack = new CustomStack<int>();
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.Count);
        }

        [TestMethod]
        public void PopDecreasesCount()
        {
            CustomStack<int> stack = new CustomStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            Assert.AreEqual(1, stack.Count);
        }

        [TestMethod]
        public void BasicPeekTest()
        {
            CustomStack<int> stack = new CustomStack<int>();
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.Peek());
        }

        [TestMethod]
        public void BasicClearTest()
        {
            CustomStack<int> stack = new CustomStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Clear();
            try
            {
                stack.Pop();
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (!(e is InvalidOperationException))
                    Assert.Fail();
            }
        }

        [TestMethod]
        public void BasicContainsTest()
        {
            CustomStack<int> stack = new CustomStack<int>();
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(true, stack.Contains(1));
            Assert.AreEqual(false, stack.Contains(6));
        }

        [TestMethod]
        public void BasicToStringTest()
        {
            CustomStack<int> stack = new CustomStack<int>();
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual("2 1 ", stack.ToString());
        }

        [TestMethod]
        public void BasicToArrayTest()
        {
            CustomStack<int> stack = new CustomStack<int>();
            stack.Push(1);
            stack.Push(2);
            var arr = stack.ToArray();
            Assert.AreEqual(2, arr[0]);
            Assert.AreEqual(1, arr[1]);
        }
    }
}
