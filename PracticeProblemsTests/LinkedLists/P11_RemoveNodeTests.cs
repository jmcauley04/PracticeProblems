using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeProblems.LinkedLists.Tests;

[TestClass()]
public class P11_RemoveNodeTests
{
    [TestMethod()]
    [DataRow(2, 1, 2, 3, 4, 5, 6, 7, 8)]
    [DataRow(6, 1, 2, 3, 4, 5, 6, 7, 8)]
    [DataRow(16, 1, 2, 3, 4, 5, 6, 7, 8)]
    [DataRow(0, 1, 2, 3, 4, 5, 6, 7, 8)]
    [DataRow(1, 1, 2, 3, 4, 5, 6, 7, 8)]
    public void SolutionTest(int targetIndex, params int[] ints)
    {
        var node = new Node<int>(ints);

        node = P11_RemoveNode.Solution(node, targetIndex);

        for (int i = 0; i < ints.Length; i++)
        {
            if (i != targetIndex)
            {
                Assert.AreEqual(ints[i], node!.Value);
                node = node.Next;
            }
        }
    }
}
