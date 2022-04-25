using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeProblems.Arrays.Tests;

[TestClass()]
public class P03_DecompressTests
{
    [TestMethod()]
    [DataRow("a5bc", "aaaaabc")]
    [DataRow("abc5", "abccccc")]
    [DataRow("ab2c5", "abbccccc")]
    [DataRow("a5b2c5", "aaaaabbccccc")]
    [DataRow("a15bc5", "aaaaaaaaaaaaaaabccccc")]
    public void SolutionTest(string input, string expected)
    {
        Assert.AreEqual(expected, P03_Decompress.Solution(input));
    }
}
