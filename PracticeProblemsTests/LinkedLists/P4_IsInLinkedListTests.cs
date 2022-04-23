using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeProblems.LinkedLists.Tests
{
    [TestClass()]
    public class P4_IsInLinkedListTests
    {
        [TestMethod()]
        [DataRow(1, false, 2, 3, 4, 5, 6)]
        [DataRow(4, true, 2, 3, 4, 5, 6)]
        [DataRow(4, false)]
        [DataRow(1, true, 1, 2, 3)]
        [DataRow(3, true, 1, 2, 3)]
        [DataRow(1, true, 1)]
        public void SolutionTest(int searchTerm, bool expected, params int[] ints)
        {
            var node = ints.Length > 0 ? new Node<int>(ints) : null;

            Assert.AreEqual(expected, P4_IsInLinkedList.Solution(node, searchTerm));
        }
    }
}