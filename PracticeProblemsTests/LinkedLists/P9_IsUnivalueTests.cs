using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeProblems.LinkedLists.Tests
{
    [TestClass()]
    public class P9_IsUnivalueTests
    {
        [TestMethod()]
        [DataRow(true, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14)]
        [DataRow(false, 1, 1, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14)]
        [DataRow(false, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 14, 14)]
        [DataRow(false, 1, 2, 3, 4, 5, 6, 7, 8, 8, 10, 11, 12, 13, 14)]
        [DataRow(true, 1)]
        [DataRow(true)]
        public void IsUnivalueTest(bool expected, params int[] ints)
        {
            Node<int>? node = null;

            if (ints.Length > 0)
                node = new Node<int>(ints);

            Assert.AreEqual(expected, P9_IsUnivalue.Solution(node));
        }
    }
}