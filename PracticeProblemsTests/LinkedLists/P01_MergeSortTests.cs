using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace PracticeProblems.LinkedLists.Tests;

[TestClass]
public class P01_MergeSortTests
{
    [TestMethod()]
    [DataRow(3, 3, 10, 20, 1, 5, 7)]
    [DataRow(3, 3, 7, 10, 1, 5, 20)]
    [DataRow(0)]
    [DataRow(0, 1)]
    [DataRow(1, 1)]
    [DataRow(3, 3, 3, 13, 1, 3, 7)]
    public void SolutionTest(int nodeASize, params int[] ints)
    {
        Node<int>? a = null;
        Node<int>? b = null;

        if (nodeASize > 0)
            a = new Node<int>(ints[0..nodeASize]);

        if (ints.Length - nodeASize > 0)
            b = new Node<int>(ints[nodeASize..]);

        var result = P01_MergeSort.Solution(a, b);

        foreach (var i in ints.OrderBy(x => x))
        {
            Assert.AreEqual(i, result!.Value);
            result = result.Next;
        }
    }
}
