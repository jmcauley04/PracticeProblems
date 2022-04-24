using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeProblems.LinkedLists.Tests
{
    [TestClass()]
    public class P10_LongestStreakTests
    {
        [TestMethod()]
        [DataRow(3, 5, 4, 3, 4, 5, 4, 3)]
        [DataRow(3, 5, 4, 3, 4, 5, 4, 3, 5, 4, 3, 4, 5, 4, 3, 5, 4, 3, 4, 5, 4, 3)]
        [DataRow(4, 5, 4, 3, 4, 5, 4, 3, 5, 4, 3, 4, 5, 4, 3, 5, 4, 3, 4, 5, 4, 3, 6)]
        public void SolutionTest(int expected, params int[] ints)
        {
            var node = new Node<int>(ints);

            Assert.AreEqual(expected, P10_LongestStreak.Solution(node));

        }
    }
}