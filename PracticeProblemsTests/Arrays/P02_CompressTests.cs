using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeProblems.Arrays.Tests;

[TestClass()]
public class P02_CompressTests
{
    [TestMethod()]
    [DataRow("abcccdeef", "abc3de2f")]
    [DataRow("abcccccdeef", "abc5de2f")]
    [DataRow("abcccccdeee", "abc5de3")]
    [DataRow("aabcccccdeee", "a2bc5de3")]
    [DataRow("abc", "abc")]
    [DataRow("", "")]
    public void SolutionTest(string input, string expected)
    {
        Assert.AreEqual(expected, P02_Compress.Solution(input));
    }
}
