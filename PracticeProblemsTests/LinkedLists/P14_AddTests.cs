using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeProblems.LinkedLists.Tests;

[TestClass()]
public class P14_AddTests
{
    [TestMethod()]
    [DataRow(
        3,
        3,
        1, 2, 3, 4, 5, 6,
        5, 7, 9)]
    [DataRow(
        1,
        3,
        1, 4, 5, 6,
        5, 5, 6)]
    [DataRow(
        3,
        1,
        1, 4, 5, 6,
        7, 4, 5)]
    public void SolutionTest(int lengthA, int lengthB, params int[] ints)
    {
        var a = new Node<int>(ints[..lengthA]);
        var b = new Node<int>(ints[lengthA..(lengthA + lengthB)]);
        var expected = ints[(lengthA + lengthB)..];

        var node = P14_Add.Solution(a, b);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.AreEqual(expected[i], node?.Value);
            node = node?.Next;
        }
    }
}
