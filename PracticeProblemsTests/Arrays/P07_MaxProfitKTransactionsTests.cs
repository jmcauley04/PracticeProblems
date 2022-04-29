using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeProblems.Arrays.Tests
{
    [TestClass()]
    public class P07_MaxProfitKTransactionsTests
    {
        [TestMethod()]
        [DataRow(93, 2, 5, 11, 3, 50, 60, 90)]
        [DataRow(0, 1)]
        [DataRow(0, 1, 1)]
        [DataRow(9, 1, 1, 10)]
        [DataRow(9, 3, 1, 10)]
        [DataRow(6, 1, 3, 2, 5, 7, 1, 3, 7)]
        [DataRow(93, 3, 5, 11, 3, 50, 60, 90)]
        [DataRow(97, 2, 5, 11, 3, 50, 40, 90)]
        [DataRow(103, 3, 5, 11, 3, 50, 40, 90)]
        [DataRow(106, 2, 50, 25, 12, 4, 3, 10, 1, 100)]
        [DataRow(0, 5, 100, 99, 98, 97, 1)]
        [DataRow(1485, 5, 1, 100, 2, 200, 3, 300, 4, 400, 5, 500)]
        [DataRow(499, 5, 1, 100, 101, 200, 201, 300, 301, 400, 401, 500)]
        [DataRow(84, 4, 1, 25, 24, 23, 12, 36, 14, 40, 31, 41, 5)]
        [DataRow(62, 2, 1, 25, 24, 23, 12, 36, 14, 40, 31, 41, 5)]
        public void SolutionTest(int expected, int transactions, params int[] prices)
        {
            Assert.AreEqual(expected, P07_MaxProfitKTransactions.Solution(prices, transactions));
        }
    }
}