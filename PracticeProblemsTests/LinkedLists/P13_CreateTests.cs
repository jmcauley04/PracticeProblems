using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeProblems.LinkedLists.Tests;

[TestClass()]
public class P13_CreateTests
{
    [TestMethod()]
    [DataRow(1, 2, 3, 4, 5)]
    public void SolutionTest(params int[] ints)
    {
        var head = P13_Create.Solution(ints);

        for (int i = 0; i < ints.Length; i++)
        {
            Assert.AreEqual(ints[i], head?.Value);
            head = head?.Next;
        }
    }
}
