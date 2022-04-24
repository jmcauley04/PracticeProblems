using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeProblems.LinkedLists.Tests
{
    [TestClass()]
    public class P09_IsUnivalueTests
    {
        [TestMethod()]
        [DataRow(true, 1, 1, 1, 1)]
        [DataRow(false, 2, 2, 0, 2)]
        [DataRow(false, 2, 2, 2, 0)]
        [DataRow(false, 0, 2, 2, 2)]
        [DataRow(true, 1)]
        public void IsUnivalueTest(bool expected, params int[] ints)
        {
            Node<int>? node = null;

            if (ints.Length > 0)
                node = new Node<int>(ints);

            Assert.AreEqual(expected, P09_IsUnivalue.Solution(node));
        }
    }
}