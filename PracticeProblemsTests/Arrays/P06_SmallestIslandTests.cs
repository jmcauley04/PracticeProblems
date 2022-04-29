using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeProblems.Arrays.Tests
{
    [TestClass()]
    public class P06_SmallestIslandTests
    {
        [TestMethod()]
        [DataRow(
            3,
            3,
            1, 0, 1,
            1, 0, 1,
            1, 0, 1)]
        [DataRow(
            3,
            1,
            1, 1, 0,
            1, 0, 1,
            1, 0, 1)]
        public void SolutionTest(int matrixWidth, int minSize, params int[] ints)
        {
            var height = ints.Length / matrixWidth;
            var matrix = new int[matrixWidth, height];

            for (int i = 0; i < matrixWidth; i++)
                for (int j = 0; j < height; j++)
                    matrix[i, j] = ints[i + matrixWidth * j];

            var result = P06_SmallestIsland.Solution(matrix);

            Assert.AreEqual(minSize, result);
        }
    }
}