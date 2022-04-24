using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeProblems.LinkedLists.Tests;

[TestClass()]
public class P06_GetValueTests
{
    [TestMethod()]
    [DataRow(5, null, 1, 2, 3)]
    [DataRow(2, 3, 1, 2, 3)]
    [DataRow(0, 1, 1, 2, 3)]
    [DataRow(1, 2, 1, 2, 3)]
    public void SolutionTest(int index, int? expectedValue, params int?[] ints)
    {
        var node = ints.Length > 0 ? new Node<int?>(ints) : null;

        Assert.AreEqual(expectedValue, P06_GetValue.Solution(node, index));
    }
}
