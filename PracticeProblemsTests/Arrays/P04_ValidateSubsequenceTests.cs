using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace PracticeProblems.Arrays.Tests
{
    [TestClass()]
    public class P04_ValidateSubsequenceTests
    {
        [TestMethod()]
        [DataRow(
            true,
            8,
            5, 1, 22, 25, 6, -1, 8, 10,
            1, 6, -1, 10)]
        [DataRow(
            false,
            8,
            5, 1, 22, 25, 6, -1, 8, 10,
            1, 6, 1, 10)]
        [DataRow(
            false,
            8,
            5, 1, 22, 25, 6, -1, 8,
            1, 6, -1, 10)]
        [DataRow(
            true,
            2,
            5, 1,
            5)]
        [DataRow(
            true,
            2,
            5, 1,
            1)]
        public void SolutionTest(bool expected, int arrayLength, params int[] ints)
        {
            var array = ints[..arrayLength].ToList();
            var subsequence = ints[arrayLength..].ToList();

            Assert.AreEqual(expected, P04_ValidateSubsequence.Solution(array, subsequence));
        }
    }
}