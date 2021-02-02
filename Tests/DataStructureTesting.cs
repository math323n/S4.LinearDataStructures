using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class DataStructureTesting
    {
        [TestMethod]
        public void TestCreation()
        {
            List<int> list = new(10);
        }

        [TestMethod]
        public void TestInsert()
        {
            List<int> list = new(10);
            list.Insert(1, 1);
        }

        [TestMethod]
        public void TestRemove()
        {
            List<int> list = new(10);
            list.Remove(4);
        }

        [TestMethod]
        public void TestResizeTo()
        {
            List<int> list = new(10);
            list.ResizeTo(5);
        }
    }
}
