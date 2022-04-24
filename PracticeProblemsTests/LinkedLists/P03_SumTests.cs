using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace PracticeProblems.LinkedLists.Tests;

[TestClass()]
public class P03_SumTests
{
    [TestMethod()]
    [DataRow(4, 5, 20, 30)]
    [DataRow(0)]
    [DataRow()]
    [DataRow(5, -20)]
    public void SumListTest(params int[] ints)
    {
        var node = ints.Length == 0 ? null : new Node<int>(ints);

        var expected = ints.Sum();
        var actual = P03_Sum.Solution(node);

        Assert.AreEqual(expected, actual);
    }
}
