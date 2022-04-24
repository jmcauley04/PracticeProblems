using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using static PracticeProblems.LinkedLists.P02_ReturningValues;

namespace PracticeProblems.LinkedLists.Tests;

[TestClass()]
public class P02_ReturningValuesTests
{
    [TestMethod()]
    [DataRow(2)]
    [DataRow()]
    [DataRow(4, 5, 6, 2, 3, 1)]
    public void SolutionTest(params int[] ints)
    {
        Node<int>? node = ints.Length > 0 ? new Node<int>(ints) : null;

        var result = Solution(node).ToArray();
        Assert.AreEqual(ints.Length, result.Length);

        if (ints.Length == 0)
            Assert.AreEqual(Array.Empty<int>(), result);
        else
            for (int i = 0; i < ints.Length; i++)
                Assert.AreEqual(ints[i], result[i]);
    }
}
