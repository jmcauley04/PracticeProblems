using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeProblems.LinkedLists.Tests;

[TestClass()]
public class P08_ZipperTests
{
    [TestMethod()]
    [DataRow(
        2,
        5,
        1, 2,
        3, 4, 5, 6, 7,
        1, 3, 2, 4, 5, 6, 7)]
    [DataRow(
        5,
        2,
        1, 2, 3, 4, 5,
        6, 7,
        1, 6, 2, 7, 3, 4, 5)]
    [DataRow(
        3,
        3,
        1, 2, 3,
        5, 6, 7,
        1, 5, 2, 6, 3, 7)]
    public void SolutionTest(int lengthOfA, int lengthOfB, params int[] ints)
    {
        var aInts = ints[..lengthOfA];
        var bInts = ints[lengthOfA..(lengthOfB + lengthOfA)];
        var expected = ints[(lengthOfB + lengthOfA)..];

        var a = new Node<int>(aInts);
        var b = new Node<int>(bInts);

        var result = P08_Zipper.Solution(a, b);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.AreEqual(expected[i], result?.Value);
            result = result?.Next;
        }

        Assert.IsNull(result);
    }
}
