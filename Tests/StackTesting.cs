using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class StackTesting
    {
        [TestMethod]
        public void TestCreateStack()
        {
            Stack<int> stack = new(0);
        }

        [TestMethod]
        public void TestPushStack()
        {
            Stack<int> stack = new(0);
            stack.Push(stack, 1);
            stack.Push(stack, 2);
            stack.Push(stack, 3);
            stack.Push(stack, 4);
            stack.Push(stack, 5);
        }

        [TestMethod]
        public void TestPopStack()
        {
            Stack<int> stack = new(0);
            stack.Push(stack, 1);
            stack.Push(stack, 2);
            stack.Push(stack, 3);
            stack.Push(stack, 4);
            stack.Push(stack, 5);
            stack.Pop(stack);
        }

        // Pop Empty stack with custom .Remove() method = IndexOutOfRangeException
        [TestMethod]
        public void RemoveFromEmptyStack()
        {
            Stack<int> stack = new(0);
            stack.Remove(0);

        }

        // Pop empty stack using .Pop() method = OverflowException
        [TestMethod]
        public void PopEmptyStack()
        {
            Stack<int> stack = new(0);
            stack.Pop(stack);

        }
    }
}