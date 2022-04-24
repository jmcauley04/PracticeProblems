using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeProblems.LinkedLists.Tests;

[TestClass()]
public class P07_ReverseTests
{
    [TestMethod()]
    [DataRow(1, 2, 3, 4, 5, 5, 4, 3, 2, 1)]
    [DataRow(1, 1)]
    [DataRow(1, 2, 2, 4, 5, 5, 4, 2, 2, 1)]
    public void SolutionTest(params int[] ints)
    {
        var size = ints.Length / 2;
        var node = new Node<int>(ints[..size]);
        var expected = new Node<int>(ints[size..]);

        node = P07_Reverse.Solution(node);
        for (int i = 0; i < size; i++)
        {
            Assert.AreEqual(expected?.Value, ints[size + i]);
            Assert.AreEqual(expected?.Value, node?.Value);
            expected = expected?.Next;
            node = node?.Next;
        }
    }

    [TestMethod()]
    public void SolutionTest_nullcase()
    {
        Node<int>? node = null;

        node = P07_Reverse.Solution(node);

        Assert.IsNull(node);
    }
}
