using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeProblems.LinkedLists.Tests
{
    [TestClass()]
    public class P12_InsertNodeTests
    {
        [TestMethod()]
        [DataRow(
            3,
            3,
            1,
            1, 2, 5,
            6, 8, 7,
            1, 6, 8, 7, 2, 5)]
        public void SolutionTest(int lengthA, int lengthB, int insertIndex, params int[] ints)
        {
            var node = new Node<int>(ints[..lengthA]);
            var other = new Node<int>(ints[lengthA..(lengthB + lengthA)]);
            var expected = ints[(lengthA + lengthB)..];

            var result = P12_InsertNode.Solution(node, other, insertIndex);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result?.Value);
                result = result?.Next;
            }
        }
    }
}