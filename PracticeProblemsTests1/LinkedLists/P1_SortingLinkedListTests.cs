using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using static PracticeProblems.LinkedLists.P1_SortingLinkedList;

namespace SolutionTests.LinkedLists.Tests;

[TestClass]
public class P1_SortingLinkedListTests
{
    [TestMethod()]
    [DataRow(3, 3, 10, 20, 1, 5, 7)]
    [DataRow(0)]
    [DataRow(0, 1)]
    [DataRow(1, 1)]
    [DataRow(3, 3, 3, 13, 1, 3, 7)]
    public void SolutionTests(int nodeASize, params int[] ints)
    {
        Node? a = null;
        Node? b = null;

        if (nodeASize > 0)
            a = new Node(ints[0..nodeASize]);

        if (ints.Length - nodeASize > 0)
            b = new Node(ints[nodeASize..]);

        var result = Solution(a, b);

        foreach (var i in ints.OrderBy(x => x))
        {
            Assert.AreEqual(i, result!.Data);
            result = result.Next;
        }
    }
}
