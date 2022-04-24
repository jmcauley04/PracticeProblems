using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeProblems.LinkedLists.Tests
{
    [TestClass()]
    public class P04_IsInTests
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

            Assert.AreEqual(expected, P04_IsIn.Solution(node, searchTerm));
        }
    }
}