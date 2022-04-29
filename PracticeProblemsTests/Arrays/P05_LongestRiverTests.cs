using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace PracticeProblems.Arrays.Tests
{
    [TestClass()]
    public class P05_LongestRiverTests
    {
        [TestMethod()]
        [DataRow(
            3,
            2,
            1, 0, 1,
            1, 0, 1,
            1, 0, 1,
            3, 3)]
        [DataRow(
            3,
            2,
            1, 1, 0,
            1, 0, 1,
            1, 0, 1,
            2, 4)]
        public void SolutionTest(int matrixWidth, int rivers, params int[] ints)
        {
            var solutionLength = ints.Length - rivers;
            var matrix = new int[matrixWidth, solutionLength / matrixWidth];

            for (int i = 0; i < matrixWidth; i++)
                for (int j = 0; j < solutionLength / matrixWidth; j++)
                    matrix[i, j] = ints[i + matrixWidth * j];

            var result = P05_LongestRiver.Solution(matrix);

            Assert.AreEqual(rivers, result.Count);

            int expectedIndex = solutionLength;

            foreach (var r in result.OrderBy(x => x))
                Assert.AreEqual(ints[expectedIndex++], r);
        }
    }
}